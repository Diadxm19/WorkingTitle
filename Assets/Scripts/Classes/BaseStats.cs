using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    private int i_health;
    private float f_speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //******************************************************************Getters******************************************************************//

    //******************************************************************Setters******************************************************************//
    public void SetHealth(int hp){i_health = hp;}
    public void SetSpeed(float Speed){f_speed = Speed;}
}
