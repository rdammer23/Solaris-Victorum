using Assets.Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Menu
{
    class OrbitMenu : MonoBehaviour
    {
        GameObject inGameMenu;
        public Texture mainMenuImg; //The image to use for the button to start the menus up

        private int curAction = 0;

        private Rect WindowArea = new Rect(50, 50, 400, 200);

        WeaponSiteControl weaponControl;
        CloseGame closeGame;
        TriggerManager triggerState;

        public void OnGUI()
        {
            if (GUI.Button(new Rect(25, Screen.height - 150, 128, 128), mainMenuImg, "label"))
                gameObject.SendMessage("OrbitTraverseMenu");


            if (curAction == 0)
            {
                return;
            }

            switch (curAction)
            {
                case 1:
                    weaponControl = new WeaponSiteControl();
                    weaponControl.ActivateWeaponWindow();

                    break;
                case 2:
                    closeGame = new CloseGame();
                    //LeaderBoards();
                    closeGame.QuitGame();
                    break;
                case 3:
                    GoOrbit();
                    break;
                case 4:
                    Credits();
                    break;
            }
            curAction = 0;
            gameObject.SendMessage("ActivateMenu", true, SendMessageOptions.DontRequireReceiver);
            /* I commented out the below code as it was causing issues.  Add if a X to close is needed.
            if (GUI.Button(new Rect(WindowArea.x + WindowArea.width - 25, WindowArea.y, 25, 25), "X"))
            {
                curAction = 0;
                gameObject.SendMessage("ActivateMenu", true, SendMessageOptions.DontRequireReceiver);
            }
            */
        }

        public void OnStart()
        {
            closeGame = new CloseGame();

            if (inGameMenu)
            {
                Instantiate(inGameMenu);
                Destroy(gameObject);
            }
        }

        public void WeaponsControl()
        {
            curAction = 1;
        }

        public void Quit()
        {
            curAction = 2;
        }

        public void EnterOrbit()
        {
            curAction = 3;
        }

        public void OnAction4()
        {
            curAction = 4;
        }

        public void GoOrbit()
        {
            triggerState = new TriggerManager();
            Debug.Log(triggerState.GetIfOrbit());
            if (!triggerState.GetIfOrbit())
            {
                Debug.Log("In the IF");

            }
        }

        public void HighScores()
        {
            var w = WindowArea;
            GUI.Box(w, "High Scores");
            w.y += 50;
            GUILayout.BeginArea(w);
            GUILayout.BeginVertical();
            GUILayout.Label("Instead of showing this,");
            GUILayout.Label("You would call your actual High Scores system");
            GUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void LeaderBoards()
        {
            var w = WindowArea;
            GUI.Box(w, "LeaderBoards");
            w.y += 50;
            GUILayout.BeginArea(w);
            GUILayout.BeginVertical();
            GUILayout.Label("Instead of showing this,");
            GUILayout.Label("You would call your actual leaderboards system");
            GUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void Settings()
        {
            var w = WindowArea;
            GUI.Box(w, "Settings and Config");
            w.y += 50;
            GUILayout.BeginArea(w);
            GUILayout.BeginVertical();
            GUILayout.Label("Instead of showing this,");
            GUILayout.Label("You would call your own settings system");
            GUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void Credits()
        {
            var w = WindowArea;
            GUI.Box(w, "Credits");
            w.y += 50;
            GUILayout.BeginArea(w);
            GUILayout.BeginVertical();
            GUILayout.Label("Instead of showing this,");
            GUILayout.Label("You would display your game's credits");
            GUILayout.EndVertical();
            GUILayout.EndArea();
        }

    }
}
