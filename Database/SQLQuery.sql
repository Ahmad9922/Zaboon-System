
SELECT CAST(GETDATE() AS DATE);

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
WHERE ServiceHourID = (SELECT TOP 1 ServiceHourID FROm ServiceHours
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


SELECT ServiceHourID FROM ServiceHours
WHERE @WORKSTARTTIME BETWEEN WorkStartTime And WorkEndTime 
|| @WORKENDTIME
AND DayOfWeek = 0 AND ServiceID = 1


SELECT ServiceHourID FROM ServiceHours
WHERE DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 AND ServiceID = 2

SELECT Name AS Service, COUNT(Name) AS NumberOfReservations

FROM Services INNER JOIN Reservations 
ON Services.ServiceID = Reservations.ServiceID
WHERE Reservations.ReservationDate = GETDATE()
GROUP BY Name

SELECT COUNT(UserID) FROM Users

SELECT COUNT(UserID) FROM Users
WHERE IsActive = 1

SELECT COUNT(UserID) FROM Users
WHERE IsActive = 0

SELECT COUNT(UserID) FROM Users
WHERE UserTypeID = 1

SELECT COUNT(UserID) FROM Users
WHERE UserTypeID = 2

SELECT COUNT(UserID) FROM Reservations
WHERE ServiceID = 1 AND UserID = 1004

UPDATE Reservations
SET ReservationStatus = 2
WHERE ReservationDate < CAST(GETDATE() AS DATE) AND ReservationStatus != 3

DECLARE @WORKSTARTTIME TIME = '5:0:0';
DECLARE @WORKENDTIME TIME = '8:0:0';

 SELECT TOP 1 1
 FROM ServiceHours
 WHERE @WorkStartTime < WorkEndTime
   AND @WorkEndTime > WorkStartTime

SELECT * FROM ServiceHours