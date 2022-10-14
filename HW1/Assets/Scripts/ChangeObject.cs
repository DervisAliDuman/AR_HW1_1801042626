using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    //public GameObject Cube;
    //public Color color;
    public MeshRenderer rend;
    public Material mat;
    

    void changer(){
        //Cube.color = color;
        rend.material = mat;
        
    }

}
