using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    Animator animator;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurrent;
    private float triggerCurrent;
    public float speed;
    private string gripName = "Grip";
    private string triggerName = "Trigger";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }
    
    internal void SetGrip(float grip)
    {
        Debug.Log("Grip: " + grip);
        gripTarget = grip;
    }
    
     internal void SetTrigger(float trigger)
    {
        Debug.Log("Trigger: " + trigger);
        triggerTarget = trigger;
    }
    
   void AnimateHand() 
    {
        if(gripCurrent != gripTarget)
        {
        gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(gripName, gripCurrent);
        } 
        if(triggerCurrent != triggerTarget)
        {
        {
        gripCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(triggerName, triggerCurrent);
        }
            
        }
}
}
