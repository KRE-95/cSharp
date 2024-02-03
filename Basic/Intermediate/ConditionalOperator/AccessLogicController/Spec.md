## Business Rules

1. If the user is a Super Admin (Admin with level greater than 55), output: "Welcome, Super Admin user."
2. If the user is an Admin with level 55 or less, output: "Welcome, Admin user."
3. If the user is a Manager with level 20 or greater, output: "Contact an Admin for access."
4. If the user is a Manager with level less than 20, output: "You do not have sufficient privileges."
5. If the user is neither an Admin nor a Manager, output: "You do not have sufficient privileges."

## Variables

- `permission`: String with user roles (e.g., "Admin|Manager")
- `level`: Integer denoting the user's career level

## Implementation Guide

To implement these rules, use the `Contains()` helper method with the `permission` string. This method checks if the string contains a specific substring. For instance, `permission.Contains("Admin")` returns true if the user has Admin permissions.

### Conditions for Each Rule

1. Super Admin:
   - If `permission` contains "Admin" and `level` is greater than 55.
   
2. Admin:
   - If `permission` contains "Admin" and `level` is 55 or less.

3. Manager with access:
   - If `permission` contains "Manager" and `level` is 20 or greater.

4. Manager without access:
   - If `permission` contains "Manager" and `level` is less than 20.

5. Other roles:
   - If `permission` does not contain "Admin" and does not contain "Manager".

Ensure to incorporate these conditions within your code branches to output the corresponding messages based on the user's permissions and career level.
