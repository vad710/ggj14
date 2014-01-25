using UnityEngine;

namespace Assets.Script
{
    public class NotebookLoader : MonoBehaviour {

        // Use this for initialization
        void Start ()
        {
            var notebook = GameState.Instance().DetectiveNotebook;

            var suspects = notebook.GetSuspects();

            foreach (var suspect in suspects)
            {
                
            }

        }
	
        // Update is called once per frame
        void Update () {
	
        }
    }
}
