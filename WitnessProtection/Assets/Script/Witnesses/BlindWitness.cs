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

			this.SawBlind1 = true;
			this.Blind1Position = new Vector2(-3.5f,-1.1f);
			this.Blind1Size = new Vector2(.3f,.3f);
			this.Blind1Commentary = "I heard something quiet.";

			this.SawBlind2 = true;
			this.Blind2Position = new Vector2(4.7f,3.5f);
			this.Blind2Size = new Vector2(1,1);
			this.Blind2Commentary = "I heard something cool.";

        }

        public bool SawApple { get; private set; }
		public Vector2 ApplePosition { get; private set; }
		public Vector2 AppleSize { get; private set; }
		public string AppleCommentary { get; private set; }

		public bool SawAxe { get; private set; }
		public Vector2 AxePosition { get; private set; }
		public Vector2 AxeSize { get; private set; }
		public string AxeCommentary { get; private set; }

		public bool SawBlind1 { get; private set; }
		public Vector2 Blind1Position { get; private set; }
		public Vector2 Blind1Size { get; private set; }
		public string Blind1Commentary { get; private set; }

		public bool SawBlind2 { get; private set; }
		public Vector2 Blind2Position { get; private set; }
		public Vector2 Blind2Size { get; private set; }
		public string Blind2Commentary { get; private set; }

    }
}
