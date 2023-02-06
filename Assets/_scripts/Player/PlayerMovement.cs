using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rgb2D;
    public Vector2 Velocity = new Vector2(0f, 1f);
    public float pressHorizontal = 0;
    public float pressVertical = 0;
    public float SpeedUp = 0.5f;
    public float SpeedDown = 0.5f;
    public float SpeedMax = 10f;
    public float SpeedHorizontal = 3f;
    public bool AutoRun = false;
    private void Awake()
    {
        rgb2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        this.SpeedUpdate();
    }
    private void Update()
    {
        pressHorizontal = Input.GetAxis("Horizontal");
        pressVertical = Input.GetAxis("Vertical");

        if (this.AutoRun) this.pressVertical = 1;
    }
    protected virtual void SpeedUpdate()
    {
        this.Velocity.x = this.pressHorizontal * this.SpeedHorizontal;
        //this.velocity.y = this.pressVertical;

        this.UpdateSpeedUp();
        this.UpdateSpeedDown();

        if (this.Velocity.y > this.SpeedMax) this.Velocity.y = this.SpeedMax;

        this.rgb2D.MovePosition(this.rgb2D.position + this.Velocity * Time.fixedDeltaTime);
    }
    void UpdateSpeedUp()
    {
        if (this.pressVertical <= 0) return;
        this.Velocity.y += this.SpeedUp;
        if (transform.position.x < -7 || transform.position.x > 7)
        {
            this.Velocity.y -= 1f;
            if (this.Velocity.y < 3f) this.Velocity.y = 3f;
        }
    }
    void UpdateSpeedDown()
    {
        if (this.pressVertical != 0) return;

        this.Velocity.y -= this.SpeedDown;
        if (this.Velocity.y < 0) this.Velocity.y = 0;
    }



}
