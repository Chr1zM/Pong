using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallMovement Ball;

    private int _leftPlayerScore;
    private int _rightPlayerScore;

    public void LeftPlayerScores()
    {
        _leftPlayerScore++;
        Debug.Log($"Left player scored! Score: {_leftPlayerScore}");
        Ball.ResetBall();
    }

    public void RightPlayerScores()
    {
        _rightPlayerScore++;
        Debug.Log($"Right player scored! Score: {_rightPlayerScore}");
        Ball.ResetBall();
    }
}
