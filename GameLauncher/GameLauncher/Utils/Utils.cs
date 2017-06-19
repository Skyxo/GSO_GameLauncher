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
        }

        /// <summary>
        /// Dateityp prüfen
        /// </summary>
        /// <param name="pfad">Pfad zur Datei</param>
        public static void MimeCheck(string pfad)
        {
            if (!pfad.EndsWith(".exe") && !pfad.EndsWith(".msi"))
            {
                throw new ArgumentException("Angegebener Pfad ungültig");
            }
        }

        /// <summary>
        /// Installationsdatum des Programms finden
        /// </summary>
        /// <param name="pfad"></param>
        /// <returns></returns>
        public static DateTime InstallationsDatum(string pfad)
        {
            PfadCheck(pfad);

            FileInfo fileInfo = new FileInfo(pfad);

            DateTime creationTime = fileInfo.CreationTime;

            return creationTime;
        }

    }
}
