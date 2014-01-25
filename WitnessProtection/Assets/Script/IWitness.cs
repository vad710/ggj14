using UnityEngine;

namespace Assets.Script
{
    public interface IWitness 
    {
        bool SawApple { get; }
        Vector2 ApplePosition { get; }

        string AppleCommentary { get; }
    }
}
