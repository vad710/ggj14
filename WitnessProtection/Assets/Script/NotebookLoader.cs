using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script
{
    public class NotebookLoader : MonoBehaviour {

        // Use this for initialization
        public void Start ()
        {
            Debug.Log("Loading Notebook!");

            var notebook = GameState.Instance().DetectiveNotebook;

            var suspects = notebook.GetSuspects();

            var suspectList = new StringBuilder();

            foreach (var suspect in suspects)
            {
                suspectList.AppendLine(suspect);
            }

            var guiTextObject = this.GetComponentsInChildren<GUIText>().First(g => g.name == "SuspectNames");

            guiTextObject.text = suspectList.ToString();

        }
	

    }
}
