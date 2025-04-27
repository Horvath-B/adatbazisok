--tábla létrehozása
CREATE TABLE MASZKOLT_UGYFEL
(
LOGIN varchar(32) PRIMARY KEY,
MASZKOLT_EMAIL varchar(64) MASKED WITH (Function = 'email()') NOT NULL,
MASZKOLT_NEV varchar(64) MASKED WITH (function = 'partial(1,"XXX",1)') NOT NULL,
MASZKOLT_SZULEV numeric(4) MASKED WITH (Function = 'random(1,10)'),
MASZKOLT_NEM varchar(1) MASKED WITH (function = 'default()'),
MASZKOLT_CIM varchar(128) MASKED WITH (function = 'default()')
)

--tábla feltöltése
INSERT INTO MASZKOLT_UGYFEL
(
  LOGIN, MASZKOLT_EMAIL, MASZKOLT_NEV, MASZKOLT_SZULEV, MASZKOLT_NEM, MASZKOLT_CIM
) 
SELECT LOGIN, EMAIL, NEV, SZULEV, NEM, CIM
FROM UGYFEL

--korlátozott jogosultságú felhasználó létrehozása
CREATE USER Vak WITHOUT Login;
GRANT SELECT ON MASZKOLT_UGYFEL TO Vak

--maszkolt tábla lekérdezése az új felhasználóval
EXECUTE AS User= 'Vak';
SELECT * FROM MASZKOLT_UGYFEL
REVERT