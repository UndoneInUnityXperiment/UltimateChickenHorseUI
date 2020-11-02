using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimation : MonoBehaviour
{
    //Trigger the end of the PartyBox 'Appear' animation
    public void SetAppearEnd()
    {
        GetComponent<Animator>().SetBool("appeared", true);
    }

    //Trigger the end of the PartyBox 'Open' animation
    public void SetOpenEnd()
    {
        GameObject.FindGameObjectWithTag("PartyBoxManager").GetComponent<PartyBoxManager>().ActivateCursor();
        GameObject.FindGameObjectWithTag("PartyBoxManager").GetComponent<PartyBoxManager>().SpawnObjects();
    }

    public void SetCloseEnd()
    {
        GetComponent<Animator>().SetBool("closed", true);
    }

    public void DeactivateBox()
    {
        GetComponent<Animator>().SetBool("gone", true);
    }
}
