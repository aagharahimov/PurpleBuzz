INSERT INTO Services (Title, Description, ImagePath, IconClass)
VALUES
('UI/UX Design', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-01.jpg', 'bx bx-paint'),
('Social Media', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-02.jpg', 'bx bx-share-alt'),
('Marketing', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-03.jpg', 'bx bx-megaphone'),
('Graphic', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-04.jpg', 'bx bx-image'),
('Digital Marketing', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-05.jpg', 'bx bx-chart'),
('Market Research', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-06.jpg', 'bx bx-search'),
('Business', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-07.jpg', 'bx bx-building'),
('Branding', 'Lorem ipsum dolor sit amet, consectetur adipisicing', './assets/img/services-08.jpg', 'bx bx-pen');


UPDATE Services
SET Title = 'Businesss'
WHERE Id = 7
