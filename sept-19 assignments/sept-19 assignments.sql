create database Shoppinges
use Shoppinges
create table Customer1
(
custid int primary key,
custname varchar(20),
city varchar(20),
state varchar(20)
)

create table Products1
(
prodid int primary key,
prodname varchar(20),
unitprice int,
unitofMeasurement float,
QtyinStock int
)

create table sales_header1
(
invno int primary key,
invdate int,
invamt float,
disPercent int
)



create table sales_detail1
(
invno int,
custid int,
prodid int,
qtysold int
)


drop table Customer1
drop table Products1
drop table sales_detail1
drop table sales_header1

create table sales
(invoice int primary key)


alter table sales_detail1
add foreign key(invno) references sales(invoice)

alter table sales_detail1
add foreign key(custid) references sales(invoice)

alter table sales_detail1
add foreign key(prodid) references sales(invoice)

alter table sales_detail1
drop column qtysold

alter table sales_detail1
add Qty int
sp_rename 'sales_detail1.Quantity','Quantity', column;
