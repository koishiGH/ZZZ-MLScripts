var texts = UnityEngine.Object.FindObjectsOfType<UnityEngine.UI.Text>();
foreach (var text in texts)
{
    if (text.gameObject.name == "CurHp")
    {
        text.text = "Oh mah gah"; // Change "Oh mah gah" to whatever you want
    }
}