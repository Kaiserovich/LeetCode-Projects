/*Day 1 Select*/
/*595. Big Countries*/
select name, population, area from World where area >= 3000000 or population >= 25000000

/*1757. Recyclable and Low Fat Products*/
select product_id from Products where low_fats = 'Y' and recyclable = 'Y'

/*584. Find Customer Referee*/
select name from Customer where referee_id <> 2 or referee_id is null

/*183. Customers Who Never Order*/
select c.name as Customers from Customers c left join Orders o on c.id = o.customerId where o.customerId is null


/*Day 2 Select & Order*/
/*1873. Calculate Special Bonus*/
/*1*/
select employee_id,
    case when name like 'M%' or employee_id %2 = 0 then 0 else salary
    end as bonus
from Employees
order by employee_id;
/*2*/
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


/*Day 3 String Processing Functions*/
/*1667. Fix Names in a Table*/
select user_id, concat(upper(substr(Users.name, 1, 1)), lower(substr(Users.name, 2))) as name
from Users
order by user_id asc

/*1484. Group Sold Products By The Date*/
select sell_date, count(distinct product) as num_sold, group_concat(distinct product) as products
from Activities
group by sell_date 
order by sell_date

/*1527. Patients With a Condition*/
select * from Patients where conditions like 'DIAB1%' or conditions like '% DIAB1%'


/*Day 4 Union & Select*/
/*1965. Employees With Missing Information*/
/*1*/
select T.employee_id
from 
  (select * from Employees left join Salaries using(employee_id)
  union
  select * from Employees right join Salaries using(employee_id))
as T
where T.salary is null or T.name is null
order by T.employee_id
/*1*/
select employee_id from Employees where employee_id not in (select employee_id from Salaries)
union
select employee_id from Salaries where employee_id not in (select employee_id from Employees)
order by employee_id

/*1795. Rearrange Products Table*/
select product_id, 'store1' as store, store1 as price
from Products
where store1 is not null

union

select product_id, 'store2' as store, store2 as price
from Products
where store2 is not null

union

select product_id, 'store3' as store, store3 as price
from Products
where store3 is not null

/*608. Tree Node*/
/*1*/
select id, 
    case
        when p_id is null then 'Root'
        when id in (select p_id from tree) then 'Inner'
        else 'Leaf'
    end as type
from Tree
/*2*/
select id, 'Root' as Type
from Tree
where p_id is null

union

select id, 'Inner' as Type
from Tree
where id in (select distinct p_id from Tree where p_id is not null)
    and p_id is not null

union

select id, 'Leaf' as Type
from Tree
where id not in (select distinct p_id from Tree where p_id is not null)
    and p_id is not null

/*176. Second Highest Salary*/
/*1*/
select DISTINCT max(salary) as SecondHighestSalary 
from Employee 
where salary < (Select max(salary) from Employee)
/*2*/
SELECT
    IFNULL(
      (SELECT DISTINCT Salary
       FROM Employee
       ORDER BY Salary DESC
        LIMIT 1 OFFSET 1),
    NULL) AS SecondHighestSalary


/*Day 5 Union*/
/*175. Combine Two Tables*/
select firstName, lastName, city, state 
from Person left join Address using(personId)

/*1581. Customer Who Visited but Did Not Make Any Transactions*/
select customer_id, count(customer_id) as count_no_trans   
from Visits left join Transactions using(visit_id)
where transaction_id  is null
group by customer_id

/*1148. Article Views I*/
/*1*/
select author_id as id from Views 
where author_id = viewer_id 
group by id
order by id
/*2*/
select distinct author_id as id from Views 
where author_id = viewer_id 
order by id


/*Day 6 Union*/
/*197. Rising Temperature*/
/*1*/
select Weather.id from Weather 
join Weather w on DATEDIFF(Weather.recordDate, w.recordDate) = 1 
and Weather.Temperature  > w.Temperature 
/*2*/
select Weather.id from Weather 
join Weather w on Weather.recordDate = DATE_ADD(w.recordDate, interval 1 day) 
where Weather.Temperature  > w.Temperature 

/*607. Sales Person*/
select s.Name 
from SalesPerson s 
where s.sales_id not in (
  select o.sales_id 
  from Orders o
  left join Company c using(com_id)
  where c.name like 'RED'
)

/*Day 7 Function*/
/*1141. User Activity for the Past 30 Days I*/
select activity_date as day, count(distinct user_id) as active_users 
from Activity
where datediff('2019-07-27', activity_date) between 0 and 29
group by activity_date;

/*1693. Daily Leads and Partners*/
select date_id, make_name, count(distinct lead_id) as unique_leads, count(distinct partner_id ) as unique_partners 
from DailySales
group by date_id, make_name