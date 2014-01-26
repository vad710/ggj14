using Assets.Script;
using UnityEngine;
using System.Collections;

public class UnlockFolders : MonoBehaviour
{

    public GameObject CalebFolder;
    public GameObject EliFolder;
    public GameObject DannyFolder;

	// Use this for initialization
	public void Start ()
	{
	    var gamestate = GameState.Instance();

	    CalebFolder.SetActive(gamestate.CalebUnlocked);
        EliFolder.SetActive(gamestate.EliUnlocked);
        DannyFolder.SetActive(gamestate.DannyUnlocked);
	}
}
