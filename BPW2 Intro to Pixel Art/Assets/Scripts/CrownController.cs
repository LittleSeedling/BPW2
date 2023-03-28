using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CrownController : MonoBehaviour
{
    public bool isPickedUp;
    public bool hasPutOn;

    public GameObject playerCrown;
    
    public Animator knight1;
    public Animator knight2;

    private void Start()
    {
        playerCrown.SetActive(false);
    }

    public void PickupCrown()
    {
        if (!isPickedUp)
        {
            isPickedUp = true;
            Debug.Log("Crown has now been picked up!");
            gameObject.SetActive(false);
            knight1?.SetBool("IsCrownPickedUp", isPickedUp);
            knight2.SetBool("IsCrownPickedUp", isPickedUp);

        }

        else
        {
            Debug.Log("Crown has been put back!");
            gameObject.SetActive(true);
            isPickedUp = false;
            knight1?.SetBool("IsCrownPickedUp", isPickedUp);
            knight2.SetBool("IsCrownPickedUp", isPickedUp);

        }

    }

    public void PutOnCrown()
    {
        if (!hasPutOn)
        {
            hasPutOn = true;
            Debug.Log("Player Crown has been put on!");
            playerCrown.SetActive(true);

        }

        else
        {
            Debug.Log("Player Crown has been put off!");
            playerCrown.SetActive(false);
            hasPutOn = false;

        }
    }

}
