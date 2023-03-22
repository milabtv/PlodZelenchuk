CREATE TABLE [dbo].Villans
(
	[Id] INT NOT NULL PRIMARY KEY,
	V_name NVARCHAR(50),
	EvilFacId int,
	FOREIGN KEY (EvilFacId) REFERENCES EvilFactor(Id)
)

CREATE TABLE [dbo].VillansMinions
(
	Villan int,
	Minion int,
	FOREIGN KEY (Minion) REFERENCES Minions(Id),
	FOREIGN KEY (Villan) REFERENCES Villans(Id)
)
