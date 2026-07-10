# Gym Management System (C# .NET & SQL Server Desktop Application)

---

# Project Description

The Gym Management System is a robust desktop application engineered using C# (.NET Framework) and backed by Microsoft SQL Server. Designed as a comprehensive administrative solution for fitness centers, the system splits business operations between two core modules: **Managers** and **Receptionists**. 

The system provides persistent storage for all records, handles advanced relational operations via foreign key mappings, automatically updates live inventory balances during itemized transactions, and incorporates a validation system to enforce operational schedules and prevent trainer double-bookings.

---

# Features

## 1. Role-Based Authentication & Split UI Navigation
- Fully functional Login and Registration interfaces routing users based on strict authorization flags.
- **Dynamic Interface Layouts:** Implements an asymmetric window layout featuring a sticky workspace navigation sidebar on the left and contextual action canvases on the right.
- Separates operational privileges between roles:
  - **Managers:** Full administrative oversight over all tables, including receptionist staff management and reporting features.
  - **Receptionists:** Guarded execution parameters focused on customer-facing workflows, inventory operations, and schedule coordination.

---

## 2. Comprehensive Gym Entity Management (CRUD)
Provides scalable Create, Read, Update, and Delete operations alongside flexible lookup search filters across all structural gym modules:
- **Receptionists:** (Manager-exclusive access) Tracks ID, name, contact info, address, and shift status (Full-Time/Part-Time).
- **Trainers:** Details records including profile configurations and schedule availabilities to map personal training hours.
- **Members:** Stores personal data files enabling unified record checking and registration pipelines.
- **Training Sessions:** Classifies specialized programs by Session ID, name, structural category, and baseline pricing.

---

## 3. Product Inventory & Sales Engine
- Tracks physical inventory including supplements, protein shakes, protein bars, and equipment.
- **Automated Balancing Matrix:** Features custom "Order Product" and "Sell Product" actions. When products are bought or sold, the system triggers live transactional modifications, instantly recalculating and updating fields for `Stock Units`, `Ordered Units`, and `Sold Units` directly inside SQL Server.

---

## 4. Clash-Insulated Appointment Scheduler
- Coordinates member training sessions with individual trainers across accurate dates and times.
- **Active Conflict Prevention Engine:** Before processing an appointment entry, the system verifies trainer allocation logs. If a trainer is double-booked, it halts serialization, throws a defensive error flag, and forces the user to reschedule or change the trainer asset.

---

## 5. Administrative Report Generator
- **Manager-Exclusive Reporting Workspace:** Extracts consolidated performance audits from tables.
- Compiles custom records regarding receptionists, trainers, active member registrations, financial metrics from training selections, and point-of-sale inventory histories.

---

# Programming & Database Concepts Used

This enterprise desktop prototype illustrates advanced Windows Programming structures and relational concepts:

- ✔ **Event-Driven UI Programming:** Developed using Visual Studio Windows Forms layout components, utilizing customized naming conventions across all controls and inputs.
- ✔ **Relational Database Design (RDBMS):** Enforces strict primary/foreign key hierarchies between structural entities to maintain absolute system accountability and database normalization.
- ✔ **Many-to-Many Bridge Solutions:** Employs explicit intermediate junction tables to cleanly map overlapping real-world associations (e.g., matching multiple Trainers to Training Sessions, or handling complex Member-to-Product point-of-sale invoices).
- ✔ **Persistent SQL Pipelines:** Driven by ADO.NET commands or Entity Framework structures to safely execute queries, parameterized updates, and atomic data commits within Microsoft SQL Server.

---

# Relational Database Mapping

The relational schema maps variables and enforces historical tracing across the gym environment:

| Entity Table | Key Primary Attribute | Relational Associations / Foreign Keys |
| :--- | :--- | :--- |
| **Manager** | `Manager_ID` | Global overseer key mapped for entity entry tracing. |
| **Receptionist** | `Receptionist_ID` | Connected to `Manager_ID` (Supervising entity). |
| **Trainer** | `Trainer_ID` | Linked to both supervising Managers and Receptionists. |
| **Member** | `Member_ID` | Tracks managing staff identities via foreign key paths. |
| **Training Session**| `Session_ID` | Managed via operational administrative tracking IDs. |
| **Product** | `Product_ID` | Logs categorical identifiers alongside inventory metrics. |
| **Appointment** | `Appointment_ID` | Unites `Session_ID`, `Trainer_ID`, and `Member_ID` references. |

---

# Operational Validation & Guardrails

To protect against system degradation and database anomalies, the application enforces the following defensive checks:
- **Null & Blank Space Rejections:** Evaluates input fields upon button submit flags, blocking incomplete entries.
- **Mismatched Type Boundaries:** Captures format variances (e.g., ensuring selling prices or numeric phone lengths hold matching data types before serialization).
- **Stockout Prevention:** Rejects transactions when trying to log sales entries that exceed available `Stock Units`.
- **Double-Booking Prevention:** Intercepts overlapping time records for trainers, issuing a pop-up prompt to suggest an alternative schedule or trainer.
- **Logout Safetynet:** Implements secondary modal loops requiring unambiguous confirmation choices (`YES` / `NO`) before clearing background sessions.
