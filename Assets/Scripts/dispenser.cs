using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dispenser : MonoBehaviour
{

    public TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "herb")
        {
            Debug.Log("collision works"); //nice

            txt.text = "1";


            //Destroy(col.gameObject);
        }
    }
}
