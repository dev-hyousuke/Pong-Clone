using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScore; 
    public Text computerScore;

    private int _playerScore;
    private int _computerScore;

    private bool RestartGame() => Input.GetKey(KeyCode.R);

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (RestartGame())
            NewGame();
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void PlayerScores()
    {
        SetPlayerScore(_playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(_computerScore + 1);
        StartRound();
    }
    
    private void StartRound()
    {
        ResetBall();
        ResetPaddles();
    }

    private void SetPlayerScore(int score)
    {
        _playerScore = score;
        playerScore.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        _computerScore = score;
        computerScore.text = score.ToString();
    }

    private void ResetBall()
    {
        ball.ResetBallPosition();
        ball.AddStartingForce();
    }

    private void ResetPaddles()
    {
        playerPaddle.ResetPaddlePosition();
        computerPaddle.ResetPaddlePosition();
    }
}
