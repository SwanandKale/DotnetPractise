create database Ecommerce;
use Ecommerce;

create table Product(
    pid int primary key ,
    pname varchar(20) not null,
    pdesc varchar(20) not null,
    unitprice double(9,2)
);

insert into Product values(10,"Biscuits","Snacks",50),
(11,"Farsana","Snacks",100),
(12,"Fruity","Juice",35),
(13,"Soap","Hygine",50);
