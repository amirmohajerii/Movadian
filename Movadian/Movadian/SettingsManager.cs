using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace Movadian
{
    public static class SettingsManager
    {
        private static readonly string FilePath = Path.Combine(Application.StartupPath, "settings.json");

        public static void Save(UserSettings settings)
        {
            var json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static UserSettings Load()
        {
            if (!File.Exists(FilePath))
                return new UserSettings();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<UserSettings>(json);
        }
    }
}
