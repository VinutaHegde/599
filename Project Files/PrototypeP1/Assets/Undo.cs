using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Undo : MonoBehaviour
{
    public Button[] undo;
    public bool check1;
    public bool check2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // OnClick function for the tile 
    public void clickFunction()
    {
        //Text txt = undo.GetComponentInChildren<Text>();
        //txt.text = "Hello";
        TileManager.undoScore(check1,check2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
