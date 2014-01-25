using UnityEngine;

namespace Assets.Script
{
    public enum ClickCommands
    {
        SwitchToDesk,
        SwitchToFolder,
        BeAwesome,

    }

    public class Clickable : MonoBehaviour {
        
        public string onMouseOver;
        public string onMouseExit;

        public ClickCommands OnClickCommand; 
        


        public void OnMouseOver(){
            if(onMouseOver == null){return;}
        }
	
        public void OnMouseExit(){
            if(onMouseExit == null){return;}
        }
	
        public void OnMouseDown()
        {
            Debug.Log(string.Format("OnMouseDown {0}", this.OnClickCommand));
            
            switch (OnClickCommand)
            {
                case ClickCommands.SwitchToDesk:
                    GameState.Instance().SampleData = "I just came from the news scene!";
                    Application.LoadLevel("DesktopScene");
                break;

            }
        }

    }
}
