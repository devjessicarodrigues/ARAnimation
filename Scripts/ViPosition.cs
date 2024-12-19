using UnityEngine;

public class ViPosition : MonoBehaviour
{
    private Vector3 position = new Vector3(-448.1f, 0f, -854.4f);

    void LateUpdate()
    {
        transform.position = position;

        transform.rotation = Quaternion.Euler(
            transform.rotation.eulerAngles.x,
            0f,
            transform.rotation.eulerAngles.z
        );
    }
}
