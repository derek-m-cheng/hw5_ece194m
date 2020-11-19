using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0)) ; //Debug returns possible empty statement*


     {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;



            if (Physics.Raycast(ray, out hit, 10f))
                Debug.DrawRay(ray.origin, hit.point);

            Destroy(GameObject.Find(hit.collider.gameObject.name));
        }
    }
}
