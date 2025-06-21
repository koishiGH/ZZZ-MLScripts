GameObject GTDClone = GameObject.Find("/UIRootProxy/UICanvasTop/AdaptRoot/SafeArea/GeneralTipsDialog(Clone)");
GameObject uiLoading = GameObject.Find("/UIRootProxy/UICanvasTop/AdaptRoot/SafeArea/UILoading(Clone)");
bool activeGTD = GTDClone.active;
bool activeLoading = uiLoading.active;
if (activeGTD && activeLoading)
{
	uiLoading.SetActive(false);
	GTDClone.SetActive(false);
}
else
{
	uiLoading.SetActive(true);
	GTDClone.SetActive(true);
}