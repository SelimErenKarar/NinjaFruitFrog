using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}
