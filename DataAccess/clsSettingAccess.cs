using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DatabaseSetting
{
    public static class clsSettingAccess
    {
        public static string ConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=123456;";
        public static string SourceApp = "DVLD";
        public static void CreateEventLog()
        {
            EventLog.CreateEventSource(SourceApp, "Application");
        }
        public static void AddEventLog(string Message)
        {
            if (!EventLog.SourceExists(SourceApp))
            {
                CreateEventLog();
            }
            EventLog.WriteEntry(SourceApp, Message, EventLogEntryType.Error);
        }
        public static void AddUserLoginEventLog(string Message)
        {
            if (!EventLog.SourceExists(SourceApp))
            {
                CreateEventLog();
            }
            EventLog.WriteEntry(SourceApp, Message, EventLogEntryType.Information);
        }
    }
   
}
