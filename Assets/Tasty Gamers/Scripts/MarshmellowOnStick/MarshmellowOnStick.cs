using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarshmellowOnStick : MonoBehaviour
{
    public GameObject VRAvatar;
    private  GameObject Hand;

    private GameObject Mellow;
    public Texture BurnTex;

    void Start()
    {
        Mellow = gameObject.transform.GetChild(0).gameObject;
    }

    public void AttachToController()
    {
        for(int i = 0; i < VRAvatar.transform.childCount; i++)
        {
            Transform tChild = VRAvatar.transform.GetChild(i);
            if(tChild.name == "PrimaryHand")
            {
                Hand = tChild.gameObject;
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, Hand.transform.position, 1);
                BurnMellow();
            }
        }
    }

    public void BurnMellow()
    {
       MeshRenderer MellowRenderer = Mellow.GetComponent<MeshRenderer>();
       MellowRenderer.material.SetTexture("_MainTex", BurnTex);
    }
}
