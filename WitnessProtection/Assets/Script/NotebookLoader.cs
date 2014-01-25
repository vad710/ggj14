using System.Text;
using UnityEngine;

namespace Assets.Script
{
    public class NotebookLoader : MonoBehaviour {

        // Use this for initialization
        void Start ()
        {
            var notebook = GameState.Instance().DetectiveNotebook;

            var suspects = notebook.GetSuspects();

            var suspectList = new StringBuilder();

            foreach (var suspect in suspects)
            {
                suspectList.AppendLine(suspect);
            }
        }
	
        // Update is called once per frame
        void Update () {
	
        }
    }
}
