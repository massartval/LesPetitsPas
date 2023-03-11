CREATE TABLE Trusted(
   ParentId INT NOT NULL,
   PersonId INT NOT NULL,
   Description VARCHAR(50) NOT NULL,
   PRIMARY KEY(ParentId, PersonId),
   FOREIGN KEY(ParentId) REFERENCES Parent(Id),
   FOREIGN KEY(PersonId) REFERENCES Person(Id)
);