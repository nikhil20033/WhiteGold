## Roles

Purpose:
Stores all application roles.

| Column | Type | Key | Description |
|---------|------|-----|-------------|
| Id | BIGINT | PK | Primary Key |
| Name | VARCHAR(50) | | Role Name |
| Description | VARCHAR(255) | | Role Description |
| IsActive | BOOLEAN | | Active Status |
| CreatedAt | DATETIME | | Created Date |
| UpdatedAt | DATETIME | | Updated Date |
| Id | Name             |
| -- | ---------------- |
| 1  | Admin            |
| 2  | Customer         |
| 3  | Delivery Partner |
| 4  | Farm Manager     |
## Users

Purpose:
Stores login information for every application user.

| Column | Type | Key | Description |
|---------|------|-----|-------------|
| Id | BIGINT | PK | Primary Key |
| RoleId | BIGINT | FK | Role Reference |
| FullName | VARCHAR(150) | | Full Name |
| Email | VARCHAR(150) | UQ | Email Address |
| Phone | VARCHAR(15) | UQ | Mobile Number |
| PasswordHash | VARCHAR(500) | | Encrypted Password |
| LastLogin | DATETIME | | Last Login |
| IsActive | BOOLEAN | | Active Status |
| CreatedAt | DATETIME | | Created Date |
| UpdatedAt | DATETIME | | Updated Date |
## Customers

Purpose:
Stores customer profile details.

| Column | Type | Key | Description |
|---------|------|-----|-------------|
| Id | BIGINT | PK | Primary Key |
| UserId | BIGINT | FK | User Reference |
| CustomerCode | VARCHAR(20) | UQ | Customer Code |
| Gender | VARCHAR(20) | | Gender |
| DateOfBirth | DATE | | Date Of Birth |
| LoyaltyPoints | INT | | Reward Points |
| IsActive | BOOLEAN | | Status |
## Addresses

Purpose:
Stores customer addresses.

| Column | Type | Key | Description |
|---------|------|-----|-------------|
| Id | BIGINT | PK | Primary Key |
| CustomerId | BIGINT | FK | Customer |
| AddressLine1 | VARCHAR(255) | | Address |
| AddressLine2 | VARCHAR(255) | | Address |
| City | VARCHAR(100) | | City |
| State | VARCHAR(100) | | State |
| Country | VARCHAR(100) | | Country |
| Pincode | VARCHAR(10) | | Zip Code |
| Latitude | DECIMAL(10,7) | | Latitude |
| Longitude | DECIMAL(10,7) | | Longitude |
| IsDefault | BOOLEAN | | Default Address |






Roles (1)
   │
   └──────< Users (Many)

Users (1)
   │
   └────── Customers (1)

Customers (1)
   │
   └──────< Addresses (Many)
