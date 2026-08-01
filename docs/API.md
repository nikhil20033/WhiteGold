# API Documentation

Version: 1.0

Project Name: White Gold

---

# Authentication

POST /api/auth/login

POST /api/auth/verify-otp

POST /api/auth/logout

---

# Products

GET /api/products

GET /api/products/{id}

GET /api/categories

---

# Customers

GET /api/customers/profile

PUT /api/customers/profile

GET /api/customers/addresses

POST /api/customers/address

---

# Orders

POST /api/orders

GET /api/orders

GET /api/orders/{id}

---

# Subscriptions

GET /api/subscriptions

POST /api/subscriptions

PUT /api/subscriptions/{id}

DELETE /api/subscriptions/{id}

---

# Payments

POST /api/payments

GET /api/payments/history

---

# Notifications

GET /api/notifications

PUT /api/notifications/read
