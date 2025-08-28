# Zaboon – Client Management System for Institutions

A Windows desktop solution (WinForms) that helps institutions manage Clients, Services, Working Hours, and Reservations. Zaboon streamlines front-desk operations, reduces on‑site congestion with time slots, and provides clear dashboards for workload and performance.

## Objectives
- Centralize client data and service requests.
- Reduce queues through scheduled reservations and defined working hours.
- Equip staff with actionable dashboards and quick search.
- Keep the system extensible for future web/mobile front‑ends.

## Key Features
- Users Management
  - Two user types: Clients and Employees.
  - Add/Edit/Delete users, activate/deactivate accounts.
  - Quick search and card-based user views.
- Services & Working Hours
  - Define services (name, description, fees, active status).
  - Configure service hours per day of week and time range.
  - Prevent overlapping time slots.
- Reservations
  - Book reservations (Client + Service + ServiceHour + Date).
  - Status tracking: New, Completed, Cancelled.
  - Summaries and counters (today, month, year).
- Dashboards
  - Users KPIs: totals, active/inactive, clients vs employees.
  - Reservations KPIs: daily/monthly/yearly totals, breakdowns, top services by demand.

## Main Modules
- Users: list, search, add/edit, quick delete.
- Services: list, add/edit, activate/deactivate.
- Service Hours: per‑service schedules and slot management.
- Reservations: list, add/edit, status management.
- Dashboards: users and reservations KPIs (including top services).

## Benefits
- Faster service delivery and less crowding at counters.
- Clear visibility for managers via KPIs and trends.
- Consistent data model ready for future integrations (web/mobile/API).
- Modern, clean WinForms UI with reusable controls.

## Technology
- UI: WinForms with Guna.UI2 controls.
- Data: SQL Server.
- Layers: UI + Business Layer (BL) + Data Access Layer (DAL).
- Safe, parameterized database access.

## Getting Started
1. Import the bundled database
   - A ready database copy is included in the project.
   - Restore via SQL Server Management Studio (Databases > Restore Database…).
2. Update the connection string
   - In App.config of the WinForms project, point to your SQL Server instance and the restored database.
3. Packages
   - Ensure NuGet packages are restored (including Guna.UI2.WinForms).
4. Build and Run
   - Build the solution and run the WinForms app.

Note: If UsersTypes are not already seeded, add Client and Employee types (IDs commonly 1 and 2).

## License & Contact
- License: add your preferred license (e.g., MIT/Apache/Proprietary).
- For questions or feature requests, contact the maintainer or open an issue.
