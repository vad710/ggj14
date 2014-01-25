using UnityEngine;

namespace Assets
{
    public interface IWitness 
    {
        bool SawApple { get; }
        Vector2 ApplePosition { get; }
    }
}
