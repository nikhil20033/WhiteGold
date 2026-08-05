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
