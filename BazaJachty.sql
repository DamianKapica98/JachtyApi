IF NOT EXISTS (
        SELECT *
        FROM sys.databases
        WHERE name = 'Jachty'
        )
BEGIN
    CREATE DATABASE [Jachty]
END
GO
USE Jachty

create table Jacht(
J_ID int primary key not null,
J_Nazwa nvarchar(max),
J_CenaNaDzien decimal(10,2)

)

create table Rezerwacja(
R_ID int primary key not null identity(1,1),
R_DataWypozyczenia datetime,
R_DataOddania datetime,
R_Email nvarchar(max),
R_J_ID int foreign key references Jacht(J_ID)

)


insert into Jacht(J_ID, J_NAZWA, J_CenaNaDzien)
values (1,'Santa Monica',655),
(2,'Yggdrasil',1495.5),
(3,'Snowy Focus', 3110),
(4,'Rio',420.25),
(5,'Proud Father', 899.99),
(6,'Est. GBRL',705.05),
(7,'Tomahawk', 2121.21),
(8,'Antman',1764.63)

			
insert into Rezerwacja(R_DataWypozyczenia,R_DataOddania,R_J_ID,R_Email)
values('2021-10-07 10:0:0.0','2021-10-10 08:0:0.0',1,'fallenemofoll@cupremplus.com'),
('2021-10-12 15:0:0.0','2021-10-15 15:0:0.0',5,'rialo@specialkien.xyz'),
('2021-10-13 07:30:0.0','2021-10-13 22:50:0.0',2,'miuniqueballard@didncego.ru'),
('2021-10-16 06:0:0.0','2021-10-20 08:30:0.0',4,'axetype@prct.site'),
('2021-11-03 14:0:0.0','2021-11-10 12:20:0.0',8,'cid542@pickuplanet.com'),
('2021-11-05 18:0:0.0','2021-11-08 16:0:0.0',5,'phaffinatcha@elrfwpel.com'),
('2021-11-15 12:30:0.0','2021-11-30 12:30:0.0',8,'sarapuga@gmailni.com'),
('2021-11-15 16:10:0.0','2021-11-17 16:10:0.0',3,'lesya494@eeetivsc.com'),
('2021-11-23 06:30:0.0','2021-11-24 15:50:0.0',6,'ofbgddgf@specialkien.xyz'),
('2021-11-27 13:0:0.0','2021-11-30 11:0:0.0',7,'jeanlucqaz@gemuk.buzz'),
('2021-12-01 10:0:0.0','2021-12-04 18:0:0.0',1,'v47310cm@postimel.com'),
('2021-12-06 12:25:0.0','2021-12-13 14:40:0.0',2,'oapc7wfnvw@whyred.me'),
('2021-12-07 10:0:0.0','2021-12-07 18:20:0.0',5,'asymmetries@nkgursr.com'),
('2021-12-12 08:0:0.0','2021-12-22 08:0:0.0',4,'fishobx@msotln.com'),
('2022-01-02 02:0:0.0','2022-01-15 14:0:0.0',7,'aabedi2416@thekangsua.com')

--select * from rezerwacja
--select * from klient
--select * from jacht