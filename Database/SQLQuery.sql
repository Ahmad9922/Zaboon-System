
SELECT * FROM Users

SELECT * FROM UsersTypes

SELECT * FROM Services

SELECT * FROM Reservations
ORDER BY CreateDate

SELECT * FROM ServiceHours

--TRUNCATE TABLE ServiceHours;

SELECT * FROM Feedbacks

SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE

Alter VIEW ReservationsDetails AS
SELECT
    Reservations.ReservationID As [Reservation ID],
    Users.UserName AS [User Name],
    Services.Name AS [Service Name],
    Reservations.ReservationDate AS [Reservation Date],
    CASE
        WHEN Reservations.ReservationStatus = 1 THEN 'New'
        WHEN Reservations.ReservationStatus = 2 THEN 'Cancelled'
        WHEN Reservations.ReservationStatus = 3 THEN 'Completed'
        ELSE 'Unknown'
    END AS [Reservation Status]
FROM Reservations
INNER JOIN Users ON Reservations.UserID = Users.UserID
INNER JOIN Services ON Reservations.ServiceID = Services.ServiceID;


UPDATE Reservations
SET CreateDate = GETDATE()

TRuncate TABLE Reservations 

SELECT ServiceHours.*
FROM ServiceHours INNER JOIN
Services ON ServiceHours.ServiceID = Services.ServiceID
WHERE Services.Name = 'Issuance of a checkbook'

SELECT * FROM ServiceHours WHERE ServiceID = 2014

SELECT DATEPART(WEEKDAY, GETDATE()) 

SELECT * FROM Reservations
WHERE ServiceHourID = (SELECT ServiceHourID FROm ServiceHours
WHERE CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 AND ServiceID = 1)
AND ReservationDate = CAST(GETDATE() AS DATE) And ReservationStatus = 1
ORDER BY CreateDate


SELECT * FROM ServiceHours
WHERE CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 AND ServiceID = 1

SELECT ServiceHourID FROM ServiceHours
WHERE CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
AND DayOfWeek = 0 AND ServiceID = 1

SELECT ServiceHourID FROM ServiceHours
WHERE ServiceHourID = 2 AND CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1

DECLARE @WORKSTARTTIME TIME = '8:0:0';
DECLARE @WORKSTARTTIME TIME = '8:0:0';

SELECT ServiceHourID FROM ServiceHours
WHERE @WORKSTARTTIME BETWEEN WorkStartTime And WorkEndTime 
|| 
AND DayOfWeek = 0 AND ServiceID = 1