using UnityEngine;

namespace Assets.Script
{

    public enum ClickCommands
    {
		SwitchToDesk,
		ToDeskFromMotel,
		ToMotelFromDesk,

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
					GameState.Instance().previousSceneString = "NewsScene";
                    Application.LoadLevel("DesktopScene");
                break;
				case ClickCommands.ToDeskFromMotel:
					GameState.Instance().previousSceneString = "MainScene";
					Application.LoadLevel("DesktopScene");
				break;
				case ClickCommands.ToMotelFromDesk:
					GameState.Instance().previousSceneString = "DesktopScene";
					Application.LoadLevel("MainScene");
				break;
            }
        }

    }
}
