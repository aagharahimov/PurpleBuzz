INSERT INTO TeamMembers(Name, Surname, Photopath, Position, CreatedAt)
Values
('John', 'Doe', '/assets/img/team-01.jpg', 'Business Dev', GETDATE()),
('Jane', 'Doe', '/assets/img/team-02.jpg', 'Media Dev', GETDATE()),
('Rasim', null, '/assets/img/team-03.jpg', 'Dev', GETDATE())

SELECT * FROM TeamMembers
UPDATE TeamMembers
SET Surname = 'Mahmudov'
WHERE Id = 3