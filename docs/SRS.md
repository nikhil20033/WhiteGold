# Software Requirements Specification (SRS)

Version: 1.0

Project Name: White Gold

---

# 1. Introduction

## 1.1 Purpose

The purpose of White Gold is to build a premium Direct-to-Customer (D2C) dairy platform that connects farms directly with customers through a modern technology ecosystem.

The platform will provide:

- Customer Mobile Application
- Admin Dashboard
- Delivery Partner Application
- Farm ERP
- Analytics & Reporting

---

# 2. Project Objectives

- Deliver fresh milk directly from farms
- Subscription-based delivery
- Daily order management
- Real-time delivery tracking
- Digital payments
- Farm management
- Inventory management
- Business analytics

---

# 3. System Modules

## Customer App

- Authentication
- Home
- Products
- Subscription
- Orders
- Wallet
- Profile
- Notifications

## Admin Panel

- Dashboard
- Customer Management
- Product Management
- Order Management
- Subscription Management
- Employee Management
- Reports

## Delivery App

- Login
- Route Management
- Delivery
- OTP Verification
- Attendance

## Farm ERP

- Cow Management
- Milk Production
- Feed Management
- Vaccination
- Expenses
- Inventory

---

# 4. Technology Stack

Frontend
- React Native
- TypeScript

Backend
- ASP.NET Core

Database
- MySQL

Cache
- Redis

Cloud
- Azure

Authentication
- JWT

Payments
- Razorpay

Maps
- Google Maps

Notifications
- Firebase Cloud Messaging

---

# 5. User Roles

- Customer
- Delivery Partner
- Farm Staff
- Manager
- Admin
- Super Admin

---
## 6. Functional Requirements

### 6.1 User Authentication
- Users shall be able to register using email and mobile number.
- Users shall be able to log in using valid credentials.
- Users shall be able to reset forgotten passwords.
- The system shall support JWT-based authentication and authorization.

### 6.2 Customer Management
- Customers shall be able to manage their profile information.
- Customers shall be able to manage multiple delivery addresses.
- Customers shall be able to view order history and subscription history.

### 6.3 Product Management
- Admin shall be able to create, update and delete products.
- Customers shall be able to browse products by category.
- Customers shall be able to search products.
- Customers shall be able to view product details, pricing and availability.

### 6.4 Cart Management
- Customers shall be able to add products to cart.
- Customers shall be able to update item quantities.
- Customers shall be able to remove items from cart.
- Customers shall be able to clear the cart.

### 6.5 Order Management
- Customers shall be able to place orders.
- Customers shall be able to track order status.
- Customers shall be able to cancel eligible orders.
- Admin shall be able to manage customer orders.

### 6.6 Subscription Management
- Customers shall be able to create milk subscriptions.
- Customers shall be able to pause subscriptions.
- Customers shall be able to resume subscriptions.
- Customers shall be able to cancel subscriptions.
- The system shall automatically generate subscription delivery schedules.

### 6.7 Payment Management
- Customers shall be able to make online payments.
- The system shall verify payment transactions.
- Customers shall be able to view payment history.
- Customers shall be able to download invoices.

### 6.8 Delivery Management
- Delivery partners shall receive assigned deliveries.
- Delivery partners shall update delivery status.
- Customers shall receive delivery notifications.
- Admin shall monitor delivery performance.

### 6.9 Reporting and Analytics
- Admin shall view sales reports.
- Admin shall view customer reports.
- Admin shall view product performance reports.
- Admin shall view subscription reports.
- ## 7. Non-Functional Requirements

### Performance
- Average API response time shall be less than 3 seconds.
- The platform shall support thousands of concurrent users.
- Database queries shall be optimized for performance.

### Availability
- System uptime shall be at least 99.5%.
- Daily database backups shall be maintained.

### Scalability
- The platform shall support horizontal scaling.
- The architecture shall support future modules and integrations.

### Reliability
- System failures shall be logged and monitored.
- Critical services shall implement recovery mechanisms.

### Usability
- The application shall provide a mobile-first user experience.
- The user interface shall be simple, responsive and user-friendly.

### Maintainability
- Source code shall follow Clean Architecture principles.
- Documentation shall be maintained for all major modules.

### Compatibility
- The platform shall support Android, iOS and modern web browsers.
## 8. Security Requirements

### Authentication
- JWT-based authentication shall be implemented.
- Passwords shall be stored using secure hashing algorithms.

### Authorization
- Role-Based Access Control (RBAC) shall be implemented.
- Users shall only access resources permitted to their role.

### Data Security
- Sensitive data shall be encrypted.
- HTTPS shall be used for all communication.

### Application Security
- Input validation shall be implemented.
- SQL Injection protection shall be enforced.
- Cross-Site Scripting (XSS) protection shall be implemented.
- Cross-Site Request Forgery (CSRF) protection shall be implemented.

### Audit and Monitoring
- Critical user actions shall be recorded in audit logs.
- Security events shall be monitored and reported.
- ## 9. Deployment Architecture

### Frontend Layer
- React
- TypeScript
- Vite

### Backend Layer
- ASP.NET Core Web API
- Entity Framework Core
- Business Layer
- Data Access Layer

### Database Layer
- MySQL Database Server

### Cloud Infrastructure
- Microsoft Azure App Service
- Azure Storage
- Azure Monitoring Services

### External Services
- Razorpay Payment Gateway
- Firebase Cloud Messaging
- Google Maps Services

### Deployment Flow

Customer App / Admin Dashboard / Delivery App
                │
                ▼
        ASP.NET Core API
                │
                ▼
           MySQL Database
                │
                ▼
            Azure Cloud
            
