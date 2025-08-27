# Database Backup Service

A Windows Service for automating SQL Server database backups.
The service creates periodic full backups of a specified database, saves them in a configured folder with timestamped filenames, and logs all activities for monitoring and troubleshooting.

---

## Features

* **Automated Backups**: Creates full backups at regular intervals.
* **Dynamic Configuration**: Fully configurable through `App.config`.
* **Logging**: Logs service activities, successes, and errors to a file.
* **Debugging Mode**: Run as a console app for development and testing.
* **Deployment Ready**: Supports installation/uninstallation using `InstallUtil`.

---

## Core Functionalities

   * Perform full backup of SQL Server databases.
   * Save backups with timestamped names.
   * Configurable via `App.config`:

     * Database connection string.
     * Backup folder path.
     * Log folder path.
     * Backup interval (minutes).
   * Graceful error handling with detailed logging.

## Logging and Monitoring

   * Logs:

     * Service start and stop events.
     * Successful backups with file paths.
     * Errors during backup or connection.

   **Sample Log Output**:

   ```
   [2024-12-16 14:00:00] Service Started.
   [2024-12-16 14:10:00] Database backup successful: C:\DatabaseBackups\Backup_20241216_141000.bak
   [2024-12-16 15:10:00] Error during backup: Network-related or instance-specific error occurred while establishing a connection to SQL Server.
   [2024-12-16 16:00:00] Service Stopped.
   ```

## Debugging in Console Mode

   * Run interactively to view logs in the console.
   * Stop service manually in debug mode.
   * Uses `Environment.UserInteractive`.

## Deployment Requirements

   * Includes `ProjectInstaller.cs`.
   * Service name: `DatabaseBackupService`.
   * Startup type: **Automatic**.
   * Service dependencies:

     * `MSSQLSERVER` (or named instance).
     * `RpcSs` (Remote Procedure Call).
     * `EventLog`.

## Testing Scenarios

   * Backup success, connection failure, service recovery, console debugging.

---

## App.config

Configuration is stored in `App.config` under `<appSettings>`.

**Example**:

```xml
<configuration>
  <appSettings>
    <add key="ConnectionString" value="Server=YOUR_SERVER;Database=YOUR_DATABASE;Integrated Security=True;" />
    <add key="BackupFolder" value="C:\DatabaseBackups" />
    <add key="LogFolder" value="C:\DatabaseBackups\Logs" />
    <add key="BackupIntervalMinutes" value="60" />
  </appSettings>
</configuration>
```

---

## Build Instructions

1. Open the project in **Visual Studio**.
2. Select **Release** mode from the toolbar.
3. Build the project (`Ctrl + Shift + B`).
4. The compiled files will be available in:

   ```
   /bin/Release
   ```

---

## Deployment Instructions

### Install the Service

```bash
InstallUtil.exe DatabaseBackupService.exe
```

### Start the Service

```bash
net start DatabaseBackupService
```

### Stop the Service

```bash
net stop DatabaseBackupService
```

### Uninstall the Service

```bash
InstallUtil.exe /u DatabaseBackupService.exe
```

---

## Additional Notes

* The service will automatically create backup and log directories if they don’t exist.
* Exception handling ensures detailed error messages are logged.
* Scalable to handle large databases with configurable intervals.

---

This project provides practical experience in building, deploying, and managing **Windows Services** with real-world database backup operations. 