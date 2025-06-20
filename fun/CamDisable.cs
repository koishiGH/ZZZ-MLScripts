

var cams = UnityEngine.Object.FindObjectsOfType<UnityEngine.Camera>();
foreach (var cam in cams)
{
    cam.enabled = true;
}

UnityEngine.GameObject newCameraObject = new UnityEngine.GameObject("NewCamera");
UnityEngine.Camera newCamera = newCameraObject.AddComponent<UnityEngine.Camera>();

newCamera.transform.position = new UnityEngine.Vector3(0, 1, -10);
newCamera.clearFlags = UnityEngine.CameraClearFlags.Color;
newCamera.backgroundColor = UnityEngine.Color.gray;
newCameraObject.AddComponent<NewCameraController>();