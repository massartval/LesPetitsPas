/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Person]([FirstName], [LastName], [Email], [Phone1], [Phone2]) 
VALUES
('Ali', 'Baba', 'alibaba@40voleurs.com', 0477889977, 0475667788),
('Bob', 'Marley', 'yaman@ganja4ever.com', 0470809070, 0475776688);

INSERT INTO [Parent]([Id], [Password], [IsActive]) 
VALUES (1, 'OpenSesame', 1);

INSERT INTO [Guide]([Id], [IsActive]) 
VALUES (2, 1);

INSERT INTO [Child]( [FirstName], [LastName], [BirthDate], [ParentId])
VALUES 
('Aladeen', 'Baba', GETDATE(), 1);

INSERT INTO [Bus]([DateTime]) 
VALUES
(GETDATE());

INSERT INTO [Address]([City], [Street], [Number], [PersonId]) 
VALUES 
('Charleroi', 'Boulevard Tirou', 17, 1),
('Charleroi', 'Boulevard Tirou', 15, 2);