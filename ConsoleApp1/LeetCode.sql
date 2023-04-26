﻿/*595. Big Countries*/
select name, population, area from World where area >= 3000000 or population >= 25000000

/*1757. Recyclable and Low Fat Products*/
select product_id from Products where low_fats = 'Y' and recyclable = 'Y'

/*584. Find Customer Referee*/
select name from Customer where referee_id <> 2 or referee_id is null

/*183. Customers Who Never Order*/
select c.name as Customers from Customers c left join Orders o on c.id = o.customerId where o.customerId is null