﻿--create database QuanLyTraSua
go
use QuanLyTraSua


create table DrinkCategory
(
	id int identity not null, constraint PK_idDrinkCategory primary key (id),
	Name varchar(40)
)

create table Drink
(
	id int identity not null, constraint PK_idDrink primary key (id),
	Name varchar(40),
	Price int,
	idCategory int
)
alter table Drink add
constraint FK_Drink_idCategory foreign key (idCategory) references DrinkCategory(id)

create table _Table
(
	id int identity not null, constraint PK_idTable primary key (id),
	Name nvarchar(40),
	Status nvarchar(20) default 0 -- 0: trống , 1: đã có người
)

create table Account
(
	Username nvarchar(40) not null, constraint PK_Username primary key (Username),
	RealName nvarchar(40),
	Password nvarchar(40) default 1,
	Type int default 0, -- 1 = admin
	Email nvarchar(40),
	PhoneNumber nvarchar(40)
)

create table Bill
(
	id int identity not null, constraint PK_idBill primary key (id),
	Date smalldatetime,
	TotalPrice int,
	idTable int
)
alter table Bill add
constraint FK_Bill_idTable foreign key (idTable) references _Table(id)


create table BillInfo
(
	idBill int not null,
	idDrink int,
	Amount int,
	constraint PK_BillInfo primary key (idBill, idDrink)	
)
alter table BillInfo add
constraint FK_BillInfo_idBill foreign key (idBill) references Bill(id),
constraint FK_BillInfo_idDrink foreign key (idDrink) references Drink(id)