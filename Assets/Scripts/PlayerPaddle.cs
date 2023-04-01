using UnityEngine;

public class PlayerPaddle : Paddle
{
    public Vector2 direction { get; private set; }

    private bool MoveUp() => Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
    private bool MoveDown() => Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);

    private void Update()
    {
        MovePlayer();
    }

    private void FixedUpdate()
    {
        AddMoveForce();
    }

    private void MovePlayer()
    {
        if (MoveUp())
            direction = Vector2.up;
        else if (MoveDown())
            direction = Vector2.down;
        else
            direction = Vector2.zero;
    }

    private void AddMoveForce()
    {
        var sqr = direction.sqrMagnitude != 0;

        if (sqr)
            _rigidbody.AddForce(direction * speed);
    }
}
