using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightingMechanics : MonoBehaviour
{
    //public AudioClip sound;
    public Animator animator;
    public Button JabCrossButton;
    public FixedJoystick fixedJoystick;
    //public Animation anim;
    bool jabpunched;

    void Start()
    {
        animator = GetComponent<Animator>();
        Button btn = JabCrossButton.GetComponent<Button>();
        btn.onClick.AddListener(jabPunched);
        jabpunched = false;
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        //bool forwardPressed = Input.GetButton("Fire1");
        bool forwardPressed;
        //bool isjabbing = animator.GetBool("jabCross");
        if (fixedJoystick.Horizontal != 0 || fixedJoystick.Vertical != 0)
        {
            forwardPressed = true;
        }
        else
        {
            forwardPressed = false;
        }

        if (jabpunched)
        {
            animator.SetBool("jabCross", true);
            jabpunched = false;
        }
        else if (!jabpunched)
        {
            animator.SetBool("jabCross", false);
            jabpunched = false;
            
        }

        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);

        }
        else if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);

        }
    }

    void jabPunched()
    {
        
        jabpunched = true;
    }

}
