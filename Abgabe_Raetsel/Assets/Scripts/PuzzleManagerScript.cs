using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManagerScript : MonoBehaviour
{

    public Color WrongColor;
    public Color RightColor;
    public Color BaseColor;
    public List<GameObject> LetterList;
    private SoundManager soundManager;


    private void Start()
    {
        AddLettersToList();
        soundManager = GameObject.Find("Main Camera").GetComponent<SoundManager>();
    }

    public void RightLetter()
    {
        soundManager.PlayCorrectSound();
        //Debug.Log("Richtig");
    }
    public void WrongLetter()
    {
        soundManager.PlayWrongSound();

        Invoke("ChangeColorDelay", 0.5f);
        //Debug.Log("Falsch");
    }

    
    private void AddLettersToList() 
    {
        foreach (GameObject letter in GameObject.FindGameObjectsWithTag("Letters"))
        {
            LetterList.Add(letter);
        }
    }

    private void ChangeColorDelay() 
    {
        foreach (GameObject letter in LetterList)
        {
            letter.GetComponent<Image>().color = BaseColor;
        }
    }


}
