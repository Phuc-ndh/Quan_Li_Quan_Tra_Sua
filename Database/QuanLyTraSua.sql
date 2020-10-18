create database QuanLyTraSua
go
use QuanLyTraSua


create table DrinkCategory
(
	idCategory int identity not null, constraint PK_idCategory primary key (idCategory),
	Name varchar(40)
)

create table Drink
(
	idDrink int identity not null, constraint PK_idDrink primary key (idDrink),
	Name varchar(40),
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
	idBill int identity not null, constraint PK_idBill primary key (idBill),
	Date smalldatetime,
	TotalPrice int,
	idTable int
)
alter table Bill add
constraint FK_Bill_idTable foreign key (idTable) references _Table(idTable)


create table BillInfo
(
	idBill int not null,
	idDrink int not null,
	Quantity int,
	constraint PK_BillInfo primary key (idBill, idDrink)	
)
alter table BillInfo add
constraint FK_BillInfo_idBill foreign key (idBill) references Bill(idBill),
constraint FK_BillInfo_idDrink foreign key (idDrink) references Drink(idDrink)
