using System.Collections.Generic;

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
    }

    public class FrcSettings
    {
        public string Organization { get; set; }
        public List<string> SelectedEntities { get; set; }
    }
}