using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class HouseKeeperWitness : IWitness
    {
        public HouseKeeperWitness()
        {
			this.SawApple = true;
			this.ApplePosition = new Vector2(20,30);
			this.AppleSize = new Vector2(1,1);
			this.AppleCommentary = "The apple looked dirty.";
			
			this.SawAxe = true;
			this.AxePosition = new Vector2(20,30);
			this.AxeSize = new Vector2(1,1);
			this.AxeCommentary = "The axe looked dirty.";
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
