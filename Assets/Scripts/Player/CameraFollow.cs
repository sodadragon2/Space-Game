using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float damping;
    private Vector3 vel = Vector3.zero;

    public Transform target;

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
    }
}
