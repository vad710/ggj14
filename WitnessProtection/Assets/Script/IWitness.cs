using UnityEngine;

namespace Assets.Script
{
    public interface IWitness 
    {
		string WhoAmI { get; }

        bool SawGun { get; }
		Vector2 GunPosition { get; }
		Vector2 GunSize { get; }
        string GunCommentary { get; }

		bool SawPurse { get; }
		Vector2 PursePosition { get; }
		Vector2 PurseSize { get; }
		string PurseCommentary { get; }

		bool SawToy { get; }
		Vector2 ToyPosition { get; }
		Vector2 ToySize { get; }
		string ToyCommentary { get; }

		bool SawHole { get; }
		Vector2 HolePosition { get; }
		Vector2 HoleSize { get; }
		string HoleCommentary { get; }

		bool SawJacket { get; }
		Vector2 JacketPosition { get; }
		Vector2 JacketSize { get; }
		string JacketCommentary { get; }

        string LeftFolderText { get; set; }

	}
}
