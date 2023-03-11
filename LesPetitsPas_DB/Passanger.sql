CREATE TABLE Passenger(
   BusId INT NOT NULL,
   ChildId INT NOT NULL,
   AddressId INT NOT NULL,
   IsPresent VARCHAR(50),
   IsArrived VARCHAR(50),
   PRIMARY KEY(BusId, ChildId, AddressId),
   FOREIGN KEY(BusId) REFERENCES Bus(Id),
   FOREIGN KEY(ChildId) REFERENCES Child(Id),
   FOREIGN KEY(AddressId) REFERENCES [Address](Id),
);