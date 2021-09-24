using UnityEngine;

public class Paddle : MonoBehaviour {

    //Configuration variables
    [SerializeField] float screenWidthInUnit = 16f;
    [SerializeField] float minMouseXPosInUnit = 1f;
    [SerializeField] float maxMouseXPosInUnit = 15f;

    // cached references
    GameSession theGameSession;
    Ball theBall;

    // Use this for initialization
    void Start () {
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 paddlePos = new Vector2(GetXPos(), transform.position.y);
        transform.position = paddlePos;
	}

    private float GetXPos()
    {
        if (theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Mathf.Clamp(Input.mousePosition.x
                / Screen.width * screenWidthInUnit, 
                minMouseXPosInUnit, maxMouseXPosInUnit);
        }
    }
}
