using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BallMovement Ball;
    public Text LeftPlayerScoreText;
    public Text RightPlayerScoreText;
    public PaddleMovement LeftPaddle;
    public PaddleMovement RightPaddle;

    private int _leftPlayerScore;
    private int _rightPlayerScore;

    public void LeftPlayerScores()
    {
        _leftPlayerScore++;
        LeftPlayerScoreText.text = _leftPlayerScore.ToString();
        ResetRound();
    }

    public void RightPlayerScores()
    {
        _rightPlayerScore++;
        RightPlayerScoreText.text = _rightPlayerScore.ToString();
        ResetRound();
    }

    public void ResetRound()
    {
        Debug.Log($"Player scored! Score: {_leftPlayerScore} - {_rightPlayerScore}");

        LeftPaddle.ResetPosition();
        RightPaddle.ResetPosition();
        Ball.ResetPosition();
        Ball.AddStartingForce();
    }

    public void ResetScore()
    {
        _leftPlayerScore = 0;
        _rightPlayerScore = 0;
        LeftPlayerScoreText.text = _leftPlayerScore.ToString();
        RightPlayerScoreText.text = _rightPlayerScore.ToString();
        Debug.Log("Score reset!");
    }

}
