using System;
using System.IO;
using UnityEngine;

public class test : MonoBehaviour
{
    // Chemin relatif du fichier (placez le fichier dans le dossier Assets/Resources)
    public string fileName = "Advent Calendar\\Day 1\\nouveau 45.txt";

    void Start()
    {
        // Vérifier si le fichier existe
        string filePath = Path.Combine(Application.dataPath, fileName);
        if (File.Exists(filePath))
        {
            ReadFileCharacterByCharacter(filePath);
        }
        else
        {
            Debug.LogError("Fichier non trouvé : " + filePath);
        }
    }

    void ReadFileCharacterByCharacter(string filePath)
    {
        try
        {
            // Ouvrir le fichier avec un StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                int currentChar;
                while ((currentChar = reader.Read()) != -1) // Lire caractère par caractère
                {
                    char character = (char)currentChar; // Convertir le code ASCII en char
                    Debug.Log("Caractère lu : " + character);
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Erreur lors de la lecture du fichier : " + e.Message);
        }
    }
}
