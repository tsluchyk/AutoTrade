use AutoTrade;
go
--create table PricesHistory
--(
--Id int identity primary key not null,
--IdVehicle int constraint fk_IdVehicle foreign key
--references Vehicles(Id)
--on delete cascade
--on update cascade,
--ChangeDate date not null default getdate(),
--Price decimal(10,2) not null
--);
--go

--use AutoTrade;
--go
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