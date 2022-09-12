using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    float rottenCountdown = 10.0f;
public override void EnterState(AppleStateManager apple)
{
    apple.gameObject.GetComponent<Rigidbody>().useGravity= true;
}
public override void UpdateState(AppleStateManager apple)
{
    if (rottenCountdown >= 0)
    {
        rottenCountdown -= Time.deltaTime;
    }
    else
    apple.SwitchState(apple.RottenState);
}
public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
{
    GameObject other = collision.gameObject;

    // if (other.CompareTag("Player"))
    // {
    // other.GetComponent<PlayerController>().addHealth();
    //apple.SwitchState(apple.ChewedState);
    // }
}
}
