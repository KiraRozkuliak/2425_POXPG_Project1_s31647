using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public string mainWord = "default";
    public int livesCount = 10;
    public TextMeshProUGUI mainWordText;
    public TextMeshProUGUI livesCountText;
    public TextMeshProUGUI messegeText;
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
        livesCountText.text = $"Zostało {livesCount} prób";
    }

    public void ONClick()
    {
        Debug.Log($"Guzzik został kliknięty");
        livesCount = livesCount - 1;
        livesCountText.text = $"Zostało {livesCount} prób";

        if(mainWord == inputField.text)
        {
            messegeText.text = $"Poprawne słowo zostało wpisane";
            return; // koniec metody
        }

        if (mainWord.Length != inputField.text.Length) 
        {
            messegeText.text = $"Liczba liter się nie zgadza";
            return; // koniec metody
        }

         int countBulls = CountBulls();
         int cowsBulls = CountCows();
         messegeText.text = $"Bulls: {countBulls} and Cows: {cowsBulls}";

    }


    public int CountBulls()
    {
        int result = 0;

        for 
            (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] == inputField.text[i])
            {
                result++;
            }
        }
        return result;
    }
    public int CountCows()
    {

        int result = 0;

        for
            (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] != inputField.text[i] && mainWord.Contains(inputField.text[i]) )
                    result++;
        }
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
