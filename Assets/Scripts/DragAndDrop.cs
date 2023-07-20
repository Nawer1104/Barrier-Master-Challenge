using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Transform carSpawmPos;

    public Car carToSpawn;

    private bool _dragging;

    private Vector2 _offset;

    public static bool mouseButtonReleased;

    [SerializeField] GameObject particleVFX;

    private void OnMouseDown()
    {
        _dragging = true;

        _offset = GetMousePos() - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        if (!_dragging) return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - _offset;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _dragging = false;
        if (collision.gameObject.tag == "car")
        {
            Destroy(collision.gameObject);
            GameObject explosion = Instantiate(particleVFX, transform.position, transform.rotation);
            Destroy(explosion, .75f);

            Car newCar = Instantiate(carToSpawn, carSpawmPos.position, Quaternion.identity);
        }
    }


    private void OnMouseUp()
    {
        mouseButtonReleased = true;
    }

    private Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
