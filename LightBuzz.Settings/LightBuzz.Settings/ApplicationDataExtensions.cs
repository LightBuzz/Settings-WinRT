using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace LightBuzz.Settings
{
    /// <summary>
    /// Provides some extension methods for setting, getting and deleting application data.
    /// </summary>
    public static class ApplicationDataExtensions
    {
        /// <summary>
        /// Inserts the specified value to the specified settings key, or creates a new pair.
        /// </summary>
        /// <typeparam name="T">A primitive type.</typeparam>
        /// <param name="key">The name of the setting.</param>
        /// <param name="value">The content of the setting.</param>
        public static void Set<T>(this ApplicationDataContainer container, string key, T value)
        {
            container.Values[key] = value;
        }

        /// <summary>
        /// Retrieves the contents of the specified setting key.
        /// </summary>
        /// <typeparam name="T">A primitive type.</typeparam>
        /// <param name="key">The name of the setting.</param>
        /// <returns>The content of the spcified setting.</returns>
        public static T Get<T>(this ApplicationDataContainer container, string key)
        {
            if (container.Values.Keys.Contains(key))
            {
                return (T)container.Values[key];
            }

            T value = default(T);

            container.Set<T>(key, value);

            return value;
        }

        /// <summary>
        /// Deletes the specified setting.
        /// </summary>
        /// <param name="key">The name of the setting.</param>
        public static void Remove(this ApplicationDataContainer container, string key)
        {
            container.Values.Remove(key);
        }
    }
}
