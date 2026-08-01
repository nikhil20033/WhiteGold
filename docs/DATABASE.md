# Database Design

Version: 1.0

Project Name: White Gold

---

# 1. Overview

The White Gold platform uses MySQL as the primary relational database.

The database is designed to support customers, subscriptions, products, orders, deliveries, and administration.

---

# 2. Main Entities

## Users

Stores login credentials and authentication details.

---

## Customers

Stores customer profile information.

---

## Products

Stores milk and dairy products.

---

## Categories

Stores product categories.

---

## Addresses

Stores customer delivery addresses.

---

## Orders

Stores customer orders.

---

## Order Items

Stores products inside each order.

---

## Subscriptions

Stores recurring milk delivery plans.

---

## Payments

Stores payment transactions.

---

## Delivery Partners

Stores delivery staff information.

---

## Routes

Stores delivery routes.

---

## Notifications

Stores push notifications.

---

# 3. Relationships

- One Customer → Many Orders
- One Order → Many Order Items
- One Product → Many Order Items
- One Customer → Many Subscriptions
- One Customer → Many Addresses
- One Delivery Partner → Many Routes

---

# 4. Future Tables

- Coupons
- Wallet
- Reviews
- Referral
- Inventory
- Farm Animals
- Milk Production
- Attendance
- Expenses
- Reports
