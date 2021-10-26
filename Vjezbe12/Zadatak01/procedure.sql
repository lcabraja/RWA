USE AdventureWorksOBP
GO
CREATE PROC DohvatiKupce
AS
BEGIN
	SELECT * FROM Kupac JOIN Grad ON Kupac.GradID = Grad.IDGrad
END
GO
CREATE PROC DohvatiKupca
	@IDKupac int
AS
BEGIN
	SELECT * FROM Kupac JOIN Grad ON Kupac.GradID = Grad.IDGrad WHERE IDKupac = @IDKupac
END
GO
CREATE PROCEDURE DohvatiGradove
AS
BEGIN
	SELECT IDGrad, Naziv, DrzavaID FROM Grad
END
GO
CREATE PROC DohvatiBrojKupaca
AS
BEGIN
	SELECT COUNT(*) FROM Kupac
END
GO
CREATE PROC InsertKupac
	@Ime nvarchar(50),
	@Prezime nvarchar(50),
	@Email nvarchar(50),
	@Telefon nvarchar(25),
	@GradID int
AS
BEGIN
	INSERT INTO KUPAC
		VALUES(@Ime, @Prezime, @Email, @Telefon, @GradID)
END