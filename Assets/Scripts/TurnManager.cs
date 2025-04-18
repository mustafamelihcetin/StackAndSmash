using UnityEngine;

/// <summary>
/// Manages player turns and game phases.
/// </summary>
public class TurnManager : MonoBehaviour
{
    public enum GamePhase { Build, Smash }
    public GamePhase currentPhase = GamePhase.Build;

    public int currentPlayer = 1;
    public int currentTurn = 1;
    public int maxTurns = 3;

    void Start()
    {
        Debug.Log("Game started. Player 1 begins.");
    }

    public void NextTurn()
    {
        if (currentPhase == GamePhase.Build)
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
            if (currentPlayer == 1)
            {
                currentTurn++;
                if (currentTurn > maxTurns)
                {
                    currentPhase = GamePhase.Smash;
                    Debug.Log("Build phase complete. Smash phase begins.");
                    return;
                }
            }

            Debug.Log($"Player {currentPlayer}'s turn. Turn {currentTurn}");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextTurn();
        }
    }
}