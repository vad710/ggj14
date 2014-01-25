using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class HouseKeeperWitness : IWitness
    {
        public HouseKeeperWitness()
        {
            this.SawApple = true;
            this.ApplePosition = new Vector2(20,30);

            this.AppleCommentary = "I saw an apple in the room";
        }

        public bool SawApple { get; private set; }
        public Vector2 ApplePosition { get; private set; }
        public string AppleCommentary { get; private set; }
    }
}
