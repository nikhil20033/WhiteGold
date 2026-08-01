# White Gold Database Schema

## Database Relationships

```text
Roles
   │
   └──── Users
            │
            └──── Customers
                       │
                       └──── Addresses
```

## Tables

### Roles

| Column | Type |
|---------|------|
| Id | BIGINT |
| Name | VARCHAR(50) |

---

### Users

| Column | Type |
|---------|------|
| Id | BIGINT |
| RoleId | BIGINT |
| FullName | VARCHAR(150) |
| Email | VARCHAR(150) |

---

### Customers

| Column | Type |
|---------|------|
| Id | BIGINT |
| UserId | BIGINT |

---

### Addresses

| Column | Type |
|---------|------|
| Id | BIGINT |
| CustomerId | BIGINT |
