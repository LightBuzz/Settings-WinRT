using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace LightBuzz.Settings
{
    /// <summary>
    /// Provides access to the application settings.
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Gets the local application settings.
        /// </summary>
        public static ApplicationDataContainer Local
        {
            get { return ApplicationData.Current.LocalSettings; }
        }

        /// <summary>
        /// Gets the roaming application settings.
        /// </summary>
        public static ApplicationDataContainer Roaming
        {
            get { return ApplicationData.Current.RoamingSettings; }
        }
    }
}
