using System.Configuration;

namespace CapaPresentacion.Properties {
    
    
    // Esta clase le permite controlar eventos específicos en la clase de configuración:
    //  El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    //  El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    //  El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    //  El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    internal sealed partial class Settings {
        
        public Settings() {
            // // Para agregar los controladores de eventos para guardar y cambiar la configuración, quite la marca de comentario de las líneas:
            //
            this.SettingChanging += this.SettingChangingEventHandler;
            //
            //this.SettingsSaving += this.SettingsSavingEventHandler;
            //
            this.SettingsLoaded += this.SettingsLoadedEvento;
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            if(e.SettingName == "cn2")
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                if (connectionStringsSection != null)
                {
                    connectionStringsSection.ConnectionStrings["CapaPresentacion.Properties.Settings.cn"].ConnectionString = cn2;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                }
            }
        }

        private void SettingsLoadedEvento(object sender, System.Configuration.SettingsLoadedEventArgs e)
        {
            if (cn2.Length > 0)
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                if (connectionStringsSection != null)
                {
                    connectionStringsSection.ConnectionStrings["CapaPresentacion.Properties.Settings.cn"].ConnectionString = cn2;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                }
            }
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Agregar código para administrar aquí el evento SettingsSaving.
        }
    }
}
