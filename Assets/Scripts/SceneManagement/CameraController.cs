using Unity.Cinemachine;
using UnityEngine;

public class CameraController : Singleton<CameraController>
{
    private CinemachineCamera _cinemachineCamera;

    public void SetPlayerCameraFollow()
    {
        _cinemachineCamera = FindFirstObjectByType<CinemachineCamera>();
        if (_cinemachineCamera != null)
        {
            _cinemachineCamera.Target.TrackingTarget = PlayerController.Instance.transform;
        }
    }
}
