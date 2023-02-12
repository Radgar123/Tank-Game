using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public void Shoot(PlayerInputs playerInputs,int currentAmmunition, float shootDelay, Transform turretShootPoint)
    {
        if (playerInputs.shooted)
        {
            float a = shootDelay;
            GameObject currentAmmoShoot = ObjectPooling.instance.GetPooledObject(currentAmmunition) ;
            Vector3 pos = new Vector3(turretShootPoint.position.x,
                turretShootPoint.position.y, turretShootPoint.position.z);
            Quaternion rot = new Quaternion(turretShootPoint.rotation.x, turretShootPoint.rotation.y,
                turretShootPoint.rotation.z,turretShootPoint.rotation.w);
            currentAmmoShoot.GetComponent<Bullet>().Init(pos,rot);
            playerInputs.shooted = false;
        }
    }
    
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(1);
    }
}
