/*Select*/
/*1683. Invalid Tweets*/
select tweet_id from Tweets where length(content) > 15

/*Basic Joins*/
/*1378. Replace Employee ID With The Unique Identifier*/
select unique_id, name from Employees left join EmployeeUNI using (id)

/*1068. Product Sales Analysis I*/
select product_name, year, price from Sales inner join Product using (product_id) 