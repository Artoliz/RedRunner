﻿using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{

    #region Public Fields

    public Sprite FrontDoor_Yellow;
    public Sprite FrontDoor_Grey;
    public Sprite FrontDoor_DarkGrey;
    public Sprite Star;

    public static LevelsManager Instance;

    // Or Private ?
    public int Life = 5;

    #endregion

    #region Private Fields

    private Dictionary<string, int> starsCollected;

    #endregion

    #region Monobehaviour Callbacks

    private void Awake()
    {
        DontDestroyOnLoad(this);

        Instance = this;
    }

    #endregion

    #region Public Methods

    public void SetStarsCollected(string levelName, int nbStars)
    {
        starsCollected.Add(levelName, nbStars);
    }

    public void RemoveOneLife()
    {
        Life -= 1;
    }

    #endregion
}
