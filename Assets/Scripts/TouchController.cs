using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider))]

public class TouchController : MonoBehaviour
{
    public UnityEvent OnTouch;
    
    public GameObject brokenPanel;
    public GameObject gameManager;
    private bool pause;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        OnTouch.Invoke();
    }
    
    void Update()
    {
        if (!pause)
        {
            transform.Translate(new Vector3(0,0,1*Time.deltaTime/2));
        }
        
        if (transform.position.z>-0.5f && transform.position.z<0.5f)
        {
            brokenPanel.SetActive(true);
            brokenPanel.GetComponent<AudioSource>().Play();
            gameManager.GetComponent<GameManager>().MinusScore();
            transform.GetComponent<CharacterMovement>().ChangePosition();
            StartCoroutine(Pause());
            pause = true;
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2f);
        brokenPanel.SetActive(false);
        pause = false;
    }
}
