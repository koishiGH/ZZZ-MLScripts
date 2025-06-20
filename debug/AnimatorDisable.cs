
var animator = UnityEngine.Object.FindObjectsOfType<UnityEngine.Animator>();
foreach (var animators in animator)
{
    animators.enabled = false;
}
