using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public float rotationSpd = 150;
    public GameObject laser;
    public float fireRate = 2;

    private float lastFireTime = float.MinValue;
	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
	}
	
	// Examples for movement below
	void FixedUpdate () {
        //To get frame independant gameplay, factor in DeltaTime. Delta time checks how much time has passed since the last frame
        //
        
            Rigidbody2D rB = gameObject.GetComponent<Rigidbody2D>();
            //rB.velocity = Vector2.zero;
            //gameObject.transform.position += new Vector3(0, speed) * Time.deltaTime;
            //gameObject.transform.position += speed * gameObject.transform.right * Time.deltaTime;
            rB.AddForce(Input.GetAxis("Vertical") * speed * gameObject.transform.right);
        if (Input.GetKey(KeyCode.W))
        {
            //rB.velocity = gameObject.transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //gameObject.transform.Rotate(0, 0, (-1 * rotationSpd) * Time.deltaTime);
            rB.AddTorque(-rotationSpd);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rB.AddTorque(rotationSpd);
            //gameObject.transform.Rotate(0, 0, rotationSpd * Time.deltaTime);
        }
       
	}

    void Update()
    {
        if (laser == null)
        {
            Debug.Log("Need to give a laser game object");
        }
        if (Input.GetAxis("Laser") > 0)
        {
            if (Time.time - (1 / fireRate) > lastFireTime)
            {
                GameObject obj = Instantiate(laser, transform.GetChild(0).position, transform.rotation);
                obj.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 1, 1, 1,1,1,1);
                lastFireTime = Time.time;
            }
        }

    }
}
