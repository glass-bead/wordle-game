using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GB_Wordle
{
    public class Keyboard : MonoBehaviour
    {
        //[SerializeField] Button[] keyboardKeys;

        // private List<Buttons> buttonsPressed 

        public void HandleAlpahbeticalKeyPressing (Button keyPressed)
        {
            if (!keyPressed.CompareTag("AlphabeticalKey")) return;
        
            string letter = keyPressed.GetComponentInChildren<TextMeshProUGUI>().text;
            Debug.Log(letter + " pressed.");
            
            // TODO : send letter to be writen in the board;
        }

        public static void HandleEnterKeyPressing (Button enterKey)
        {
            if (!enterKey.CompareTag("EnterKey")) return;

            // TODO : Check if all spots are filled and send word for comparation
            Debug.Log("Enter key pressed.");
        }

        public static void HandleDeleteKeyPressing (Button deleteKey)
        {
            if (!deleteKey.CompareTag("DeleteKey")) return;

            // TODO : remove last pressed letter
            Debug.Log("Delete key pressed.");
        }

        // Method that changes button color

    }
}
