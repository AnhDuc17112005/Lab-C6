using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimAPI : MonoBehaviour
{
    private Animator anim;

    // Bonus: hash để tối ưu + tránh sai chính tả
    private static readonly int SpeedHash = Animator.StringToHash("speed");
    private static readonly int AttackHash = Animator.StringToHash("attack");

    private float lastSpeed = -999f;

    [Header("Move")]
    public float moveSpeed = 3f;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // 1) Đọc input
        float move = Input.GetAxisRaw("Horizontal"); // A/D hoặc Left/Right
        float speed = Mathf.Abs(move);

        // 2) SetFloat nhưng tránh set liên tục nếu không đổi (tối ưu)
        if (Mathf.Abs(speed - lastSpeed) > 0.001f)
        {
            anim.SetFloat(SpeedHash, speed);
            lastSpeed = speed;
        }

        // 3) SetTrigger khi nhấn phím (1 lần)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(AttackHash);
        }

        // 4) (Demo) cho nhân vật di chuyển để thấy Run rõ
        if (move != 0f)
        {
            transform.position += new Vector3(move, 0f, 0f) * moveSpeed * Time.deltaTime;
        }
    }
}