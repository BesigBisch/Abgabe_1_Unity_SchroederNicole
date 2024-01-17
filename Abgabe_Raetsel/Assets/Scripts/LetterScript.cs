using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterScript : MonoBehaviour
{
    private PuzzleManagerScript puzzleManager; 
    public bool isCorrect;
    public bool isWrong;

    public Color wrongColar;
    public Color rightColar;
   


    private void Start()
    {
        puzzleManager = GameObject.Find("PuzzleManager").GetComponent<PuzzleManagerScript>();
        
    
    }

    public void PressLetter()
    {
        if (isCorrect)
        {
            gameObject.GetComponent<Image>().color = rightColar;
            puzzleManager.RightLetter();
           
        }

        if (isWrong)
        {
            gameObject.GetComponent<Image>().color = wrongColar;
            puzzleManager.WrongLetter();
        }
    }
}
