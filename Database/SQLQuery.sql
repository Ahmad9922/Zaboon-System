
SELECT * FROM Users

SELECT * FROM UsersTypes

SELECT * FROM Services

SELECT * FROM Reservations

SELECT * FROM Feedbacks


UPDATE ServicesTypes
SET Description = null
WHERE ServiceTypeID < 3