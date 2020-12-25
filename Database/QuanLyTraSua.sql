create database QuanLyTraSua
go
use QuanLyTraSua


create table DrinkCategory
(
	idCategory int identity not null, constraint PK_idCategory primary key (idCategory),
	Name nvarchar(40)
)
create table Drink
(
	idDrink int identity not null, constraint PK_idDrink primary key (idDrink),
	Name nvarchar(40),
	Price int,
	idCategory int
)
alter table Drink add
constraint FK_Drink_idCategory foreign key (idCategory) references DrinkCategory(idCategory)

create table _Table
(
	idTable int identity not null, constraint PK_idTable primary key (idTable),
	Name nvarchar(40),
	Status nvarchar(20) default 0 --0: trống , 1: đã có người
)

create table Account
(
	Username nvarchar(40) not null, constraint PK_Username primary key (Username),
	RealName nvarchar(100),
	Password nvarchar(40) default 0,
	Type int default 0, --1: admin
	PhoneNumber nvarchar(15),
	Email nvarchar(40)
)

create table Bill
(
	idBill int identity not null, constraint PK_idOrder primary key (idBill),
	Date smalldatetime,
	TotalPrice int,
	idTable int,
	valueDiscount int,
)

alter table Bill add
constraint FK_Bill_idTable foreign key (idTable) references _Table(idTable)


create table BillInfo
(
	idBill int not null,
	idDrink int not null,
	Quantity int not null,
	valueDiscount int,
	constraint PK_OrderDetail primary key (idBill, idDrink),	
)
alter table BillInfo add
constraint FK_BillInfo_idBill foreign key (idBill) references Bill(idBill),
constraint FK_BillInfo_idDrink foreign key (idDrink) references Drink(idDrink)

--Thêm dữ liệu:
select * from DrinkCategory
--DBCC CHECKIDENT ('DrinkCategory', RESEED, -1);
insert into DrinkCategory(Name)
values
(N'Trà Sữa'),
(N'Hồng Trà'),
(N'Sinh Tố'),
(N'Nước Ép')

select * from Drink order by idCategory
--DBCC CHECKIDENT ('Drink', RESEED, -1);
insert into Drink(Name, Price, idCategory)
values
(N'Sinh Tố Dâu Tây', 30000, 2),
(N'Sinh Tố Xoài', 30000, 2),
(N'Trà Sữa Truyền Thống', 40000, 0),
(N'Nước Ép Dưa Hấu', 35000, 3),
(N'Hồng Trà Đào', 35000, 1)

--SELECT DrinkCategory.Name as Loại, Drink.Name as Tên, Drink.Price as Giá, Drink.idCategory FROM Drink inner join DrinkCategory on Drink.idCategory = DrinkCategory.idCategory order by Drink.idCategory

--delete from Drink
--delete from DrinkCategory

select* from bill
select* from BillInfo
select* from Discount

drop table bill,BillInfo

create table Discount
(
	idDiscount nvarchar(10), constraint PK_idDiscount primary key (idDiscount),
	valueDiscount int,
	isUsed int default 0,


SELECT SUM(T1.Quantity) * 1000.00 / (select sum(A.Quantity) from BillInfo A 
                                                                    where A.idBill in (select B.idBill from Bill B where MONTH(B.Date) = 12 and YEAR(B.Date) = 2020) ) AS PERCENTAGE_DRINK, 
                                (SUM(T1.Quantity)* T2.Price - SUM(T1.Quantity) * T2.Price * T1.valueDiscount / 100) * 1000.00 / (select SUM(C.TotalPrice) from Bill C 
                                                                    where MONTH(C.Date) = 12 and YEAR(C.Date) = 2020) AS PERCENTAGE_MONEY, 
                                SUM(T1.Quantity)* T2.Price - SUM(T1.Quantity) * T2.Price * T1.valueDiscount / 100 AS MONEY, 
                                SUM(T1.Quantity) AS SO_LUONG,
                                T2.Name, T1.idDrink
                           FROM BillInfo T1                      
						   INNER JOIN Drink T2 
                                ON T1.idDrink = T2.idDrink
                            WHERE T1.idBill in (select T3.idBill from Bill T3 where MONTH(T3.Date) = 12 and YEAR(T3.Date) = 2020)
                           GROUP BY T1.idDrink, T2.Name, T2.Price, T1.valueDiscount



