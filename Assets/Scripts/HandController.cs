using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    
    ActionBasedController actionBasedController;
    public Hand hand;
    // Start is called before the first frame update
    void Start()
    {
     actionBasedController = GetComponent<ActionBasedController>();   
    }

    // Update is called once per frame
    void Update()
    {
        hand.SetGrip(actionBasedController.selectAction.action.ReadValue<float>());
        hand.SetTrigger(actionBasedController.selectAction.action.ReadValue<float>());
    }
}
