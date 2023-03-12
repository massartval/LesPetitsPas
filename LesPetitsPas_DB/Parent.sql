﻿CREATE TABLE Parent(
   Id INT NOT NULL,
   Password VARCHAR(50) NOT NULL,
   IsActive BIT NOT NULL,
   FOREIGN KEY(Id) REFERENCES Person(Id), 
   CONSTRAINT [PK_Parent] PRIMARY KEY ([Id])
);