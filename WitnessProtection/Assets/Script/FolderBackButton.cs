using UnityEngine;

namespace Assets.Script
{
    public class FolderBackButton : MonoBehaviour
    {

        public GameObject OpenedFolder;

        public void OnMouseDown()
        {
            //Makes all closed folders visible


            //hides the opened folder
            OpenedFolder.SetActive(false);
    
            //clears the witnesstoinvestigate
            GameState.Instance().WitnessToInvestigate = null;
        }
    }
}
