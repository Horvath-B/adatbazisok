CREATE TABLE Vevo
(
    VevoID int PRIMARY KEY,
    Nev varchar(20) NOT NULL,
    Telefonszam varchar(20) NOT NULL,
    Cim varchar(50) NOT NULL,
    Maganszemely bit
)

CREATE TABLE Uzletkoto
(
    UzletkotoID int PRIMARY KEY,
    Nev VARCHAR(20) NOT NULL,
    Fizetes INT NOT NULL,
    CONSTRAINT chkFizetes
    CHECK(Fizetes > 0)
)

CREATE TABLE Meghajtas
(
    MeghajtasID int PRIMARY KEY,
    Uzemanyag varchar(10) NOT NULL,
    Fajta varchar(10) NOT NULL,
    Tipus varchar(15),
    Hengerurtartalom int,
    Loero int NOT NULL,
    CONSTRAINT chkLoero
    CHECK(Loero > 0),
    CONSTRAINT chkHengerurtartalom
    CHECK(Hengerurtartalom > 0), 
  	CONSTRAINT chkUzemanyag
  	CHECK(Uzemanyag IN ('benzin', 'dizel', 'elektromos'))
)

CREATE TABLE Modell
(
  ModellID int PRIMARY KEY,
  Felszereltseg varchar(15),
  Tipus varchar(10) NOT NULL,
  Marka varchar(10) NOT NULL,
 )

CREATE TABLE Autok
(
    AutoID int PRIMARY KEY, 
    Modell int NOT NULL,    
    Meghajtas int NOT NULL,
    Szin varchar(10),
    Ar int NOT NULL,

    CONSTRAINT chkAr
    CHECK(Ar > 0),

    CONSTRAINT fkMeghajtas
    FOREIGN KEY (Meghajtas)
    REFERENCES Meghajtas (MeghajtasID),
  
  	CONSTRAINT fkModell
  	FOREIGN KEY (Modell)
  	REFERENCES Modell (ModellID)
)

CREATE TABLE Vetel
(
    VetelID int PRIMARY KEY,
    Vevo int,
    Uzletkoto int,
    Kocsi int,
    Datum date NOT NULL,
    FizetesiMod varchar(8) NOT NULL,

    CONSTRAINT fkVevo
    FOREIGN KEY (Vevo)
    REFERENCES Vevo (VevoID),

    CONSTRAINT fkUzletkoto
    FOREIGN KEY (Uzletkoto)
    REFERENCES Uzletkoto (UzletkotoID),

    CONSTRAINT fkKocsi
    FOREIGN KEY (Kocsi)
    REFERENCES Autok (AutoID),
  
 	CONSTRAINT chkFizetesiMod
  	CHECK (FizetesiMod IN ('reszlet', 'atutalas', 'keszpenz'))
)