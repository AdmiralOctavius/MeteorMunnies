using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 3.5f;
	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
        //To get frame independant gameplay, factor in DeltaTime. Delta time checks how much time has passed since the last frame
        if (Input.GetKey(KeyCode.W)){
            gameObject.transform.position += new Vector3(0, speed) * Time.deltaTime;
        }
	}
}
