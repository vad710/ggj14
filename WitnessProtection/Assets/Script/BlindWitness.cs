using UnityEngine;

namespace Assets
{
    public class BlindWitness : IWitness
    {
		public BlindWitness()
        {
            this.SawApple = false;
            this.ApplePosition = new Vector2(20,30);
        }

        public bool SawApple { get; private set; }
        public Vector2 ApplePosition { get; private set; }
    }
}
