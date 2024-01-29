using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class OutfitChange : MonoBehaviour
{
    [Tooltip("Sprite we change")]
    public SpriteRenderer bodyPart;

    public List<Sprite> choose = new List<Sprite>();

    private int currOption = 0;

    public void NextOption()
    {
        Debug.Log("Next Pressed");
        currOption++;
        if(currOption >= choose.Count)
        {
            currOption = 0;
        }
        bodyPart.sprite = choose[currOption];
    }

    public void PreviousOption()
    {
        Debug.Log("Prev Pressed");
        currOption--;
        if(currOption <= 0)
        {
            currOption = choose.Count -1;
        }
        bodyPart.sprite = choose[currOption];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
