using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenAnimationController : MonoBehaviour
{
    Animator animator;

    float swoop = 0.0f;
    float strafe = 0.0f;
    float roll = 0.0f;

    // Adjust in inspector to transition faster between animations
    [SerializeField]
    float animationSpeed = 0.1f;

    bool swooping = false;
    bool strafing = false;
    bool rolling = false;

    bool strafeSwoop = false;

    // Find animator hash locations
    int swoopHash;
    int strafeHash;
    int rollHash;
   
    int strafeSwoopHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // Get hash numbers from the animator variables
        swoopHash = Animator.StringToHash("Swoop");
        strafeHash = Animator.StringToHash("Strafe");
        rollHash = Animator.StringToHash("Roll");

        strafeSwoopHash = Animator.StringToHash("StrafeSwoop");

    }

    // Update is called once per frame
    void Update()
    {
        bool swoopUp = Input.GetKey(KeyCode.S);
        bool swoopDown = Input.GetKey(KeyCode.W);
        swooping = (swoopUp || swoopDown);

        bool strafeLeft = Input.GetKey(KeyCode.D);
        bool strafeRight = Input.GetKey(KeyCode.A);
        strafing = (strafeLeft || strafeRight);

        bool rollLeft = Input.GetKey(KeyCode.E);
        bool rollRight = Input.GetKey(KeyCode.Q);
        rolling = (rollLeft || rollRight);

        if (swooping)
        {
            if (swoopUp)
                swoop = Mathf.Clamp(swoop + (Time.deltaTime * animationSpeed), -1f, 1f);
            else if (swoopDown)
                swoop = Mathf.Clamp(swoop - (Time.deltaTime * animationSpeed), -1f, 1f);

            //Debug.Log("Swoop detected!" + swoop);

            // Tell the animator to use its blendtree
            strafeSwoop = true;
        } 

        if (strafing)
        {
            if (strafeLeft)
                strafe = Mathf.Clamp(strafe + (Time.deltaTime * animationSpeed), -1f, 1f);
            else if (strafeRight)
                strafe = Mathf.Clamp(strafe - (Time.deltaTime * animationSpeed), -1f, 1f);

            Debug.Log("Strafe detected: " + strafe);

            // Tell the animator to use its blendtree
            strafeSwoop = true;
        }

        if (!strafing && !swooping)
        {
            // Tell the animator to stop using its blendtree, that's enough sir
            strafeSwoop = false;
        }
        

        if (rolling)
        {
            // Affect roll variable: -1 Left, +1 Right
            if (rollLeft)
                roll = Mathf.Clamp(roll + (Time.deltaTime * animationSpeed), -1f, 1f);
            else if (rollRight)
                roll = Mathf.Clamp(roll - (Time.deltaTime * animationSpeed), -1f, 1f);

            Debug.Log("Roll detected: " + roll);
        }


        // Do the animatin to the burd
        animator.SetFloat(swoopHash, swoop);
        animator.SetFloat(strafeHash, strafe);
        animator.SetFloat(rollHash, roll);
        animator.SetBool(strafeSwoopHash, strafeSwoop);
    }
}
// Disclaimer: this code was written by the artist with help from special guest google -- don't judge pls
