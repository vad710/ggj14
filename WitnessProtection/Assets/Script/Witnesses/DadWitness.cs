using UnityEngine;

namespace Assets.Script.Witnesses
{
	public class DadWitness : IWitness
	{
	    // Use this for initialization
	    public DadWitness () 
        {
            this.WhoAmI = WitnessNames.CalebName;

			
		    this.SawGun = true;
		    this.GunPosition = new Vector2(-.26f, -2.3f);
		    this.GunSize = new Vector2(1,1);
		    this.GunCommentary = "I can't believe she stole my gun.";
		
		    this.SawPurse = false;
		    this.PursePosition = new Vector2(-5.92f, -.25f);
		    this.PurseSize = new Vector2(1,1);
		    this.PurseCommentary = "";
		
		    this.SawToy = false;
		    this.ToyPosition = new Vector2(4.57f,-4.0f);
		    this.ToySize = new Vector2(1,1);
		    this.ToyCommentary = "";
		
		    this.SawHole = true;
		    this.HolePosition = new Vector2(-1.76f,3.37f);
		    this.HoleSize = new Vector2(1,1);
			this.HoleCommentary = "That's where I shoved that hobo/thief’s face in.";

		    this.SawJacket = true;
		    this.JacketPosition = new Vector2(-5.12f,-3.75f);
		    this.JacketSize = new Vector2(1,1);
		    this.JacketCommentary = "That's the jacket I got Olivia for her birthday";

			this.LeftFolderText = "\"That B!tch! What, you think I would kill my own son!? I came back for him ONLY. She can leave or rot for all I care. But I come all the way here only to find my son dead!?” ...words can’t describe...my anger. I may not be the best husband, best person for that matter, but he was all that was good in me and I wanted to be a good father damnit. When I found out where she was and got here I saw someone break into their room, 14B. The door was unlocked! That dumb b!tch, she puts our only kid in danger like that and knows no better!?";
			this.RightFolderText = "By the time I got there.. *sniff*.. a child killed for no reason at all..caught in the middle of.. *sniff* THAT SON OF A B!TCH HOBO!..I tried to get him, we fought. I messed him up good, smashed him into wall, broke his face with a lamp. He still got a way. That sneaky bastard.\"";
	    }

        public string WhoAmI { get; private set; }

	    public bool SawGun { get; private set; }
	    public Vector2 GunPosition { get; private set; }
	    public Vector2 GunSize { get; private set; }
	    public string GunCommentary { get; private set; }
	
	    public bool SawPurse { get; private set; }
	    public Vector2 PursePosition { get; private set; }
	    public Vector2 PurseSize { get; private set; }
	    public string PurseCommentary { get; private set; }
	
	    public bool SawToy { get; private set; }
	    public Vector2 ToyPosition { get; private set; }
	    public Vector2 ToySize { get; private set; }
	    public string ToyCommentary { get; private set; }
	
	    public bool SawHole { get; private set; }
	    public Vector2 HolePosition { get; private set; }
	    public Vector2 HoleSize { get; private set; }
	    public string HoleCommentary { get; private set; }
	
	    public bool SawJacket { get; private set; }
	    public Vector2 JacketPosition { get; private set; }
	    public Vector2 JacketSize { get; private set; }
	    public string JacketCommentary { get; private set; }
	    public string LeftFolderText { get; set; }
	    public string RightFolderText { get; set; }
	}
}
