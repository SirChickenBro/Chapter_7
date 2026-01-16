using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int RotationSpeed = 100;
    private Transform _itemTransform;   


    void Start()
    {
        _itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _itemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}
