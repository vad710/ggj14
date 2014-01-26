using UnityEngine;

namespace Assets.Script.Witnesses
{
	public class DannyWitness : IWitness
	{

	    // Use this for initialization
	    public DannyWitness ()
	    {
	        this.WhoAmI = WitnessNames.DannyName;

		    this.SawGun = true;
		    this.GunPosition = new Vector2(-.26f, -2.3f);
		    this.GunSize = new Vector2(1,1);
		    this.GunCommentary = "My mommy tells me never to play with guns.";
		
		    this.SawPurse = false;
		    this.PursePosition = new Vector2(-5.92f, -.25f);
		    this.PurseSize = new Vector2(1,1);
		    this.PurseCommentary = "";
		
		    this.SawToy = true;
		    this.ToyPosition = new Vector2(4.57f,-4.0f);
		    this.ToySize = new Vector2(1,1);
			this.ToyCommentary = "That’s my favorite toy! Benny wouldn’t give it back so I grabbed his new one!";
		
		    this.SawHole = false;
		    this.HolePosition = new Vector2(-1.76f,3.37f);
		    this.HoleSize = new Vector2(1,1);
		    this.HoleCommentary = "";
		
		    this.SawJacket = false;
		    this.JacketPosition = new Vector2(-5.12f,-3.75f);
		    this.JacketSize = new Vector2(1,1);
		    this.JacketCommentary = "";

			this.LeftFolderText = "\"(Sniff) Benny was nice! (Sniff) His mom really was nice too! I don’t have many friends here so having a buddy is nice. I spend a lot of time with Chavez, but my mommy doesn’t like that a talk to him… Benny showed me his room and his toys! I really liked them and want my mommy to get them for me! Danny’s so lucky he has the coolest toys. Chavez said one day he’ll get me one’s just like Danny’s! He promised!\"";
			// this.RightFolderText = Danny doesn't talk much but he's out there "killin'" it ;)
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
