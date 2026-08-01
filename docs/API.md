# API Documentation

Version: 1.0

Project Name: White Gold

---

# 1. Overview

The White Gold backend exposes REST APIs for customer applications, admin dashboard, delivery partner app, and Farm ERP.

Base URL

https://api.whitegold.in/api/v1

Authentication

JWT Bearer Token

Content-Type

application/json

---

# 2. Authentication APIs

POST /auth/register

Create a new customer account.

POST /auth/login

Login using mobile/email and password.

POST /auth/refresh-token

Generate a new access token.

POST /auth/logout

Logout current user.

---

# 3. Customer APIs

GET /customers/profile

Update customer profile.

PUT /customers/profile

Update customer information.

GET /customers/address

Get saved addresses.

POST /customers/address

Add new address.

DELETE /customers/address/{id}

Delete address.

---

# 4. Product APIs

GET /products

Get all products.

GET /products/{id}

Get product details.

GET /products/category/{id}

Products by category.

GET /products/search

Search products.

---

# 5. Cart APIs

GET /cart

View cart.

POST /cart

Add product to cart.

PUT /cart/{id}

Update cart quantity.

DELETE /cart/{id}

Remove product.

---

# 6. Order APIs

POST /orders

Create order.

GET /orders

Order history.

GET /orders/{id}

Order details.

PUT /orders/cancel/{id}

Cancel order.

---

# 7. Subscription APIs

POST /subscriptions

Create subscription.

GET /subscriptions

View subscriptions.

PUT /subscriptions/{id}

Update subscription.

DELETE /subscriptions/{id}

Cancel subscription.

---

# 8. Payment APIs

POST /payments/create

Create payment.

POST /payments/verify

Verify payment.

GET /payments/history

Payment history.

---

# 9. Delivery APIs

GET /delivery/orders

Assigned deliveries.

PUT /delivery/status

Update delivery status.

GET /delivery/history

Delivery history.

---

# 10. Admin APIs

GET /admin/dashboard

Dashboard statistics.

GET /admin/customers

Customer list.

GET /admin/orders

Order list.

GET /admin/products

Manage products.

GET /admin/payments

Payment reports.

GET /admin/delivery

Delivery reports.

---

# 11. Future APIs

Wishlist

Notifications

Coupons

Referral

Loyalty Points

Inventory

Reports

Analytics

AI Recommendation Engine
