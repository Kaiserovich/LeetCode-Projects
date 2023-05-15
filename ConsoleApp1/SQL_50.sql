/*Select*/
/*1683. Invalid Tweets*/
select tweet_id from Tweets where length(content) > 15

/*Basic Joins*/
/*1378. Replace Employee ID With The Unique Identifier*/
select unique_id, name from Employees left join EmployeeUNI using (id)

/*1068. Product Sales Analysis I*/
select product_name, year, price from Sales inner join Product using (product_id) 

/*1661. Average Time of Process per Machine*/
/*1*/
select a.machine_id, round(avg(b.timestamp - a.timestamp), 3) as processing_time 
from Activity a
join Activity b on a.machine_id = b.machine_id and a.process_id = b.process_id and a.activity_type = 'start' and b.activity_type = 'end'
group by a.machine_id 
/*2*/
select machine_id, round(sum(case when activity_type = 'end' then timestamp else -timestamp end)/count(distinct process_id), 3) as processing_time
from Activity
group by machine_id 

/*577. Employee Bonus*/
select name, bonus from Employee left join Bonus using(empId) where bonus is null or bonus < 1000

/*1280. Students and Examinations*/
select student_id, student_name, subject_name, count(ex.student_id) as attended_exams from Subjects
cross join Students
left join Examinations ex using(subject_name,student_id)
group by student_id, subject_name
order by student_id, subject_name

/*570. Managers with at Least 5 Direct Reports*/
/*1*/
select name
from Employee e1 
join (select ManagerId 
  from Employee
  group by ManagerId
  having count(ManagerId) >= 5) as e2
on e1.Id = e2.ManagerId
/*2*/
select name from Employee where id in
(select managerId from Employee group by managerId having count(managerId) > 4)

/*1934. Confirmation Rate*/
/*1*/
select user_id, round(avg(if(action = 'confirmed', 1, 0)),2) as confirmation_rate 
from Signups s
left join Confirmations using(user_id)
group by user_id
/*2*/
select user_id, round(avg(case when action = 'confirmed' then 1 else 0 end),2) as confirmation_rate 
from Signups s
left join Confirmations using(user_id)
group by user_id