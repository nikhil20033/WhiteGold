# White Gold ER Diagram

```text
                               +----------------+
                               |     Roles      |
                               +----------------+
                               | PK Id          |
                               | Name           |
                               +----------------+
                                        |
                                        | 1
                                        |
                                        | N
                               +----------------+
                               |     Users      |
                               +----------------+
                               | PK Id          |
                               | FK RoleId      |
                               | FullName       |
                               | Email          |
                               | Phone          |
                               | PasswordHash   |
                               +----------------+
                                        |
                                        | 1
                                        |
                                        | 1
                               +----------------+
                               |   Customers    |
                               +----------------+
                               | PK Id          |
                               | FK UserId      |
                               | CustomerCode   |
                               +----------------+
                                        |
                     +------------------+------------------+
                     |                                     |
                     | 1                                   | 1
                     |                                     |
                     | N                                   | N
             +----------------+                  +------------------+
             |   Addresses    |                  |    Orders        |
             +----------------+                  +------------------+
             | PK Id          |                  | PK Id            |
             | FK CustomerId  |                  | FK CustomerId    |
             | City           |                  | OrderDate        |
             | State          |                  | TotalAmount      |
             +----------------+                  +------------------+
                                                        |
                                                        | 1
                                                        |
                                                        | N
                                              +------------------+
                                              |   OrderItems     |
                                              +------------------+
                                              | PK Id            |
                                              | FK OrderId       |
                                              | FK ProductId     |
                                              | Quantity         |
                                              | Price            |
                                              +------------------+
                                                        |
                                                        | N
                                                        |
                                                        | 1
                                              +------------------+
                                              |    Products      |
                                              +------------------+
                                              | PK Id            |
                                              | FK CategoryId    |
                                              | ProductName      |
                                              | Price            |
                                              +------------------+
                                                        |
                                                        | N
                                                        |
                                                        | 1
                                              +------------------+
                                              |   Categories     |
                                              +------------------+
                                              | PK Id            |
                                              | CategoryName     |
                                              +------------------+

Customers
     |
     | 1
     |
     | N
+----------------------+
|   Subscriptions      |
+----------------------+
| PK Id                |
| FK CustomerId        |
| FK ProductId         |
| Quantity             |
+----------------------+

Orders
   |
   | 1
   |
   | N
+----------------------+
|      Payments        |
+----------------------+
| PK Id                |
| FK OrderId           |
| Amount               |
| PaymentStatus        |
+----------------------+
```
