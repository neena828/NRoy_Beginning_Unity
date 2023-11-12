using UnityEngine;

public class TorchAnimation : MonoBehaviour
{
	Animator anim;
	void Start()
	{
		// Get a reference to the animator
		anim = GetComponent<Animator>();
	}
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("W");
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetTrigger("S");
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("D");
	    }
    }

}
