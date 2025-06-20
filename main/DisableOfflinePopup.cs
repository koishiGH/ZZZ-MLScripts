GameObject gameObject = GameObject.Find("/UIRootProxy/UICanvasTop/AdaptRoot/SafeArea/GeneralTipsDialog(Clone)");
bool active = gameObject.active;
if (active)
{
	gameObject.SetActive(false);
}
else
{
	gameObject.SetActive(true);
}