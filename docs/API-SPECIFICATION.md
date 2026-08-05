# White Gold API Specification

Version: 1.0

---

# API Overview

## Base URL

/api/v1

## Authentication

JWT Bearer Token

## Content Type

application/json

## Response Format

JSON

---

# Standard Success Response

```json
{
    "success": true,
    "message": "Request completed successfully.",
    "data": {}
}
```

---

# Standard Error Response

```json
{
    "success": false,
    "message": "Validation failed.",
    "errors": []
}
```

---

# Authentication APIs

## Register Customer

POST /api/v1/auth/register

Authentication Required: No

### Request

```json
{
  "fullName": "John Doe",
  "email": "john@example.com",
  "phone": "9876543210",
  "password": "Password@123"
}
```

### Response

```json
{
  "success": true,
  "message": "Customer registered successfully."
}
```

---

## Login

POST /api/v1/auth/login

Authentication Required: No

### Request

```json
{
  "email": "john@example.com",
  "password": "Password@123"
}
```

### Response

```json
{
  "token": "JWT_TOKEN",
  "refreshToken": "REFRESH_TOKEN",
  "expiresIn": 3600
}
```

---

## Refresh Token

POST /api/v1/auth/refresh

Authentication Required: No

### Request

```json
{
  "refreshToken": "REFRESH_TOKEN"
}
```

### Response

```json
{
  "token": "NEW_JWT_TOKEN"
}
```

---

## Logout

POST /api/v1/auth/logout

Authentication Required: Yes

### Response

```json
{
  "success": true,
  "message": "Logged out successfully."
}
```

---

## Change Password

PUT /api/v1/auth/change-password

Authentication Required: Yes

### Request

```json
{
  "currentPassword": "OldPassword@123",
  "newPassword": "NewPassword@123"
}
```

### Response

```json
{
  "success": true,
  "message": "Password changed successfully."
}
```

---

## Forgot Password

POST /api/v1/auth/forgot-password

Authentication Required: No

### Request

```json
{
  "email": "john@example.com"
}
```

---

## Reset Password

POST /api/v1/auth/reset-password

Authentication Required: No

### Request

```json
{
  "token": "RESET_TOKEN",
  "newPassword": "Password@123"
}
```

---



# Customer APIs

---

## Get Customer Profile

GET /api/v1/customers/profile

Authentication Required: Yes

### Response

```json
{
  "id": 1,
  "fullName": "John Doe",
  "email": "john@example.com",
  "phone": "9876543210",
  "loyaltyPoints": 250
}
```

---

## Update Customer Profile

PUT /api/v1/customers/profile

Authentication Required: Yes

### Request

```json
{
  "fullName": "John Doe",
  "phone": "9876543210",
  "dateOfBirth": "1998-08-15"
}
```

### Response

```json
{
  "success": true,
  "message": "Profile updated successfully."
}
```

---

## Get Customer Dashboard

GET /api/v1/customers/dashboard

Authentication Required: Yes

### Response

```json
{
  "activeSubscriptions": 2,
  "pendingOrders": 1,
  "walletBalance": 0,
  "loyaltyPoints": 250
}
```

---

# Address APIs

---

## Get All Addresses

GET /api/v1/addresses

Authentication Required: Yes

### Response

```json
[
  {
    "id": 1,
    "addressLine1": "ABC Society",
    "city": "Pune",
    "state": "Maharashtra",
    "pincode": "411001",
    "isDefault": true
  }
]
```

---

## Add Address

POST /api/v1/addresses

Authentication Required: Yes

### Request

```json
{
  "addressLine1": "ABC Society",
  "addressLine2": "Near School",
  "city": "Pune",
  "state": "Maharashtra",
  "country": "India",
  "pincode": "411001"
}
```

### Response

```json
{
  "success": true,
  "message": "Address added successfully."
}
```

---

## Update Address

PUT /api/v1/addresses/{id}

Authentication Required: Yes

### Request

```json
{
  "addressLine1": "XYZ Society",
  "city": "Pune",
  "state": "Maharashtra",
  "pincode": "411001"
}
```

---

## Delete Address

DELETE /api/v1/addresses/{id}

Authentication Required: Yes

### Response

```json
{
  "success": true,
  "message": "Address deleted successfully."
}
```

---

## Set Default Address

PATCH /api/v1/addresses/{id}/default

Authentication Required: Yes

### Response

```json
{
  "success": true,
  "message": "Default address updated."
}
```

---


# Category APIs

---

## Get All Categories

GET /api/v1/categories

Authentication Required: No

### Response

```json
[
  {
    "id": 1,
    "name": "Milk"
  },
  {
    "id": 2,
    "name": "Curd"
  }
]
```

---

## Get Category By Id

GET /api/v1/categories/{id}

Authentication Required: No

---

# Product APIs

---

## Get All Products

GET /api/v1/products

Authentication Required: No

### Query Parameters

| Parameter | Description |
|-----------|-------------|
| page | Page Number |
| pageSize | Records Per Page |
| categoryId | Filter By Category |
| search | Search Product |

Example

GET /api/v1/products?page=1&pageSize=20&categoryId=1

---

## Get Product By Id

GET /api/v1/products/{id}

Authentication Required: No

### Response

```json
{
  "id": 1,
  "productCode": "MILK001",
  "productName": "Cow Milk",
  "price": 65,
  "unit": "Litre",
  "stockQuantity": 150,
  "category": "Milk"
}
```

---

## Search Products

GET /api/v1/products/search?keyword=milk

Authentication Required: No

---

## Get Featured Products

GET /api/v1/products/featured

Authentication Required: No

---

## Get Latest Products

GET /api/v1/products/latest

Authentication Required: No

---

## Get Products By Category

GET /api/v1/categories/{id}/products

Authentication Required: No

---

## Product Review APIs

---

## Get Product Reviews

GET /api/v1/products/{id}/reviews

Authentication Required: No

---

## Add Review

POST /api/v1/products/{id}/reviews

Authentication Required: Yes

### Request

```json
{
  "rating": 5,
  "review": "Very fresh milk."
}
```

---

## Update Review

PUT /api/v1/reviews/{id}

Authentication Required: Yes

---

## Delete Review

DELETE /api/v1/reviews/{id}

Authentication Required: Yes

---

## Product Image APIs

GET /api/v1/products/{id}/images

Authentication Required: No

---


# Cart APIs

---

## Get Cart

GET /api/v1/cart

Authentication Required: Yes

### Response

```json
{
  "items": [
    {
      "productId": 1,
      "productName": "Cow Milk",
      "quantity": 2,
      "unitPrice": 65,
      "totalPrice": 130
    }
  ],
  "totalAmount": 130
}
```

---

## Add To Cart

POST /api/v1/cart

Authentication Required: Yes

### Request

```json
{
  "productId": 1,
  "quantity": 2
}
```

---

## Update Cart Item

PUT /api/v1/cart/{cartItemId}

Authentication Required: Yes

### Request

```json
{
  "quantity": 3
}
```

---

## Remove Cart Item

DELETE /api/v1/cart/{cartItemId}

Authentication Required: Yes

---

## Clear Cart

DELETE /api/v1/cart

Authentication Required: Yes

---

# Order APIs

---

## Place Order

POST /api/v1/orders

Authentication Required: Yes

### Request

```json
{
  "addressId": 1,
  "paymentMethod": "UPI"
}
```

---

## Get My Orders

GET /api/v1/orders

Authentication Required: Yes

---

## Get Order Details

GET /api/v1/orders/{id}

Authentication Required: Yes

---

## Cancel Order

PATCH /api/v1/orders/{id}/cancel

Authentication Required: Yes

---

## Track Order

GET /api/v1/orders/{id}/tracking

Authentication Required: Yes

---

# Payment APIs

---

## Create Payment

POST /api/v1/payments

Authentication Required: Yes

---

## Verify Payment

POST /api/v1/payments/verify

Authentication Required: Yes

---

## Payment History

GET /api/v1/payments/history

Authentication Required: Yes

---

## Download Invoice

GET /api/v1/orders/{id}/invoice

Authentication Required: Yes

Returns PDF Invoice

---# Cart APIs

---

## Get Cart

GET /api/v1/cart

Authentication Required: Yes

### Response

```json
{
  "items": [
    {
      "productId": 1,
      "productName": "Cow Milk",
      "quantity": 2,
      "unitPrice": 65,
      "totalPrice": 130
    }
  ],
  "totalAmount": 130
}
```

---

## Add To Cart

POST /api/v1/cart

Authentication Required: Yes

### Request

```json
{
  "productId": 1,
  "quantity": 2
}
```

---

## Update Cart Item

PUT /api/v1/cart/{cartItemId}

Authentication Required: Yes

### Request

```json
{
  "quantity": 3
}
```

---

## Remove Cart Item

DELETE /api/v1/cart/{cartItemId}

Authentication Required: Yes

---

## Clear Cart

DELETE /api/v1/cart

Authentication Required: Yes

---

# Order APIs

---

## Place Order

POST /api/v1/orders

Authentication Required: Yes

### Request

```json
{
  "addressId": 1,
  "paymentMethod": "UPI"
}
```

---

## Get My Orders

GET /api/v1/orders

Authentication Required: Yes

---

## Get Order Details

GET /api/v1/orders/{id}

Authentication Required: Yes

---

## Cancel Order

PATCH /api/v1/orders/{id}/cancel

Authentication Required: Yes

---

## Track Order

GET /api/v1/orders/{id}/tracking

Authentication Required: Yes

---

# Payment APIs

---

## Create Payment

POST /api/v1/payments

Authentication Required: Yes

---

## Verify Payment

POST /api/v1/payments/verify

Authentication Required: Yes

---

## Payment History

GET /api/v1/payments/history

Authentication Required: Yes

---

## Download Invoice

GET /api/v1/orders/{id}/invoice

Authentication Required: Yes

Returns PDF Invoice

---
# Cart APIs

---

## Get Cart

GET /api/v1/cart

Authentication Required: Yes

### Response

```json
{
  "items": [
    {
      "productId": 1,
      "productName": "Cow Milk",
      "quantity": 2,
      "unitPrice": 65,
      "totalPrice": 130
    }
  ],
  "totalAmount": 130
}
```

---

## Add To Cart

POST /api/v1/cart

Authentication Required: Yes

### Request

```json
{
  "productId": 1,
  "quantity": 2
}
```

---

## Update Cart Item

PUT /api/v1/cart/{cartItemId}

Authentication Required: Yes

### Request

```json
{
  "quantity": 3
}
```

---

## Remove Cart Item

DELETE /api/v1/cart/{cartItemId}

Authentication Required: Yes

---

## Clear Cart

DELETE /api/v1/cart

Authentication Required: Yes

---

# Order APIs

---

## Place Order

POST /api/v1/orders

Authentication Required: Yes

### Request

```json
{
  "addressId": 1,
  "paymentMethod": "UPI"
}
```

---

## Get My Orders

GET /api/v1/orders

Authentication Required: Yes

---

## Get Order Details

GET /api/v1/orders/{id}

Authentication Required: Yes

---

## Cancel Order

PATCH /api/v1/orders/{id}/cancel

Authentication Required: Yes

---

## Track Order

GET /api/v1/orders/{id}/tracking

Authentication Required: Yes

---

# Payment APIs

---

## Create Payment

POST /api/v1/payments

Authentication Required: Yes

---

## Verify Payment

POST /api/v1/payments/verify

Authentication Required: Yes

---

## Payment History

GET /api/v1/payments/history

Authentication Required: Yes

---

## Download Invoice

GET /api/v1/orders/{id}/invoice

Authentication Required: Yes

Returns PDF Invoice

---


# Subscription APIs

---

## Get My Subscriptions

GET /api/v1/subscriptions

Authentication Required: Yes

---

## Create Subscription

POST /api/v1/subscriptions

Authentication Required: Yes

### Request

```json
{
  "productId": 1,
  "quantity": 2,
  "deliveryTime": "Morning",
  "startDate": "2026-09-01"
}
```

---

## Update Subscription

PUT /api/v1/subscriptions/{id}

Authentication Required: Yes

---

## Pause Subscription

PATCH /api/v1/subscriptions/{id}/pause

Authentication Required: Yes

---

## Resume Subscription

PATCH /api/v1/subscriptions/{id}/resume

Authentication Required: Yes

---

## Cancel Subscription

DELETE /api/v1/subscriptions/{id}

Authentication Required: Yes

---

# Delivery APIs

---

## Track Delivery

GET /api/v1/delivery/{orderId}

Authentication Required: Yes

---

## Delivery History

GET /api/v1/delivery/history

Authentication Required: Yes

---

# Notification APIs

---

## Get Notifications

GET /api/v1/notifications

Authentication Required: Yes

---

## Mark Notification As Read

PATCH /api/v1/notifications/{id}/read

Authentication Required: Yes

---

## Delete Notification

DELETE /api/v1/notifications/{id}

Authentication Required: Yes

---

# Admin APIs

---

## Dashboard Summary

GET /api/v1/admin/dashboard

Authentication Required: Yes (Admin)

---

## Customer Management

GET /api/v1/admin/customers

GET /api/v1/admin/customers/{id}

PUT /api/v1/admin/customers/{id}

DELETE /api/v1/admin/customers/{id}

---

## Product Management

GET /api/v1/admin/products

POST /api/v1/admin/products

PUT /api/v1/admin/products/{id}

DELETE /api/v1/admin/products/{id}

---

## Category Management

GET /api/v1/admin/categories

POST /api/v1/admin/categories

PUT /api/v1/admin/categories/{id}

DELETE /api/v1/admin/categories/{id}

---

## Order Management

GET /api/v1/admin/orders

GET /api/v1/admin/orders/{id}

PATCH /api/v1/admin/orders/{id}/status

---

## Delivery Partner Management

GET /api/v1/admin/delivery-partners

POST /api/v1/admin/delivery-partners

PUT /api/v1/admin/delivery-partners/{id}

DELETE /api/v1/admin/delivery-partners/{id}

---

## Reports

GET /api/v1/admin/reports/sales

GET /api/v1/admin/reports/customers

GET /api/v1/admin/reports/products

GET /api/v1/admin/reports/subscriptions

---

# HTTP Status Codes

| Code | Description |
|------|-------------|
| 200 | OK |
| 201 | Created |
| 400 | Bad Request |
| 401 | Unauthorized |
| 403 | Forbidden |
| 404 | Not Found |
| 409 | Conflict |
| 422 | Validation Failed |
| 500 | Internal Server Error |

---

# API Version

Current Version: **v1**

Status: **Approved for Backend Development**
