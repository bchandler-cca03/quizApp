// JavaScript source code
"use strict";

(function () {
    // Variables
    var fetchButton = document.getElementById("fetch-button"),
        clearButton = document.getElementById("clear-button"),
        showAnswerButton = document.getElementById("showAnswer"),
        buttonStripe = document.getElementById("buttonStripe"),
        answerArea = document.getElementById("answerArea"),
        missedButton = document.getElementById("missed"),
        partialButton = document.getElementById("partial"),
        fullyButton = document.getElementById("fully"),
        questionList = document.getElementById("question-list"),
        questionUrn = "/api/QuesGame/",
        questionArray = [],
        nextIdx,
        httpRequest;
    var questionObject;

    var newButton = document.createElement("button");

    // initialize the game
    init();
    function init() {
        // pull from database

        // establish event listeners

        // call nextQuestion function
        nextQuestion();
    }
    function nextQuestion() {

    }
    function turnAnswerBlockOn() {
        // when 'Show Answer' button is clicked, this
        // function is called to turn on the answer and grading bar

    }
    function postQuestionResultToServer() {
        // when the quesiton is graded, post the result,
        // and call nextQuestion which will re-initiate.

    }
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
    var renderList = function renderList(data) {
        console.log("Success!\n" + data);
        questionArray = JSON.parse(data);
        // var dataArr = JSON.parse(data);
        // questionArray = dataArr;
        // return questionArray;
    };

    var makeRequest = function makeRequest(urn, array) {
        httpRequest = new XMLHttpRequest();  // assign a new request object

        if (!httpRequest) {
            console.log("Error creating XMLHttpRequest object.");
            return false;
        }

        httpRequest.onreadystatechange = getData();
        httpRequest.open("GET", urn);
        httpRequest.send();
    };
    // these are the events that trigger the javascript code above
    fetchButton.addEventListener("click", function () {
        makeRequest(questionUrn);
    });

    clearButton.addEventListener("click", function () {
        questionList.innerHTML = "";
    });

    showAnswerButton.addEventListener("click", function () {

        answerArea.classList.remove("displayOff");
        answerArea.classList.add("displayOn");
        stripe.classlist.remove("displayOff");
        stripe.classlist.add("displayOn");

    });
    missedButton.addEventListener("click", function () {
        alert("you missed the answer!");
    });
    partialButton.addEventListener("click", function () {
        alert("partial credit!");
    });
    fullyButton.addEventListener("click", function () {
        alert("you got it right!");
    });
    


    // reserve code to build UI dynamically 
    // dataArr.forEach(function (item, idx, arr) {
    // console.log(item.specificQuestion);
    // console.log(item.specificAnswer);

    // var newItem = document.createElement("li");
    // var newAnchor = document.createElement("a");
    // var newAnswerTextArea = document.createElement("TEXTAREA");
    // var newDiv = document.createElement("DIV");

    // //www.w3schools.com/jsref/met_document_createelement.asp
    // var btn = document.createElement("BUTTON");        // Create a <button> element
    // var t = document.createTextNode("Click");          // Create a text node

    // construct the question
    // newItem.classList.add("list-group-item");
    // newItem.classList.add("bg-success");

    // newAnchor.id = item.id;
    // newAnchor.href = questionUrn + item.id;
    // newAnchor.innerText = item.specificQuestion;

    // append the question
    // newItem.appendChild(newAnchor);
    // questionList.appendChild(newItem);

    // add text box for answer
    // newAnswerTextArea.rows(8);
    // newAnswerTextArea.setAttribute('rows', 8);
    // newAnswerTextArea.classList.add("gameAnswerBox");
    // questionList.appendChild(newAnswerTextArea);

    // insert row
    // newDiv.classList.add("row");
    // questionList.appendChild(newDiv);

    // next 2 lines from w3schools ...
    // btn.appendChild(t);                                // Append the text to <button>
    // btn.classList.add("btn");
    // btn.classList.add("btn-success");

    // append the button to something else.
    // newItem.appendChild(btn);                    // Append <button> to <body> 
            // newButton.classList.add("bg-success");
            // newButton.add.innerHTML("Check Answer");

    // });

})();
