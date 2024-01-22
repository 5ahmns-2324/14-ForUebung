using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forschleife : MonoBehaviour
{
    int zeilenAnzahl = 3;

    void Start()
    {
        for (int zeile = 1; zeile <= zeilenAnzahl; zeile++)
        {
            string ausgabe = "";

            ausgabe = GeneriereMinuszeichen(ausgabe);

            for (int sterne = 1; sterne <= 2 * zeile - 1; sterne++)
            {
                ausgabe += "*";
            }

            ausgabe = GeneriereMinuszeichen(ausgabe);

            Debug.Log(ausgabe);
        }
    }

    private string GeneriereMinuszeichen(string ausgabe)
    {
        for (int i = 1; i <= zeilenAnzahl - ausgabe.Length; i++)
        {
            ausgabe += "-";
        }
        return ausgabe;
    }
}