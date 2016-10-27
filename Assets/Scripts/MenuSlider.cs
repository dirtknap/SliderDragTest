using UnityEngine;
using System.Collections;

public class MenuSlider : MonoBehaviour
{

    public GameObject MenuPanel;
    private Animator anim;
    private bool isActive = false;


	// Use this for initialization
	void Start ()
	{
	    anim = MenuPanel.GetComponent<Animator>();
	    anim.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyUp(KeyCode.A) && !isActive)
	    {
	        OpenMenu();
	    }
	    else if (Input.GetKeyUp(KeyCode.A) && isActive)
	    {
	        CloseMenu();
	    }
	}

    public void OpenMenu()
    {
        anim.enabled = true;
        anim.Play("SlideInAnimation");
        isActive = true;
    }

    public void CloseMenu()
    {
        isActive = false;
        anim.Play("SlideOutAnimation");
    }
}
