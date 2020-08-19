using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dispenser : MonoBehaviour
{

    public TextMeshProUGUI txt;
    public static int herbAmount;
    public GameObject herbSpawner;
    public GameObject herb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = herbAmount.ToString();

        if (herbAmount >= 1)
        {
            Instantiate(herb, new Vector3(herbSpawner.transform.position.x, herbSpawner.transform.position.y, herbSpawner.transform.position.z), Quaternion.identity);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "herb")
        {
            Debug.Log("collision works"); //nice

            herbAmount += 1;

            //Destroy(col.gameObject);
        }
    }
    //void herb;

}
