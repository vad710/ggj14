using UnityEngine;

namespace Assets.Script
{
    public class FolderBackButton : MonoBehaviour
    {

        public GameObject OpenedFolder;

        public void OnMouseDown()
        {
            //makes the previously hidden closed folder visible again
            if (GameState.Instance().LastFolder != null)
            {
                GameState.Instance().LastFolder.SetActive(true);    
            }
            

            //hides the opened folder
            OpenedFolder.SetActive(false);
    
            //clears the witnesstoinvestigate
            GameState.Instance().WitnessToInvestigate = null;
        }
    }
}
