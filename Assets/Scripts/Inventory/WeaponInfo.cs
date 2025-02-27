using UnityEngine;

[CreateAssetMenu(fileName = "WeaponInfo", menuName = "Scriptable Objects/NewWeapon")]
public class WeaponInfo : ScriptableObject
{
    public GameObject weaponPrefab;
    public float WeaponCooldown;
}
