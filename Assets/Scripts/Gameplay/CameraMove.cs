using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject player;
    [SerializeField]
    float offset;


	void Update () {
        transform.position = new Vector3(player.transform.position.x + offset, player.transform.position.y, -10);
	}
}
