USE AdventureWorksOBP
GO
CREATE PROC DohvatiKupce
AS
BEGIN
	SELECT TOP 10 * FROM Kupac JOIN Grad ON Kupac.GradID = Grad.IDGrad
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
	SELECT * FROM Grad
END
GO
CREATE PROC DohvatiBrojKupaca
AS
BEGIN
	SELECT COUNT(*) FROM Kupac
END
GO
exec DohvatiKupce