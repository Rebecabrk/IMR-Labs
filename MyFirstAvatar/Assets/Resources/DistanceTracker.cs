using UnityEngine;

public class AttackModeTrigger : MonoBehaviour
{
    public GameObject fbxObject1;
    public GameObject fbxObject2;
    public float attackDistance = 0.25f;
    private Animator animator1;
    private Animator animator2;

    void Start(){
        animator1 = fbxObject1.GetComponent<Animator>();
        animator2 = fbxObject2.GetComponent<Animator>();

    }

    void Update()
    {
        if (Vector3.Distance(fbxObject1.transform.position, fbxObject2.transform.position) < attackDistance)
        {
            EnterAttackMode();
        }
    }

    void EnterAttackMode()
    {
        // Implement your attack mode logic here
        Debug.Log("Attack mode activated!");
        animator1.SetTrigger("AttackTrigger");
        animator2.SetTrigger("AttackTrigger");
    }
}
