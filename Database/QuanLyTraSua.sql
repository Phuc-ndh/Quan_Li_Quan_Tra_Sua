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

create table Order
(
	idOrder int identity not null, constraint PK_idOrder primary key (idOrder),
	Date smalldatetime,
	TotalPrice int,
	idTable int
)
alter table Order add
constraint FK_Order_idTable foreign key (idTable) references _Table(idTable)


create table OrderDetail
(
	idOrder int not null,
	idDrink int not null,
	Quantity int,
	constraint PK_OrderDetail primary key (idOrder, idDrink)	
)
alter table OrderDetail add
constraint FK_OrderDetail_idOrder foreign key (idOrder) references Order(idOrder),
constraint FK_OrderDetail_idDrink foreign key (idDrink) references Drink(idDrink)
