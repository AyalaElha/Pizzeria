# Pizzeria
project to manage orders of a pizza shops 
pizzeria

##**Pizza**
Id

Type

>Price
+Get – https://pizzeria.co.il/pizza/ -get pizza
+Get(i)– https://pizzeria.co.il/pizza?id -get pizza  by id
*Put- https://pizzeria.co.il/pizza/{id} -update pizza by id
&Post - https://pizzeria.co.il/pizza  -add new pizza
##**Customer**
Id
Name
Phone
Address
Get – https://pizzeria.co.il/customer/ -get customer
Get(i)– https://pizzeria.co.il/customer?id -get customer by id
Put- https://pizzeria.co.il/customer /{id} -update customer by id
Post - https://pizzeria.co.il/customer -add new customer
##**Order**
Id
IdPizza
idCustomer
date
list of pizza
Get – https://pizzeria.co.il/order/ -get order
Get(i)– https://pizzeria.co.il/order?id -get order by id
Put- https://pizzeria.co.il/order /{id} -update order by id
Post - https://pizzeria.co.il/order -add new order
Delete-https://pizzeria.co.il/order/{id}/ – erase 
