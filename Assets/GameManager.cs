using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public GUISkin layout;
    GameObject theBall;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("bolaNPC"); 
    }

    public static void Score(string wallID)
    {
        if (wallID == "enemyGoal")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }

    void OnGUI()
    {
        GUI.skin = layout;

        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.normal.textColor = Color.red;
        scoreStyle.fontSize = 30;

        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1, scoreStyle);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2, scoreStyle);

        if (PlayerScore1 == 10)
        {
            GUIStyle winStyle = new GUIStyle();
            winStyle.normal.textColor = Color.red;
            winStyle.fontSize = 50;

            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS", winStyle);
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (PlayerScore2 == 10)
        {
            GUIStyle winStyle = new GUIStyle();
            winStyle.normal.textColor = Color.red;
            winStyle.fontSize = 50;

            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS", winStyle);
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }
}
