using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.AI;

public class move : MonoBehaviour
{
    public Vector3 obj1;
    public Vector3 obj2;
    private Rigidbody rb;
    private float time;
    private bool iscol=false;
    private bool istri = false;
    private Vector3 temVe;
    private Renderer ren;
    private Material mat;
    public Color[] cols;
    private int ColIndex = 0;
 //ºì¡¢³È¡¢»Æ¡¢ÂÌ¡¢À¶¡¢µå¡¢×Ï
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ren = GetComponent<Renderer>();
        mat = ren.material;
        mat.color = cols[ColIndex];
        rb.velocity = Vector3.right*2;
    }

    // Update is called once per frame
  
    void Update()
    {
        if (iscol)
        {
            time += Time.deltaTime;
            if (time > 1) {
                rb.velocity = temVe;
                iscol = false;
                transformColor();
                time = 0;
            }
        }
        if(istri)
        {
            time += Time.deltaTime;
            if (time > 0.5)
            {
                transformColor();
                time = 0;
            }
        }

    }
    private void transformColor()
    {
        ColIndex = (ColIndex+1)%cols.Length;
        mat.color = cols[ColIndex];
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            temVe = -rb.velocity;
            rb.velocity = Vector3.zero;
            iscol = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "col")
        {
            istri = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "col")
        {
            istri = false;
            time = 0;
        }
    }
}
