using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLights : MonoBehaviour
{

    public GameObject Flames;
   

    // Start is called before the first frame update
    void Start()
    {
        // Making sure that the flames are set to true.
        Flames.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Turning off and on candles' flames.
    public void OffnOnFlames()
    {
        if(Flames.activeSelf == true)
        {
            Flames.SetActive(false);
        }else
        if (Flames.activeSelf == false)
        {
            Flames.SetActive(true);
        }

    }

}
