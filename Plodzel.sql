CREATE TABLE vid(
id int not null primary key,
vid_name varchar(50)
)
CREATE TABLE producti(
id int not null primary key,
prod_name varchar(50),
quantity int,
vid int,
FOREIGN KEY(vid) REFERENCES vid(id), 
proizhod varchar(50)
)
INSERT INTO vid(id,vid_name) 
VALUES
(1,'plod'),(2,'zelenchuk');
INSERT INTO producti(id,prod_name,quantity,vid,proizhod)
VALUES (1,'krastavica',30,2,'bg'),
(2,'chushka',40,2,'bg'),(3,'praskova',60,1,'bg'),
(4,'qbalka',20,1,'bg'),(6,'krusha',50,1,'bg');
