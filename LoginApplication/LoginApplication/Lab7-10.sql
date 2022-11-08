-- Lab 7 - 10 Exercises
-- Database Script
-- Subject: Software Engineering
-- Student: Ho Gia Khiem (520K0341)
create database Lab7to10
use Lab7to10

-- Requirement: 5 - 7 rows of data for each table
-- Item(Item ID (primary key), ItemName, Size, ...)
create table Items (
    ItemID char(10) primary key,
    ItemName char(50),
    Size char(10)
)

insert into Items values ('A2445', 'Item 1', '5')
insert into Items values ('B2328', 'Item 2', '10')
insert into Items values ('C2482', 'Item 3', '15')
insert into Items values ('D4922', 'Item 4', '20')
insert into Items values ('E5552', 'Item 5', '25')

-- Agent(AgentID (primary key), AgentName, Address)
create table Agents (
    AgentID char(10) primary key,
    AgentName char(50),
    Add_ress char(50)
)

insert into Agents values('1234', 'Agent 1', 'Location 1')
insert into Agents values('4242', 'Agent 2', 'Location 2')
insert into Agents values('4921', 'Agent 3', 'Location 3')
insert into Agents values('3828', 'Agent 4', 'Location 4')
insert into Agents values('2428', 'Agent 5', 'Location 5')

-- Order(OrderID (primary key), OrderDate, AgentID)
create table Orders (
    OrderID char(10) primary key,
    OrderDate char(15),
    AgentID char(10)
    foreign key (AgentID) references Agents(AgentID)
)

insert into Orders values('56594', '20/10/2014', '1234')
insert into Orders values('24248', '11/05/2014', '4242')
insert into Orders values('89248', '13/06/2014', '4921')
insert into Orders values('18342', '25/11/2014', '3828')
insert into Orders values('95000', '07/08/2014', '2428')

-- OrderDetails(ID (primary key), OrderID, ItemID, Quantity, UnitAmount)
create table OrderDetails (
    ID char(10) primary key,
    OrderID char(10),
    ItemID char(10),
    Quantity int,
    UnitAmount int
    foreign key (OrderID) references Orders(OrderID),
    foreign key (ItemID) references Items(ItemID)
)

insert into OrderDetails values ('', '56594', 'A2445', 0, 0)
insert into OrderDetails values ('', '24248', 'B2328', 0, 0)
insert into OrderDetails values ('', '89248', 'C2482', 0, 0)
insert into OrderDetails values ('', '18342', 'D4922', 0, 0)
insert into OrderDetails values ('', '95000', 'E5552', 0, 0)