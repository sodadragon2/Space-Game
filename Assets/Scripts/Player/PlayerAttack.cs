using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Melee;
    public float atkDuration = 0.3f;
    private float atkTimer = 0f;
    private bool isAttacking = false;

    // Update is called once per frame
    void Update()
    {
        CheckMeleeTimer();
        if (Input.GetMouseButton(0))
        {
            OnAttack();
        }
    }

    void OnAttack()
    {
        if (!isAttacking)
        {
            Melee.SetActive(true);
            isAttacking = true;
            //Call animator to play melee
        }
    }

    void CheckMeleeTimer()
    {
        atkTimer += Time.deltaTime;
        if (atkTimer >= atkDuration)
        {
            atkTimer = 0;
            isAttacking= false;
            Melee.SetActive(false);
        }
    }
}
