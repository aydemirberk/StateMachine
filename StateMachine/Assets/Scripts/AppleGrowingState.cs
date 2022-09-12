using UnityEngine;

public class AppleGrowingState : AppleBaseState
{
    Vector3 startingAppleSize = new Vector3(0.1f, 0.1f, 0.1f);
    Vector3 growAppleScalar = new Vector3 (0.1f, 0.1f, 0.1f);
public override void EnterState(AppleStateManager apple)
{
apple.transform.localScale = startingAppleSize;
}
public override void UpdateState(AppleStateManager apple)
{

if (apple.gameObject.transform.localScale.x<1)
apple.gameObject.transform.localScale += growAppleScalar * Time.deltaTime;
else
apple.SwitchState(apple.WholeState);

}
public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
{

}
}
