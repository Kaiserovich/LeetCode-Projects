/*595. Big Countries*/
select name, population, area from World where area >= 3000000 or population >= 25000000

/*1757. Recyclable and Low Fat Products*/
select product_id from Products where low_fats = 'Y' and recyclable = 'Y'

/*584. Find Customer Referee*/
select name from Customer where referee_id <> 2 or referee_id is null

/*183. Customers Who Never Order*/
select c.name as Customers from Customers c left join Orders o on c.id = o.customerId where o.customerId is null

/*1873. Calculate Special Bonus*/
select employee_id,
    case when name like 'M%' or employee_id %2 = 0 then 0 else salary
    end as bonus
from Employees
order by employee_id;

select employee_id, salary * (employee_id%2) * (name not like 'M%') as bonus
from Employees
order by employee_id;

/*627. Swap Salary*/
update Salary 
set sex = case when sex like 'm' then 'f' else 'm' end

/*196. Delete Duplicate Emails*/
Delete p1 
from Person p1, Person p2 
where p1.email = p2.email and p1.id > p2.id

/*1667. Fix Names in a Table*/
select user_id, concat(upper(substr(Users.name, 1, 1)), lower(substr(Users.name, 2))) as name
from Users
order by user_id asc