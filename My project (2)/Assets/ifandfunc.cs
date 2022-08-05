using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifandfunc : MonoBehaviour
{
    string Heroname = "crash";
    string Villainname = "momo";
    int Heropower = 50;
    int Villainpower = 40;
    float  playerspeed = 4.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Heropower > Villainpower)
        {
            print( "Hero is stronger ");
        }
        
        else if (Heropower == Villainpower)
        {
            print ("Heropower is same as Villainpower");
        }
        else 
        {
            print("Villain is stronger");
        }
        
         
           
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }
    void setspeed(float newspeed)
    {
        print(playerspeed);
        playerspeed = newspeed;
        print (playerspeed);
         
    }
}
