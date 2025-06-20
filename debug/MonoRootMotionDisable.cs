
var monorootmotionlol = UnityEngine.Object.FindObjectsOfType<MonoRootMotion>();
foreach (var monorootmotions in monorootmotionlol)
{
    monorootmotions.enabled = false;
}
