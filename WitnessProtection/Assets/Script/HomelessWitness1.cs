using UnityEngine;

namespace Assets
{
    public class HomelessWitness : IWitness
    {
		public HomelessWitness()
        {
            this.SawApple = true;
            this.ApplePosition = new Vector2(20,30);
        }

        public bool SawApple { get; private set; }
        public Vector2 ApplePosition { get; private set; }
    }
}
