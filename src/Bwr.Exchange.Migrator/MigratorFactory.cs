using Abp;
using Abp.Castle.Logging.Log4Net;
using Abp.Dependency;
using Castle.Facilities.Logging;
using System;

namespace Bwr.Exchange.Migrator
{
    public class MigratorFactory
    {
        //public static bool Start(string dbName)
        //{
        //    using (var bootstrapper = AbpBootstrapper.Create<ExchangeMigratorModule>())
        //    {
        //        //bootstrapper.IocManager.IocContainer
        //        //    .AddFacility<LoggingFacility>(
        //        //        f => f.UseAbpLog4Net().WithConfig("log4net.config")
        //        //    );

        //        //bootstrapper.Initialize();

        //        using (var migrateExecuter = bootstrapper.IocManager.ResolveAsDisposable<ExchangeMigrateExecuter>())
        //        {
        //            var migrationSucceeded = migrateExecuter.Object.Run(dbName);

        //            return migrationSucceeded;
        //        }
        //    }
        //}
    }
}
