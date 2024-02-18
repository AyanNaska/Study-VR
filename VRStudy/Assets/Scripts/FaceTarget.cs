using UnityEngine;

public class FaceTarget : MonoBehaviour
{
    public Transform target; // Reference to the target game object
    public Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (target != null)
        {
            // Get the direction from this object to the target, ignoring the y-axis
            Vector3 direction = target.position - transform.position;
            direction.y = 0f; // Ignore y-axis

            // If the direction is not zero
            if (direction != Vector3.zero)
            {
                // Calculate the rotation needed to face the target
                Quaternion targetRotation = Quaternion.LookRotation(direction);

                // Apply the rotation to this object, only rotating around the x and z axes
                transform.rotation = Quaternion.Euler(0f, targetRotation.eulerAngles.y, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("talk");
        }
    }
    public void playtalk()
    {
        anim.SetTrigger("talk");
    }
}
