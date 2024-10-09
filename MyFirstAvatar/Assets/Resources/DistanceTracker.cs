using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DistanceTracker : MonoBehaviour
{
    public GameObject fox1;
    public GameObject fox2;
    public float attackDistance = 0.25f;
    public ARTrackedImage trackedImage1; 
    public ARTrackedImage trackedImage2;
    
    private Animator animator1;
    private Animator animator2;
    // Start is called before the first frame update
    void Start()
    {
        animator1 = fox1.GetComponent<Animator>();
        animator2 = fox2.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trackedImage1.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking &&
            trackedImage2.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
        {
            float distance = Vector3.Distance(fox1.transform.position, fox2.transform.position);

            if (distance < attackDistance)
            {
                EnterAttackState();
            }
        }
    }

    private void EnterAttackState()
    {
        // Play the attack animation
        animator1.SetTrigger("AttackTrigger");
        animator2.SetTrigger("AttackTrigger");
        Debug.Log("Objects are in attack range and attacking!");
    }
}
