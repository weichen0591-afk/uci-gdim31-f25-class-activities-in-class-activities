using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2.0f;
    [SerializeField] private Transform _cat;

    public void StartChasing()
    {
        enabled = true;
    }

    public void StopChasing()
    {
        enabled = false;
    }


    private void Update()
    {
        Vector3 direction = _cat.position - transform.position;
        transform.position += direction * _moveSpeed * Time.deltaTime;
    }
}
