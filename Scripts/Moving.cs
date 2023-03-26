using UnityEngine;

public class Moving : MonoBehaviour
{
    private Animator Anim;
    private Rigidbody rb;

    [SerializeField] private float jumpF = 200f;

    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        Anim = GetComponentInChildren<Animator>();

        Anim.SetInteger("AnimationPar", 1);
    }

    private void FixedUpdate()
    {
        if (!IsInGame.isinGame)
            return;

        if (Input.GetTouch(0).phase == TouchPhase.Began && transform.localPosition.y <= 1.99f) {
            Jump(); }
    }

    private void Jump()
    {
        if (transform.localPosition.y <= 1.96f)
            rb.AddForce(Vector3.up * jumpF);
    }
}
