using UnityEngine;

namespace Assets.Script
{
    public interface IWitness 
    {
        bool SawApple { get; }
		Vector2 ApplePosition { get; }
		Vector2 AppleSize { get; }
        string AppleCommentary { get; }

		bool SawAxe { get; }
		Vector2 AxePosition { get; }
		Vector2 AxeSize { get; }
		string AxeCommentary { get; }

    }
}
