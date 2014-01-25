using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class MotherWitness : IWitness
    {
		public MotherWitness()
        {
            this.SawApple = true;
            this.ApplePosition = new Vector2(20,30);

		    this.AppleCommentary = "I found the apple to be delicious.";
        }

        public bool SawApple { get; private set; }
        public Vector2 ApplePosition { get; private set; }
        public string AppleCommentary { get; private set; }
    }
}
