using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ParticleSystem"))
        {
            Debug.Log("Entr� en contacto con el Particle System");
        }
    }
}
