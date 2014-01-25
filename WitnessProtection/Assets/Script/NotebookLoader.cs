using System.Text;
using Assets.Script;
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

            var guiTextObjects = this.GetComponentsInChildren<GUIText>();

            foreach (var guiTextObject in guiTextObjects)
            {
                if (guiTextObject.name == "SuspectNames")
                {
                    guiTextObject.text = suspectList.ToString();
                }
            }
        }
    }
}
