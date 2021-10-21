using System.Runtime.InteropServices;

namespace SecurityAssistant
{
    public class Screen
    {
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
    }
}
