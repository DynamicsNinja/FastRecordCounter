using System.Collections.Generic;
using System.Linq;

namespace Fic.XTB.FastRecordCounter.Model
{
    public class Settings
    {
        public Settings()
        {
            FrcSettings = new List<FrcSettings>();
        }

        public string LastUsedOrganizationWebappUrl { get; set; }
        public List<FrcSettings> FrcSettings { get; set; }

        public FrcSettings GetByOrgId(string orgId)
        {
            return FrcSettings.FirstOrDefault(s => s.Organization == orgId);
        }
    }

    public class FrcSettings
    {
        public FrcSettings(string orgid)
        {
            Organization = orgid;
            BatchSize = 100;
            SelectedEntities = new List<string>();
        }

        public FrcSettings()
        {
            BatchSize = 100;
            SelectedEntities = new List<string>();
        }

        public string Organization { get; set; }
        public List<string> SelectedEntities { get; set; }
        public int BatchSize { get; set; }
    }
}