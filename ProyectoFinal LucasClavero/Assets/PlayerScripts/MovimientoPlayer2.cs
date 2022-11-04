using UnityEngine;

public class MovimientoPlayer2 : MonoBehaviour
{
    public Rigidbody RbPlayer;
    float Speedmovimiento;
    public float JumpForce;
    bool Floor = false;
    float Cooldown = 0f;
    float left;
    float right;
    float top;
    float bottom;

    void FixedUpdate()
    {
        MovimientoPlayer();
    }

    void MovimientoPlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left = -1;
        }
        else 
        {
            left = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            right = 1;
        }
        else
        {
            right= 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            top = 1;
        }
        else
        {
            top = 0;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            bottom = -1;
        }
        else
        {
            bottom = 0;
        }
        float x = left + right;
        float z = top+ bottom;
        RbPlayer.AddForce(x * Speedmovimiento, 0, z * Speedmovimiento);
        if (x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (z > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (z < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (x > 0 && z > 0)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        if (x < 0 && z < 0)
        {
            transform.rotation = Quaternion.Euler(0, 225, 0);
        }
        if (x < 0 && z > 0)
        {
            transform.rotation = Quaternion.Euler(0, 315, 0);
        }
        if (x > 0 && z < 0)
        {
            transform.rotation = Quaternion.Euler(0, 135, 0);
        }
        if (Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            Floor = true;
            Cooldown -= Time.deltaTime;
            Speedmovimiento = 150;

        }
        else
        {
            Floor = false;
            Speedmovimiento = 70;
        }
        if (Floor == true && Input.GetKey(KeyCode.X) && Cooldown < 0)
        {
            RbPlayer.AddForceAtPosition(Vector3.up * JumpForce, transform.position, ForceMode.Impulse);
            Cooldown = 0.2f;
        }

        Debug.Log(Speedmovimiento);
    }
}

