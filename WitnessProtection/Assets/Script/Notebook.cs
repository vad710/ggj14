using System.Collections.Generic;

namespace Assets.Script
{
    public class Notebook
    {
        private readonly List<string> _suspects = new List<string>(); 
        private readonly List<string> _weapons = new List<string>();

        public void AddSuspect(string suspect)
        {
            _suspects.Add(suspect);
        }

        public void AddWeapon(string weapon)
        {
            _weapons.Add(weapon);
        }

        public string[] GetSuspects()
        {
            return _suspects.ToArray();
        }
    }
}
