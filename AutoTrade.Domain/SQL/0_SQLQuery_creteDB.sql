use master;
go

if exists(select * from sys.databases where name='AutoTrade')
DROP DATABASE AutoTrade;
go

create database AutoTrade
on
(
name=AutoTrade_dat,
filename="d:\autotrade.mdf",
size=10,
maxsize=50,
filegrowth=5
)
log on
(
name=AutoTrade_log,
filename="d:\autotrade.ldf",
size=5MB,
maxsize=25MB,
filegrowth=5MB
);
go

use AutoTrade;
go

if exists (
select * 
from master.INFORMATION_SCHEMA.TABLES
where TABLE_NAME='PricesHistory'
)
drop table AutoTrade.dbo.PricesHistory;

if exists (
select * 
from master.INFORMATION_SCHEMA.TABLES
where TABLE_NAME='Vehicles'
)
drop table AutoTrade.dbo.Vehicles;

if exists (
select * 
from master.INFORMATION_SCHEMA.TABLES
where TABLE_NAME='AutoModels'
)
drop table AutoTrade.dbo.AutoModels;

if exists (
select * 
from master.INFORMATION_SCHEMA.TABLES
where TABLE_NAME='Brands'
)
drop table AutoTrade.dbo.Brands;



