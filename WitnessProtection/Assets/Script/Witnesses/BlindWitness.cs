using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class BlindWitness : IWitness
    {
		public BlindWitness()
        {
            this.SawApple = false;
			this.ApplePosition = new Vector2(20,30);
			this.AppleSize = new Vector2(1,1);
			this.AppleCommentary = "I did not see an apple.";

			this.SawAxe = false;
			this.AxePosition = new Vector2(20,30);
			this.AxeSize = new Vector2(1,1);
			this.AxeCommentary = "I did not see an axe.";

        }

        public bool SawApple { get; private set; }
		public Vector2 ApplePosition { get; private set; }
		public Vector2 AppleSize { get; private set; }
		public string AppleCommentary { get; private set; }

		public bool SawAxe { get; private set; }
		public Vector2 AxePosition { get; private set; }
		public Vector2 AxeSize { get; private set; }
		public string AxeCommentary { get; private set; }

    }
}
