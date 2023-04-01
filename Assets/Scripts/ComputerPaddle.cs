using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private bool isBallMovingTowardsPaddle() => ball.velocity.x > 0.0f;

    private void FixedUpdate()
    {
        MoveComputerPaddle();
    }

    private void MoveComputerPaddle()
    {
        if (isBallMovingTowardsPaddle())
            TrackBall();
        else
            Idle();
    }

    private void TrackBall()
    {
        if (ball.position.y > transform.position.y)
            _rigidbody.AddForce(Vector2.up * speed);
        else if (ball.position.y < transform.position.y)
            _rigidbody.AddForce(Vector2.down * speed);
    }

    private void Idle()
    {
        if (transform.position.y > 0.0f)
            _rigidbody.AddForce(Vector2.down * speed);
        else if (transform.position.y < 0.0f)
            _rigidbody.AddForce(Vector2.up * speed);
    }
}
