using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Utils
{
    static class Utils
    {

        /// <summary>
        /// Pfad prüfen
        /// </summary>
        /// <param name="pfad">Der Pfad zur .exe-Datei</param>
        public static void PfadCheck(string pfad)
        {
            if (!File.Exists(pfad))
            {
                throw new ArgumentException("Pfad des Spiels nicht gefunden");
            }

            if (!pfad.EndsWith(".exe") || !pfad.EndsWith(".msi"))
            {
                throw new ArgumentException("Angegebener Pfad ungültig");
            }
        }

        public static DateTime InstallationsDatum(string pfad)
        {
            PfadCheck(pfad);

            FileInfo fileInfo = new FileInfo(pfad);

            DateTime creationTime = fileInfo.CreationTime;

            return creationTime;
        }

    }
}
