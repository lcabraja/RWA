﻿USE AdventureWorksOBP
GO
CREATE PROCEDURE DohvatiKupce
AS
BEGIN
    SELECT TOP 100 * FROM KUPAC
END
GO
CREATE PROCEDURE DohvatiJednogKupca
    @IDKupac int
AS
BEGIN
    SELECT * FROM KUPAC WHERE IDKupac = @IDKupac
END
GO
CREATE PROCEDURE DohvatiRacuneKupca
    @KupacID int
AS
BEGIN
    SELECT * FROM RACUN WHERE KupacID = @KupacID
END
GO
