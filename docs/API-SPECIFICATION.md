# White Gold API Specification

Version: 1.0

---

# Overview

Base URL

/api/v1

Authentication

JWT Bearer Token

Content Type

application/json

Response Format

JSON

---

# Standard Response

## Success

```json
{
    "success": true,
    "message": "Request completed successfully.",
    "data": {}
}
```

## Error

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

POST

/api/v1/auth/register

Authentication Required

No

Request

```json
{
    "fullName": "John Doe",
    "email": "john@example.com",
    "phone": "9876543210",
    "password": "Password@123"
}
```

Response

```json
{
    "success": true,
    "message": "Registration successful."
}
```

---

## Login

POST

/api/v1/auth/login

Authentication Required

No

Request

```json
{
    "email": "john@example.com",
    "password": "Password@123"
}
```

Response

```json
{
    "token":"JWT_TOKEN",
    "refreshToken":"REFRESH_TOKEN",
    "expiresIn":3600
}
```

---

## Logout

POST

/api/v1/auth/logout

Authentication Required

Yes

Response

```json
{
    "success": true
}
```

---

## Refresh Token

POST

/api/v1/auth/refresh

Authentication Required

No

Request

```json
{
    "refreshToken":"TOKEN"
}
```

Response

```json
{
    "token":"NEW_TOKEN"
}
```

---
