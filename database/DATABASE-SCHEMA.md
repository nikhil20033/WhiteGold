# White Gold Database Schema

Version: 1.0

---

# Database Information

Project Name: White Gold

Database Engine: MySQL

Character Set: utf8mb4

Collation: utf8mb4_unicode_ci

Storage Engine: InnoDB

Timezone: UTC

---

# Database Naming Convention

## Tables

PascalCase

Example:

Users

Products

Orders

---

## Columns

PascalCase

Example:

FullName

ProductName

CreatedAt

---

## Primary Key

Id

---

## Foreign Key

<EntityName>Id

Example:

CustomerId

RoleId

ProductId

OrderId

---

## Audit Columns

Every table should contain:

CreatedAt

UpdatedAt

CreatedBy

UpdatedBy

IsActive

IsDeleted

---

# Common Data Types

| Type | Usage |
|------|------|
| BIGINT | Primary Keys |
| INT | Numbers |
| VARCHAR | Text |
| TEXT | Large Text |
| BOOLEAN | True / False |
| DECIMAL(10,2) | Price |
| DATE | Date |
| DATETIME | Date Time |

---

# Module 1 - Roles

## Purpose

Stores all application roles.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| Name | VARCHAR(50) | UQ | No | Role Name |
| Description | VARCHAR(255) | | Yes | Role Description |
| IsActive | BOOLEAN | | No | Active Status |
| CreatedAt | DATETIME | | No | Created Date |
| UpdatedAt | DATETIME | | Yes | Updated Date |

### Sample Roles

Admin

Customer

Delivery Partner

Farm Manager

---

# Module 2 - Users

## Purpose

Stores application login users.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| RoleId | BIGINT | FK | No | Role |
| FullName | VARCHAR(150) | | No | Full Name |
| Email | VARCHAR(150) | UQ | No | Email |
| Phone | VARCHAR(20) | UQ | No | Mobile Number |
| PasswordHash | VARCHAR(500) | | No | Encrypted Password |
| LastLogin | DATETIME | | Yes | Last Login |
| IsActive | BOOLEAN | | No | Active Status |
| CreatedAt | DATETIME | | No | Created Date |
| UpdatedAt | DATETIME | | Yes | Updated Date |

Relationship

Roles (1) ------< Users (Many)

---

# Module 3 - Customers

## Purpose

Stores customer profile information.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| UserId | BIGINT | FK | No | User Reference |
| CustomerCode | VARCHAR(20) | UQ | No | Customer Code |
| Gender | VARCHAR(20) | | Yes | Gender |
| DateOfBirth | DATE | | Yes | DOB |
| LoyaltyPoints | INT | | No | Reward Points |
| IsActive | BOOLEAN | | No | Active |

Relationship

Users (1) ------ Customers (1)

---

# Module 4 - Addresses

## Purpose

Stores customer addresses.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CustomerId | BIGINT | FK | No | Customer |
| AddressLine1 | VARCHAR(255) | | No | Address |
| AddressLine2 | VARCHAR(255) | | Yes | Address |
| City | VARCHAR(100) | | No | City |
| State | VARCHAR(100) | | No | State |
| Country | VARCHAR(100) | | No | Country |
| Pincode | VARCHAR(10) | | No | Postal Code |
| Latitude | DECIMAL(10,7) | | Yes | Latitude |
| Longitude | DECIMAL(10,7) | | Yes | Longitude |
| IsDefault | BOOLEAN | | No | Default Address |

Relationship

Customers (1) ------< Addresses (Many)

---






# Module 5 - Categories

## Purpose

Stores all product categories.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| Name | VARCHAR(100) | UQ | No | Category Name |
| Description | VARCHAR(255) | | Yes | Category Description |
| DisplayOrder | INT | | No | Display Order |
| IsActive | BOOLEAN | | No | Active Status |
| CreatedAt | DATETIME | | No | Created Date |
| UpdatedAt | DATETIME | | Yes | Updated Date |

### Sample Categories

Milk

Curd

Paneer

Butter

Ghee

Relationship

Categories (1) ------< Products (Many)

---

# Module 6 - Products

## Purpose

Stores all products available for sale.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CategoryId | BIGINT | FK | No | Category Reference |
| ProductCode | VARCHAR(30) | UQ | No | Product Code |
| ProductName | VARCHAR(150) | | No | Product Name |
| Description | TEXT | | Yes | Product Description |
| Price | DECIMAL(10,2) | | No | Selling Price |
| Unit | VARCHAR(20) | | No | Unit (Litre, Kg, Packet) |
| Weight | DECIMAL(10,2) | | Yes | Product Weight |
| StockQuantity | INT | | No | Available Stock |
| MinimumStock | INT | | No | Minimum Stock |
| ImageUrl | VARCHAR(255) | | Yes | Default Product Image |
| IsActive | BOOLEAN | | No | Active Status |
| CreatedAt | DATETIME | | No | Created Date |
| UpdatedAt | DATETIME | | Yes | Updated Date |

### Validation Rules

- ProductCode must be unique.
- Price must be greater than zero.
- StockQuantity cannot be negative.

Relationship

Products (Many) ------ (1) Categories

---

# Module 7 - ProductImages

## Purpose

Stores multiple images for a product.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| ProductId | BIGINT | FK | No | Product Reference |
| ImageUrl | VARCHAR(255) | | No | Image URL |
| DisplayOrder | INT | | No | Display Order |
| IsPrimary | BOOLEAN | | No | Main Product Image |

Relationship

Products (1) ------< ProductImages (Many)

---

# Module 8 - Inventory

## Purpose

Tracks available product inventory.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| ProductId | BIGINT | FK | No | Product |
| AvailableQuantity | INT | | No | Available Quantity |
| ReservedQuantity | INT | | No | Reserved Quantity |
| DamagedQuantity | INT | | No | Damaged Quantity |
| LastUpdated | DATETIME | | No | Last Updated |

Relationship

Products (1) ------ (1) Inventory

---


# Module 9 - Cart

## Purpose

Stores the active shopping cart for each customer.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CustomerId | BIGINT | FK | No | Customer Reference |
| TotalItems | INT | | No | Total Number of Items |
| TotalAmount | DECIMAL(10,2) | | No | Cart Total Amount |
| CreatedAt | DATETIME | | No | Created Date |
| UpdatedAt | DATETIME | | Yes | Updated Date |

Relationship

Customers (1) ------ (1) Cart

---

# Module 10 - CartItems

## Purpose

Stores all products added to the shopping cart.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CartId | BIGINT | FK | No | Cart Reference |
| ProductId | BIGINT | FK | No | Product Reference |
| Quantity | DECIMAL(10,2) | | No | Quantity |
| UnitPrice | DECIMAL(10,2) | | No | Product Price |
| TotalPrice | DECIMAL(10,2) | | No | Total Price |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Cart (1) ------< CartItems (Many)

Products (1) ------< CartItems (Many)

---

# Module 11 - Orders

## Purpose

Stores customer orders.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| OrderNumber | VARCHAR(30) | UQ | No | Unique Order Number |
| CustomerId | BIGINT | FK | No | Customer |
| AddressId | BIGINT | FK | No | Delivery Address |
| OrderDate | DATETIME | | No | Order Date |
| DeliveryDate | DATE | | Yes | Delivery Date |
| OrderStatus | VARCHAR(30) | | No | Pending / Confirmed / Delivered / Cancelled |
| PaymentStatus | VARCHAR(30) | | No | Pending / Paid / Failed |
| SubTotal | DECIMAL(10,2) | | No | Product Total |
| DeliveryCharge | DECIMAL(10,2) | | No | Delivery Charge |
| Discount | DECIMAL(10,2) | | No | Discount |
| Tax | DECIMAL(10,2) | | No | GST |
| TotalAmount | DECIMAL(10,2) | | No | Final Amount |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Customers (1) ------< Orders (Many)

Addresses (1) ------< Orders (Many)

---

# Module 12 - OrderItems

## Purpose

Stores products included in an order.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| OrderId | BIGINT | FK | No | Order Reference |
| ProductId | BIGINT | FK | No | Product Reference |
| Quantity | DECIMAL(10,2) | | No | Ordered Quantity |
| UnitPrice | DECIMAL(10,2) | | No | Price Per Unit |
| TotalPrice | DECIMAL(10,2) | | No | Total Price |

Relationship

Orders (1) ------< OrderItems (Many)

Products (1) ------< OrderItems (Many)

---


# Module 13 - Payments

## Purpose

Stores payment transactions for customer orders.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| OrderId | BIGINT | FK | No | Order Reference |
| TransactionId | VARCHAR(100) | UQ | No | Payment Gateway Transaction ID |
| PaymentMethod | VARCHAR(50) | | No | UPI, Card, Net Banking, COD |
| Amount | DECIMAL(10,2) | | No | Paid Amount |
| PaymentStatus | VARCHAR(30) | | No | Pending, Success, Failed |
| PaidAt | DATETIME | | Yes | Payment Date & Time |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Orders (1) ------< Payments (Many)

---

# Module 14 - Coupons

## Purpose

Stores promotional coupons.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CouponCode | VARCHAR(30) | UQ | No | Coupon Code |
| DiscountType | VARCHAR(20) | | No | Flat / Percentage |
| DiscountValue | DECIMAL(10,2) | | No | Discount Value |
| MinimumOrderAmount | DECIMAL(10,2) | | No | Minimum Order Amount |
| MaximumDiscount | DECIMAL(10,2) | | Yes | Maximum Discount |
| ExpiryDate | DATE | | No | Expiry Date |
| IsActive | BOOLEAN | | No | Active Status |

---

# Module 15 - Subscriptions

## Purpose

Stores recurring milk subscriptions.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CustomerId | BIGINT | FK | No | Customer |
| ProductId | BIGINT | FK | No | Product |
| Quantity | DECIMAL(10,2) | | No | Daily Quantity |
| StartDate | DATE | | No | Subscription Start |
| EndDate | DATE | | Yes | Subscription End |
| DeliveryTime | VARCHAR(30) | | Yes | Morning / Evening |
| Status | VARCHAR(30) | | No | Active / Paused / Cancelled |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Customers (1) ------< Subscriptions (Many)

Products (1) ------< Subscriptions (Many)

---

# Module 16 - SubscriptionSchedules

## Purpose

Stores daily delivery schedule for subscriptions.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| SubscriptionId | BIGINT | FK | No | Subscription |
| DeliveryDate | DATE | | No | Delivery Date |
| Quantity | DECIMAL(10,2) | | No | Quantity |
| Status | VARCHAR(30) | | No | Pending / Delivered / Skipped |

Relationship

Subscriptions (1) ------< SubscriptionSchedules (Many)

---

# Module 17 - SubscriptionHolidays

## Purpose

Stores temporary pauses for subscriptions.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| SubscriptionId | BIGINT | FK | No | Subscription |
| StartDate | DATE | | No | Holiday Start |
| EndDate | DATE | | No | Holiday End |
| Reason | VARCHAR(255) | | Yes | Pause Reason |

Relationship

Subscriptions (1) ------< SubscriptionHolidays (Many)

---

# Module 18 - DeliveryPartners

## Purpose

Stores delivery partner information.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| UserId | BIGINT | FK | No | User Reference |
| EmployeeCode | VARCHAR(30) | UQ | No | Delivery Partner Code |
| VehicleNumber | VARCHAR(20) | | Yes | Vehicle Registration Number |
| LicenseNumber | VARCHAR(50) | | Yes | Driving License Number |
| Phone | VARCHAR(20) | | No | Contact Number |
| Status | VARCHAR(30) | | No | Active / Inactive |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Users (1) ------ DeliveryPartners (1)

---

# Module 19 - DeliveryAssignments

## Purpose

Assigns orders to delivery partners.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| OrderId | BIGINT | FK | No | Order Reference |
| DeliveryPartnerId | BIGINT | FK | No | Delivery Partner |
| AssignedAt | DATETIME | | No | Assignment Time |
| DeliveredAt | DATETIME | | Yes | Delivery Time |
| Status | VARCHAR(30) | | No | Assigned / Delivered / Failed |

Relationship

Orders (1) ------< DeliveryAssignments (Many)

DeliveryPartners (1) ------< DeliveryAssignments (Many)

---

# Module 20 - Notifications

## Purpose

Stores application notifications.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CustomerId | BIGINT | FK | No | Customer |
| Title | VARCHAR(200) | | No | Notification Title |
| Message | TEXT | | No | Notification Message |
| IsRead | BOOLEAN | | No | Read Status |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Customers (1) ------< Notifications (Many)

---

# Module 21 - Reviews

## Purpose

Stores customer reviews and ratings.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| CustomerId | BIGINT | FK | No | Customer |
| ProductId | BIGINT | FK | No | Product |
| Rating | INT | | No | Rating (1-5) |
| Review | TEXT | | Yes | Review Text |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Customers (1) ------< Reviews (Many)

Products (1) ------< Reviews (Many)

---

# Module 22 - AuditLogs

## Purpose

Stores system audit history.

### Columns

| Column | Type | Key | Nullable | Description |
|---------|------|-----|----------|-------------|
| Id | BIGINT | PK | No | Primary Key |
| UserId | BIGINT | FK | Yes | User |
| Module | VARCHAR(100) | | No | Module Name |
| Action | VARCHAR(50) | | No | Create / Update / Delete |
| Description | TEXT | | Yes | Action Details |
| IpAddress | VARCHAR(50) | | Yes | Client IP |
| CreatedAt | DATETIME | | No | Created Date |

Relationship

Users (1) ------< AuditLogs (Many)

---

# Recommended Indexes

- PK on every Id column
- Unique Index on Email
- Unique Index on Phone
- Unique Index on ProductCode
- Unique Index on CustomerCode
- Unique Index on CouponCode
- Index on CustomerId
- Index on ProductId
- Index on OrderId
- Index on CreatedAt

---

# Database Constraints

- Email must be unique.
- Phone number must be unique.
- Product code must be unique.
- Customer code must be unique.
- Stock quantity cannot be negative.
- Product price must be greater than zero.
- Rating must be between 1 and 5.
- Quantity must be greater than zero.
- Every order must have at least one OrderItem.

---

# Future Modules

- Wishlist
- Returns & Refunds
- Wallet
- Referral Program
- Loyalty Rewards
- Delivery Routes
- Warehouse Management
- Inventory History
- Supplier Management
- Purchase Orders
- Reports & Analytics
- Multi-Language Support

---

# Database Relationship Summary

Roles
    │
    └──── Users
             │
             ├──── Customers
             │      ├──── Addresses
             │      ├──── Cart
             │      │      └──── CartItems
             │      ├──── Orders
             │      │      ├──── OrderItems
             │      │      ├──── Payments
             │      │      └──── DeliveryAssignments
             │      ├──── Subscriptions
             │      │      ├──── SubscriptionSchedules
             │      │      └──── SubscriptionHolidays
             │      ├──── Notifications
             │      └──── Reviews
             │
             └──── DeliveryPartners

Categories
      │
      └──── Products
               ├──── ProductImages
               ├──── Inventory
               ├──── OrderItems
               ├──── CartItems
               ├──── Reviews
               └──── Subscriptions

Orders
   ├──── Payments
   └──── DeliveryAssignments

---

# Database Version

Current Version: **1.0**

Status: **Approved for Backend Development**
