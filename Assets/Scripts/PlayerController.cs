using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("speed", Mathf.Abs(move));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("attack");
        }

        transform.Translate(move * 3 * Time.deltaTime, 0, 0);
    }
}