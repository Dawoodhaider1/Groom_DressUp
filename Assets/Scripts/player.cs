using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator anim;
    public GameObject win_Scene;
    public GameObject loose_Scene;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        if(win_Scene.activeSelf == true)
        {
            anim.SetBool("Result_active", true);
        }
        if(loose_Scene.activeSelf == true)
        {
            anim.SetBool("Result_active", true);
        }
    }

    //IEnumerator wait()
    //{
    //    yield return new WaitForSeconds(10);
    //}
}
