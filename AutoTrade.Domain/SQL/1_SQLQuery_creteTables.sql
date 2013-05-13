use AutoTrade;
go

create table Brands
(
Id int identity primary key not null,
Name nvarchar(50) not null
);
go

create table AutoModels
(
Id int identity primary key not null,
IdBrand int default NULL
constraint fk_IdBrand foreign key
references Brands(Id)
on delete cascade
on update cascade,
Name nvarchar(50) not null,
);
go

create table Vehicles
(
Id int identity primary key not null,
IdAutoModel int default null
constraint fk_IdAutoModel foreign key
references AutoModels(Id)
on delete cascade
on update cascade,
Color nvarchar(50) default null,
CubicCapacity decimal(10,2) not null,
Price decimal(10,2) not null,
[Description] nvarchar(250) default null
);
go

create table PricesHistory
(
Id int identity primary key not null,
IdVehicle int constraint fk_IdVehicle foreign key
references Vehicles(Id)
on delete cascade
on update cascade,
ChangeDate date not null default getdate(),
Price decimal(10,2) not null
);
go

create trigger ChangePriceEvent 
on Vehicles
for insert, update
not for replication
as
set nocount on;
begin
	if not exists
		(
		select *
		from dbo.PricesHistory as PH, inserted as i
		where PH.IdVehicle=i.Id and
			PH.ChangeDate=getdate() and
			PH.Price=i.Price
		)
	insert into PricesHistory(IdVehicle,Price)
	select Id, Price
	from inserted 
end;
go