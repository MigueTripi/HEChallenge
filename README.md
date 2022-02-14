# HE Challenges
The aim of this repository is to provide solutions for code challenges.

# Exercises
1- C#
You are given two arbitrarily large numbers,
stored one digit at a time in an array.
The first must be added to the second,
and the second must be reversed before addition.
The goal is to calculate the sum of those two sets of values.

IMPORTANT NOTE:
- The input can be any length (i.e: it can be 20+ digits long).
- num1 and num2 can be different lengths.

Sample Inputs:
num1 = 123456
num2 = 123456

Sample Output:
Result: 777777
Please include a demonstration of appropriate unit tests for this functionality.

2- SQL
You have three different tables

A Customer Table with FirstName, LastName, Age, Occupation, MartialStatus, PersonID
An Orders Table with OrderID, PersonID, DateCreated, MethodofPurchase
An Orders Details table with OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin

Please return a result of the customers who ordered product ID = 1112222333 and return
FirstName and LastName as full name, age, orderid, datecreated, MethodOfPurchase as Purchase Method, ProductNumber and ProductOrigin


# Solutions

# C#

#.NET version
.NET 6

# Projects

You will find two simple projects in .net folder:
- Console project which one you can add the arrays you would like to sum.
- There is a Business project where the logic is allocated.
- Test project which one have some data validations and some real cases

# Algorithms

I have decided to iterate always the first provided array and sum its values with the second array values. 
I didn't create any reversed array for the second array, I have accessed to its values calculating the indexes in reverse way. 


# SQL 
You can find in SQL folder a T-SQL script which contains:
- DB creation
- Tables creation (I assumed data times)
- Data initialization for testing proposes
- Query for asked data.
