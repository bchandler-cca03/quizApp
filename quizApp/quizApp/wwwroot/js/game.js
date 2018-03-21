// JavaScript source code
"use strict";

(function () {
    // Variables
    var fetchButton = document.getElementById("fetch-button"),
        clearButton = document.getElementById("clear-button"),
        startQuizButton = document.getElementById("start-quiz"),
        toggleAnswerButton = document.getElementById("toggleAnswer"),
        showQuestionButton = document.getElementById("showQuestion"),
        buttonStripe = document.getElementById("buttonStripe"),
        answerArea = document.getElementById("answerArea"),
        missedButton = document.getElementById("missed"),
        partialButton = document.getElementById("partial"),
        fullyButton = document.getElementById("fully"),
        modalDiv = document.getElementById("modalDiv"),
        nextQuestionButton = document.getElementById("next"),
        questionList = document.getElementById("question-list"),
        insertQuestionHere = document.getElementById("questionGoesHere"),
        enterAnswerHere = document.getElementById("enterAnswerHere"),
        specificAnswerHere = document.getElementById("specificAnswerHere"),
        questionUrn = "/api/QuesGame/",
        questionResultUrn = "/api/StudentQuesHist",
        Id = document.getElementById("Id"),
        questionArray = [],
        nextIdx = 1,
        httpRequest;

    var questionObject;

    var newButton = document.createElement("button");

    // initialize the game
    init();
    function init() {
        // pull from database

        // establish event listeners

        // next question

    }
    function nextQuestion() {
        if (nextIdx > questionArray.length - 1) {
            // ZZZ Add something that change #modalDiv to visible in CSS
            // which should trigger the action to post the modal
            console.log("pause");
            // $('#modalDiv').modal({ keyboard: "true" });
            $('#modalDiv').modal('show');
        } else {
            insertQuestionHere.innerText = questionArray[nextIdx].specificQuestion;
            enterAnswerHere.value = "";
            nextIdx++;
        }
    }
    function turnAnswerBlockOn() {
        // when 'Show Answer' button is clicked, this
        // function is called to turn on the answer and grading bar

    }
    function hideAnswerArea() {
        if (answerArea.classList.contains("displayOn")) {
            answerArea.classList.remove("displayOn");
            answerArea.classList.add("displayOff");
            toggleAnswerButton.innerText = "ShowAnswer";
        } else {
            console.log("Error:  should not get here in toggleAnswerButton.addEventListener");
        }
    };
    function postQuestionResultToServer() {
        // when the question is graded, post the result,
        // and call nextQuestion which will re-initiate.
    }
    function postData(inputResult) {
        httpRequest = new XMLHttpRequest();

        if (!httpRequest) {
            console.log("Error posting XMLHttpRequestUpload object.");
            return false;
        }
        // var EventDate = DateTime.Now().ToString();
        // reference stack overflow "send-post-data-using XMLHttpRequest"
        var params = JSON.stringify(inputResult);

        httpRequest.open("POST", questionResultUrn, true);

        // Send the proper header information along with the request
        httpRequest.setRequestHeader("Content-type", "application/json");

        httpRequest.onreadystatechange = function () {  // Call a function when the state changes
            if (httpRequest.readyState === XMLHttpRequest.DONE && httpRequest.status === 200) {
                console.log("httpRequest is Done");
            }
        };
        // httpRequest.send(params);
        httpRequest.send(params);
        console.log("httpRequest Params sent");
    }
    var getData = function () {
        console.log("HTTPRequest State: " + httpRequest.readyState +
            " Status: " + httpRequest.status + " : " + httpRequest.responseText);

        if (httpRequest.readyState === XMLHttpRequest.DONE) {
            if (httpRequest.status === 200) {
                renderList(httpRequest.responseText);
                console.log("RenderList has been Called");
            } else {
                console.log("Error: " + httpRequest.status);
            }
        }
    };
    var renderList = function renderList(data) {
        console.log("Success!\n" + data);
        var dataArr = JSON.parse(data);
        questionArray = dataArr;  // this should assign to the global scoped variable
        console.log(questionArray);   // let's check and make sure we are getting the correct indexes
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
    // these are the events that trigger the javascript code above
    fetchButton.addEventListener("click", function () {
        makeRequest(questionUrn);
    });
    clearButton.addEventListener("click", function () {
        questionList.innerHTML = "";
        insertQuestionHere.innerText = "";
        answerArea.innerText = "";
        enterAnswerHere.innerText = "";
        nextIdx = 0;
    });
    startQuizButton.addEventListener("click", function () {
        nextQuestion();
    });

    showQuestionButton.addEventListener("click", function () {
        nextQuestion();
    });
    toggleAnswerButton.addEventListener("click", function () {
        if (answerArea.classList.contains("displayOn")) {
            answerArea.classList.remove("displayOn");
            answerArea.classList.add("displayOff");
            toggleAnswerButton.innerText = "ShowAnswer";
        } else if (answerArea.classList.contains("displayOff")) {
            answerArea.classList.remove("displayOff");
            answerArea.classList.add("displayOn");
            toggleAnswerButton.innerText = "HideAnswer";

            specificAnswerHere.value = questionArray[nextIdx - 1].specificAnswer;

        } else {
            console.log("Error:  should not get here in toggleAnswerButton.addEventListener");
        }
    });

    missedButton.addEventListener("click", function () {
        var q = questionArray[nextIdx - 1].id;
        console.log("Q is equal to: " + q);
        var myStudentQuesHistoryResult = {
            Result: 0,
            StudentId: Id.value,
            QuestionId: q
        };
        postData(myStudentQuesHistoryResult);
        hideAnswerArea();
        nextQuestion();
    });
    partialButton.addEventListener("click", function () {
        var q = questionArray[nextIdx - 1].id;
        console.log("Q is equal to: " + q);
        var myStudentQuesHistoryResult = {
            Result: 1,
            StudentId: Id.value,
            QuestionId: q
        };
        postData(myStudentQuesHistoryResult);
        hideAnswerArea();
        nextQuestion();
    });
    fullyButton.addEventListener("click", function () {
        var q = questionArray[nextIdx - 1].id;
        var myStudentQuesHistoryResult = {
            Result: 2,
            StudentId: Id.value,
            QuestionId: q
        };
        postData(myStudentQuesHistoryResult);
        hideAnswerArea();
        nextQuestion();
    });
    nextQuestionButton.addEventListener("click", function () {
        hideAnswerArea();
        nextQuestion();
        // console.log(questionArray[0]);
    });

    // $('#modalDiv').on('shown.bs.modal', function () {
    //     $('modalDiv').focus();
    //  });

})();
