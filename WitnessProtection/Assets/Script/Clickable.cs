using UnityEngine;

namespace Assets.Script
{

    public enum ClickCommands
    {
		SwitchToDesk,
		ToDeskFromMotel,
		ToMotelFromDesk,
		ToTV,
		ToSolve,
		ToTitleScreen,
		ToDeskFromSolve,

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

				case ClickCommands.ToTV:
					GameState.Instance().previousSceneString = "TitleScene";
					Application.LoadLevel("NewsScene");
					break;

				case ClickCommands.ToSolve:
					GameState.Instance().previousSceneString = "DesktopScene";
					Application.LoadLevel("SolveScene");
					break;

				case ClickCommands.ToTitleScreen:
					GameState.Instance().previousSceneString = "SolveScene";
					Application.LoadLevel("TitleScene");
					break;
				case ClickCommands.ToDeskFromSolve:
					GameState.Instance().previousSceneString = "SolveScene";
					Application.LoadLevel("DesktopScene");
					break;

			}
		}

    }
}
