﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    class SaveList
    {
        public static void addDataToAppconfig(string appConfigString)
        {
            #region add data line to app.config
            // Open App.Config of executable
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Add an Application Setting
            //config.AppSettings.Settings.Clear();
            try
            {
                //var appSettings = ConfigurationManager.AppSettings;
                
                //string jedanRed = appSettings.Count.ToString();
                config.AppSettings.Settings.Add(fmLauncher.AppName.appNameCombo, appConfigString);
                
                // Save the configuration file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception )
            {
                
            }
            #endregion
        }
    }
}
