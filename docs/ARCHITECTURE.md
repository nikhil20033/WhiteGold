# System Architecture

Version: 1.0

Project Name: White Gold

---

# 1. Overview

White Gold is a Direct-to-Customer (D2C) dairy platform built using a modern, scalable architecture.

The platform consists of multiple applications connected to a centralized backend.

---

# 2. High-Level Architecture

```
                    Customer Mobile App
                           │
                           │
                    REST API (ASP.NET Core)
                           │
      ┌───────────────┬───────────────┬───────────────┐
      │               │               │               │
 Admin Dashboard   Delivery App     Farm ERP      Notification Service
      │               │               │               │
      └───────────────┴───────────────┴───────────────┘
                           │
                     Business Layer
                           │
                     Data Access Layer
                           │
                    MySQL Database
                           │
                 Azure Cloud Infrastructure
```

---

# 3. Applications

- Customer Mobile App
- Admin Dashboard
- Delivery Partner App
- Farm ERP

---

# 4. Backend

- ASP.NET Core Web API
- Clean Architecture
- Entity Framework Core

---

# 5. Database

- MySQL

---

# 6. Authentication

- JWT Authentication

---

# 7. Cloud Services

- Azure App Service
- Azure Storage
- Firebase Cloud Messaging

---

# 8. Future Integrations

- Payment Gateway
- SMS Service
- Email Service
- WhatsApp Notifications
- AI Analytics
