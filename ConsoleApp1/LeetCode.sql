/*595. Big Countries*/
select name, population, area from World where area >= 3000000 or population >= 25000000

/*1757. Recyclable and Low Fat Products*/
select product_id from Products where low_fats = 'Y' and recyclable = 'Y'