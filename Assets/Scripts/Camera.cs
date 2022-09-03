using System.Collections;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float flashTime = 0.1f;
    [SerializeField] private float nextFlashTime = 0.9f;
    [SerializeField] private GameObject flash;

    private bool canShoot = true;

    // Start is called before the first frame update

    private void OnEnable()
    {
        flash.SetActive(false);
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            canShoot = false;
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        flash.SetActive(true);
        yield return new WaitForSeconds(flashTime);
        flash.SetActive(false);
        yield return new WaitForSeconds(nextFlashTime);
        canShoot = true;
    }
}
