using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerManager pm_PlayerManager;




    private static GameManager instance;
    public static GameManager GetGameManager
    {
        get
        {
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
            {
                instance = this;
            }
        DontDestroyOnLoad(instance);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //******************************************************************Getters******************************************************************//
    private PlayerManager GetPlayerManager(){return pm_PlayerManager;}
}
