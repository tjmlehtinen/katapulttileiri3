using UnityEngine;
using UnityEngine.UI;

public class CatapultScript : MonoBehaviour
{
    public Animator armAnimator;
    public Transform turret;
    public Transform shootPoint;
    public Rigidbody ammoBody;
    public Slider forceSlider;
    public Slider angleSlider;
    public Vector3 launchDirection = new Vector3(0, 1, 1);
    public float launchForce = 10f;
    public float rotationSpeed = 100f;
    private float launchAngle = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetCatapult();
        }
        HandleRotation();
        HandleSliders();
    }
    void Launch()
    {
        ammoBody.isKinematic = false;
        launchDirection = turret.forward + Vector3.up;
        ammoBody.AddForce(launchDirection.normalized * launchForce, ForceMode.Impulse);
        ammoBody.transform.parent = null;
        armAnimator.SetTrigger("Launch");
    }
    void ResetCatapult()
    {
        ammoBody.isKinematic = true;
        ammoBody.transform.position = shootPoint.position;
        ammoBody.transform.parent = shootPoint;
    }
    void HandleRotation()
    {
        float rotationInput = Input.GetAxis("Horizontal");
        turret.Rotate(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);
    }
    void HandleSliders()
    {
        launchForce = 100 * forceSlider.value;
    }
}
