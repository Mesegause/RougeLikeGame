using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float offset;
    public GameObject Bubble;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Instantiate(Bubble, shotPoint.position, Quaternion.Euler(Vector3.forward * 90f));
                timeBtwShots = startTimeBtwShots;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                Instantiate(Bubble, shotPoint.position, Quaternion.Euler(Vector3.zero));
                timeBtwShots = startTimeBtwShots;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Instantiate(Bubble, shotPoint.position, Quaternion.Euler(Vector3.forward * -90f));
                timeBtwShots = startTimeBtwShots;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Instantiate(Bubble, shotPoint.position, Quaternion.Euler(Vector3.forward * 180f));
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
