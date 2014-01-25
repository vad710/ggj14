using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class HomelessWitness : IWitness
    {
		public HomelessWitness()
        {
            this.SawApple = true;
            this.ApplePosition = new Vector2(20,30);

		    this.AppleCommentary = "Apples are delicious.";
        }

        public bool SawApple { get; private set; }
        public Vector2 ApplePosition { get; private set; }
        public string AppleCommentary { get; private set; }
    }
}
