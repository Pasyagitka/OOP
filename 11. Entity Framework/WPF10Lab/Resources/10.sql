use master
go

create database OOP10
go

use OOP10
go

create table clientsaddress(
	adressid int identity primary key,
	country nvarchar(30),
	city nvarchar(20),
	street nvarchar(30),
	house int,
	postalcode int
)
GO

create table client(
	clientID int identity primary key,
	firstname nvarchar(20),
	patronymic nvarchar(20),
	surname nvarchar(20),
	email nvarchar(20),
	adressid int foreign key references clientsaddress(adressid),
	photo varbinary(MAX),
	contactnumber decimal 
)
GO

insert into clientsaddress(country, city, street, house, postalcode) 
values ('Belarus', 'Minsk', 'Sverdlova', 13, 220099),
('Belarus', 'Minsk', 'Lenina', 28, 220011),
('Belarus', 'Minsk', 'Serova', 54, 220025)
GO

insert into client(firstname, patronymic, surname, email, adressid,  contactnumber) 
			values ('Andrey', 'Andreevich', 'Andreev', 'aaa@mail.ru', 1,  375335769283),
				('Ivan', 'Ivanovich', 'Ivanov', 'iii@mail.ru', 2,  375294057683),
				('Alexey', 'Alexeevich', 'Alexeev', 'aaa@gmail.com', 1,  375448293450)
			GO

Create procedure spAddAddress          
(          
    @country nvarchar(30),           
    @city nvarchar(20),          
    @street nvarchar(30),          
    @house int,  
    @postalcode int,   
	@adressid int OUT
)          
as           
Begin           
    Insert into clientsaddress(country, city, street, house, postalcode)           
    Values (@country,@city,@street, @house, @postalcode)  
	SET @adressid = SCOPE_IDENTITY()
End  
go

Create procedure spAddClient          
(          
	@firstname nvarchar(20),
	@patronymic nvarchar(20),
	@surname nvarchar(20),
	@email nvarchar(20),
	@adressid int,
	@photo varbinary(MAX),
	@contactnumber decimal,
	@clientID int OUT
)          
as           
Begin           
    Insert into client(firstname, patronymic, surname, email, adressid, photo, contactnumber)           
    Values (@firstname, @patronymic, @surname, @email, @adressid, @photo, @contactnumber)
	SET @clientID = SCOPE_IDENTITY()
End 
go

Create procedure spGetAllClientsInfo        
as        
Begin        
    select *        
    from client  left outer join clientsaddress on client.adressid = clientsaddress.adressid
    order by clientID   
End  
go

Create procedure spGetAllClients       
as        
Begin        
    select *        
    from client  
End  
go

Create procedure spGetAllAddresses       
as        
Begin        
    select *        
    from clientsaddress
End  
go

Create procedure spUpdateClient            
(      
	@clientid int,
    @firstname nvarchar(20),
	@patronymic nvarchar(20),
	@surname nvarchar(20),
	@email nvarchar(20),
	@adressid int,
	@photo varbinary(MAX),
	@contactnumber decimal                  
)            
as            
begin            
   Update client             
   set 
   firstname=@firstname,            
   patronymic=@patronymic,            
   surname=@surname,          
   email=@email,   
   adressid=@adressid,           
   contactnumber = @contactnumber
   where @clientID = clientID
End  
go 

Create procedure spUpdateAddress          
(        
	@adressid int,
    @country nvarchar(30),           
    @city nvarchar(20),          
    @street nvarchar(30),          
    @house int,  
    @postalcode int          
)          
as           
Begin           
   Update clientsaddress             
   set 
    country = @country,           
    city = @city,          
    street = @street,          
    house = @house,  
    postalcode = @postalcode    
   where  @adressid = adressid 
End  
go

Create procedure spDeleteAddress         
(            
   @adressid int            
)            
as             
begin            
   Delete from clientsaddress where @adressid=adressid          
End  
go 

Create procedure spDeleteClient
(            
   @clientID int            
)            
as             
begin            
   Delete from client where @clientID=clientID          
End  
go

UPDATE client 
SET photo = (SELECT * FROM OPENROWSET(BULK N'D:\4 семестр\ООП\06-09. Программное средство продажи товаров или услуг на WPF\Shop\ProductImages\всахаре.png', SINGLE_BLOB) AS image)
WHERE clientID = 2

UPDATE client 
SET photo = (SELECT * FROM OPENROWSET(BULK N'"D:\4 семестр\ООП\06-09. Программное средство продажи товаров или услуг на WPF\Shop\ProductImages\дольки.png"', SINGLE_BLOB) AS image)
WHERE clientID in (1, 3)
go

