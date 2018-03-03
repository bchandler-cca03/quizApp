// JavaScript source code
"use strict";

(function () {
    var fetchButton = document.getElementById("fetch-button"),
        clearButton = document.getElementById("clear-button"),
        questionList = document.getElementById("question-list"),
        questionUrn = "/api/QuesGame/",
        httpRequest;
    var newButton = document.createElement("button");

    var getData = function () {
        console.log("HTTPRequest State: " + httpRequest.readyState +
            " Status: " + httpRequest.status + " : " + httpRequest.responseText);

        if (httpRequest.readyState === XMLHttpRequest.DONE) {
            if (httpRequest.status === 200) {
                renderList(httpRequest.responseText);
            } else {
                console.log("Error: " + httpRequest.status);
            }
        }
    };

    var makeRequest = function makeRequest(urn) {
        httpRequest = new XMLHttpRequest();  // assign a new request object

        if (!httpRequest) {
            console.log("Error creating XMLHttpRequest object.");
            return false;
        }

        httpRequest.onreadystatechange = getData;
        httpRequest.open("GET", urn);
        httpRequest.send();
    };

    fetchButton.addEventListener("click", function () {

        makeRequest(questionUrn);
    });

    clearButton.addEventListener("click", function () {

        questionList.innerHTML = "";
    });

    var renderList = function renderList(data) {
        console.log("Success!\n" + data);
        var dataArr = JSON.parse(data);

        // dataArr.sort(function (a, b) {
        //    var categoryA = a.category.toUpperCase();
        //    var categoryB = b.category.toUpperCase();

        //    if (categoryA < categoryB) {
        //        return -1;
        //    }
        //    if (categoryA > categoryB) {
        //        return 1;
        //    }
        //    return 0;
        // });

        dataArr.forEach(function (item, idx, arr) {
            console.log(item.specificQuestion);
            console.log(item.specificAnswer);

            var newItem = document.createElement("li");
            var newAnchor = document.createElement("a");

            // //www.w3schools.com/jsref/met_document_createelement.asp
            var btn = document.createElement("BUTTON");        // Create a <button> element
            var t = document.createTextNode("Click");       // Create a text node

            newItem.classList.add("list-group-item");
            newItem.classList.add("bg-success");

            newAnchor.id = item.id;
            newAnchor.href = questionUrn + item.id;
            newAnchor.innerText = item.specificQuestion;

            newItem.appendChild(newAnchor);
            questionList.appendChild(newItem);

            // next 2 lines from w3schools ...
            btn.appendChild(t);                                // Append the text to <button>
            btn.classList.add("btn");
            btn.classList.add("btn-success");

            newItem.appendChild(btn);                    // Append <button> to <body> 
            // newButton.classList.add("bg-success");
            // newButton.add.innerHTML("Check Answer");

        });
    };
})();
