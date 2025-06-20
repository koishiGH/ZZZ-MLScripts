// How to use: Compile it lol (using Melon Loader's C# Compiler), if you switch characters you WILL have to re-compile the script.
GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

foreach (GameObject obj in allGameObjects)
{
    if (obj.name == "WallCollider")
    {
        if (!obj.activeSelf)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }
}