//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameLauncher.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spiele
    {
        public int SpielID { get; set; }
        public string Titel { get; set; }
        public System.DateTime InstallationsDatum { get; set; }
        public Nullable<System.DateTime> ZuletztGespielt { get; set; }
        public string InstallationsPfad { get; set; }
        public string Kategorie { get; set; }
        public string Publisher { get; set; }
        public int USK { get; set; }
    }
}