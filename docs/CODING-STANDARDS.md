# Coding Standards

Version: 1.0

Project Name: White Gold

---

# 1. General Principles

- Follow Clean Architecture
- Follow SOLID Principles
- Write clean, readable, and maintainable code
- Avoid duplicate code (DRY)
- Keep methods small and focused
- Use meaningful names for classes, methods, and variables

---

# 2. C# Coding Standards

## Naming

- Classes → PascalCase
- Methods → PascalCase
- Properties → PascalCase
- Variables → camelCase
- Private fields → _camelCase
- Interfaces → Prefix with I

Example:

```csharp
public class ProductService
{
    private readonly IProductRepository _productRepository;
}
```

---

## Async Methods

Always end asynchronous methods with **Async**.

Example:

```csharp
GetProductsAsync()
CreateOrderAsync()
```

---

# 3. React Native Standards

- Use TypeScript
- Use Functional Components
- Use React Hooks
- Keep components reusable
- Separate UI and business logic

---

# 4. Folder Structure

Each feature should have:

- Components
- Screens
- Services
- Models
- Utils

---

# 5. Git Branch Naming

Use the following format:

feature/login

feature/orders

feature/payment

bugfix/cart

hotfix/payment

---

# 6. Commit Message Format

Use Conventional Commits.

Examples:

feat: add login api

fix: resolve payment issue

docs: update architecture

refactor: optimize order service

test: add unit tests

style: improve formatting

---

# 7. Code Review Checklist

Before committing code, ensure:

- Code builds successfully
- No compiler warnings
- No unused variables
- Proper error handling
- API validation completed
- Unit tests passed (where applicable)

---

# 8. Documentation

Every major feature should include:

- API documentation
- Database changes
- Business logic explanation
- Release notes (if applicable)
