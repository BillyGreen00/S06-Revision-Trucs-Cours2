using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;

    public int tempsJeu = 0;

    void Start()
    {
       tempsJeu = 0;
       InvokeRepeating("AugmenterPoints", 0f, 1f);
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        tempsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = tempsJeu.ToString() + "s"; 
    }
}
