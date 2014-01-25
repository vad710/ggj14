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

		bool SawBlind1 { get; }
		Vector2 Blind1Position { get; }
		Vector2 Blind1Size { get; }
		string Blind1Commentary { get; }

		bool SawBlind2 { get; }
		Vector2 Blind2Position { get; }
		Vector2 Blind2Size { get; }
		string Blind2Commentary { get; }

    }
}
