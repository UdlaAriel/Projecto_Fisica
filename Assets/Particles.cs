using UnityEngine;

public class Particles : MonoBehaviour
{
    private ParticleSystem particles;
    private ParticleSystem.EmissionModule emission;

    void Start()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        emission = particles.emission;
        emission.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter trigger");
        if (other.CompareTag("Apple"))
        {
            emission.enabled = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Continues inside trigger");
        other.attachedRigidbody.AddForce(Vector3.up * 12, ForceMode.Acceleration);
    }

    /*
     private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            emission.enabled = false;
        }
    }*/
}
