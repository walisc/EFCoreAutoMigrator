using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CentridNet.EFCoreAutoMigrator.MigrationContexts{

    class MySQLMigrations : MigrationsProvider
    {
        public MySQLMigrations(DBMigratorProps dbMigratorProps, MigrationScriptExecutor migrationScriptExecutor) : base(dbMigratorProps, migrationScriptExecutor){}
        protected override void EnsureMigrateTablesExist()
        {
            throw new System.NotImplementedException();
        }

        protected override void EnsureSnapshotLimitNotReached()
        {
            throw new NotImplementedException();
        }

        protected override DBMigratorTable GetLastMigrationRecord()
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateMigrationTables(byte[] snapshotData)
        {
            throw new System.NotImplementedException();
        }
    }
}