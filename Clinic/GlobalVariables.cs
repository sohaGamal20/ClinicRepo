using Microsoft.Extensions.Logging;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting.Compact;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    static class GlobalVariables
    {

        private static string loggedUserName;
        public static string LoggedUserName
        {
            get { return loggedUserName; }  
            set { loggedUserName = value; }
        }

        public static long loggedUserID;
        public static readonly int DiagnosisFees = 300;//kshf
        public static readonly int ConsultationFees = 50; //estshra

        public static long PatientID { get; set; }
        public static string PatientName { get; set; } =string.Empty;
        public static string PatientTitle { get; set; } = " الإسم ";

        public static string loggedUserDisplayName = "";

        public static bool ShowTabs = false;

        public static Serilog.ILogger initializeLogger()
        {
           return new LoggerConfiguration()
         .MinimumLevel.Information()
         .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
         .WriteTo.File(new CompactJsonFormatter(), @"D:\Clinic_System_Logs\log-.txt",shared:true, rollingInterval: RollingInterval.Day)
         .CreateLogger();
        }

        public static void LogCurrentUSer(string formName)
        {
            var logger = initializeLogger();
            logger.Information("***** "+formName+" *****");
            logger.Information("Logged user = "+GlobalVariables.loggedUserName);

        }

    }
}
