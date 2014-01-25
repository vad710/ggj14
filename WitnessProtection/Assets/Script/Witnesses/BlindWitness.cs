using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class BlindWitness : IWitness
    {
		public BlindWitness()
        {
            this.SawApple = false;
            this.ApplePosition = new Vector2(20,30);

		    this.AppleCommentary = "I did not see an apple.";
        }

        public bool SawApple { get; private set; }
        public Vector2 ApplePosition { get; private set; }
        public string AppleCommentary { get; private set; }
    }
}
