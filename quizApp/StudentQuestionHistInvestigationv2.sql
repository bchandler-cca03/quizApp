INSERT INTO StudentQuestionHist (EventDate, Result, StudentId, QuestionId)
VALUES ('20170310', 3, 2, 3)

Select *
from Questions

Select *
from Students

Select *
from StudentQuestionHist
Where Result = 0

Select *
from StudentQuestionHist
Where QuestionId = 3003


Select QuestionId=3003, max(EventDate)
from StudentQuestionHist
group by QuestionId

Select Top 1 QuestionId, Result, EventDate
from StudentQuestionHist
order by QuestionId

SELECT Id, Result, EventDate, StudentId, QuestionId
FROM StudentQuestionHist
WHERE EventDate DateTime
(
    SELECT Max(EventDate) AS EventDate
    FROM StudentQuestionHist
    GROUP BY EventDate
)


// from https://stackoverflow.com/questions/17038193/select-row-with-most-recent-date-per-user
Select *
from StudentQuestionHist
where StudentId = 1
SELECT t1.*
FROM StudentQuestionHist t1
WHERE t1.EventDate = (SELECT MAX(t2.EventDate)
FROM StudentQuestionHist t2
WHERE t2.QuestionId = t1.QuestionId)

// seems to pull all recordsd of StudentId = 1 and QuestionId = 11007
Select *
from StudentQuestionHist
Where StudentId IN (
Select StudentId
Where QuestionId = 1)

// selects all of the 11007 Question Events
Select *
from StudentQuestionHist
Where QuestionId IN (11007)

// selects all of the events where the StudentId = 1
Select *
from StudentQuestionHist
Where StudentId IN (1)


Select StudentId
Where QuestionId = 1)




Select *
from AspNetUsers








UPDATE Students
Set AspNetUserId = '9f4663c4-7101-4d9c-b71b-42068a94fd6c'
Where Id=1