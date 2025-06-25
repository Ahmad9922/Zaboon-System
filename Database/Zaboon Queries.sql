ALTER PROCEDURE SP_AddClient
@BirthDate datetime,
@AccountID INT,
@ClientID INT OUTPUT

AS
BEGIN

BEGIN TRY

     BEGIN TRANSACTION

	 INSERT INTO [dbo].[People] ( 
     [FirstName], [LastName], [BirthDate])
     VALUES ( @FirstName, @LastName, @BirthDate)
     DECLARE @PersonID INT = SCOPE_IDENTITY();

	 INSERT INTO [dbo].[Clients] ( 
     [PersonID], [AccountID])
     VALUES ( @PersonID, @AccountID)

     SET @ClientID = SCOPE_IDENTITY();

     COMMIT;

END TRY

BEGIN CATCH

ROLLBACK;
PRINT ERROR_MESSAGE();

END CATCH

END

