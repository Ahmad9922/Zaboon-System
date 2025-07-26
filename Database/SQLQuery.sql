
SELECT * FROM Users

SELECT * FROM UsersTypes

SELECT * FROM Services

SELECT * FROM Reservations

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


UPDATE ServicesTypes
SET Description = null
WHERE ServiceTypeID < 3

TRuncate TABLE Reservations 

SELECT ServiceHours.*
FROM ServiceHours INNER JOIN
Services ON ServiceHours.ServiceID = Services.ServiceID
WHERE Services.Name = 'Issuance of a checkbook'

SELECT * FROM ServiceHours WHERE ServiceID = 2014

SELECT DATEPART(WEEKDAY, GETDATE()) 

SELECT * FROm ServiceHours
WHERE CAST(GETDATE() AS TIME) Between WorkStartTime AND WorkEndTime
AND DayOfWeek = DATEPART(WEEKDAY, GETDATE()) - 1 AND ServiceID = 3