CREATE TABLE vid
(
	id int PRIMARY KEY,
	vid_name NVARCHAR(50),
)
CREATE TABLE Producti
(
	id int,
	prod_name NVARCHAR(50),
	quantity int,
	vid_id int,
	proizhod NVARCHAR(50),
	FOREIGN KEY(vid_id) REFERENCES vid(id)
)
INSERT INTO vid(id,vid_name)
VALUES(1,'plod'),(2,'zelenchuk')
INSERT INTO Producti(id,prod_name,quantity,vid_id,proizhod)
VALUES (1,'zele',20,2,'turkey'),
(1,'zele',20,2,'turkey'),
(2,'qbalka',10,1,'bulgaria'),
(3,'krastavica',50,2,'turkey'),
(4,'krusha',20,1,'turkey'),
(5,'brokoli',130,1,'bulgaria'),
(6,'celina',20,1,'bulgaria'),
(7,'domat',30,1,'bulgaria'),
(8,'kartof',40,1,'bulgaria'),
(9,'praskova',20,2,'turkey'),
(10,'luk',70,1,'turkey'),
(11,'kaisiq',80,2,'turkey'),
(12,'tikvichka',30,1,'bulgaria'),
(13,'karnabit',20,1,'turkey'),
(14,'qgodi',20,2,'bulgaria'),
(15,'malini',50,2,'turkey'),
(15,'duli',40,2,'bulgaria'),
(16,'avokado',90,2,'turkey'),
(17,'salata',170,1,'bulgaria'),
(18,'aisberg',120,1,'turkey'),
(19,'luti chushki',20,1,'bulgaria'),
(20,'piper',100,1,'turkey');
