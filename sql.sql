--1251. Average Selling Price
/* Write your T-SQL query statement below */
select t.product_id ,round( cast(sum(t.total) as float) / sum(t.units),2 ) average_price from
(select  us.product_id,us.units,p.price,(us.units * p.price) total from UnitsSold us join Prices p 
on us.product_id= p.product_id and us.purchase_date between p.start_date and p.end_date ) t
group by t.product_id

--181. Employees Earning More Than Their Managers
select e.name Employee from employee e join employee m on e.managerId = m.id
where e.salary > m.salary

--182. Duplicate Emails
select r.email from(
select p.email,count(p.id) duplicate from person p 
group by p.email) r where r.duplicate > 1

--183. Customers Who Never Order
select c.name customers from customers c left join
orders o on c.id = o.customerId
where o.id is null