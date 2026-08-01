# White Gold Database Schema

Version: 1.0

---

# Database Information

Database Engine: MySQL

Character Set: utf8mb4

Collation: utf8mb4_unicode_ci

Naming Convention:

- Tables: PascalCase
- Columns: PascalCase
- Primary Key: Id
- Foreign Key: EntityNameId

---

# Audit Columns

Every table will contain:

- CreatedAt
- UpdatedAt
- CreatedBy
- UpdatedBy
- IsDeleted
- IsActive

---

# Common Data Types

BIGINT

INT

VARCHAR

TEXT

DECIMAL

DATE

DATETIME

BOOLEAN
