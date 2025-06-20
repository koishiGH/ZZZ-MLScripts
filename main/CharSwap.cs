var maleAvatar = UnityEngine.GameObject.Find("Char/Avatar/Male/Male_Size03/Avatar_Male_Size03_Billy/Avatar_Male_Size03_Billy.prefab"); // Change this to where the path for the current character is
var femaleAvatarPrefab = UnityEngine.Resources.Load<UnityEngine.GameObject>("Char/Avatar/Female/Female_Size02/Avatar_Female_Size02_Anbi/Avatar_Female_Size02_Anbi.prefab"); // Change this to the character you want it to be

if (maleAvatar != null)
{
    var position = maleAvatar.transform.position;
    var rotation = maleAvatar.transform.rotation;
    UnityEngine.Object.Destroy(maleAvatar);

    var femaleAvatar = UnityEngine.Object.Instantiate(femaleAvatarPrefab, position, rotation);

    if (maleAvatar.transform.parent != null)
    {
        femaleAvatar.transform.SetParent(maleAvatar.transform.parent);
    }
}
else
{
    UnityEngine.Debug.LogError("Male Avatar GameObject not found.");
}
