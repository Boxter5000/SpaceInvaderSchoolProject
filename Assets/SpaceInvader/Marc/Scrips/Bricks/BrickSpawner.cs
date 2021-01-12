using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickSpawner : MonoBehaviour
{
    public Brick brickPrefab;

    public int columns = 1; // x-coordinate
    public int rows = 1;    // y-coordinate

    public float xOffset = 1f;
    public float yOffset = 1f;

    private void Start()
    {
        SpawnBricks();
    }

    public void OnBeforeBrickDestroyed(Brick brick)
    {
        // Debug.Log(brick.gameObject.name + " was destroyed. " + (transform.childCount - 1) + " Bricks left.");

        if (transform.childCount <= 1)
        {
            Debug.Log("END");
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        // get current scene build index
        int buildIndex = SceneManager.GetActiveScene().buildIndex;

        // get target scene build index
        buildIndex++;

        // is target scene build index out of bounds?
        if (buildIndex >= SceneManager.sceneCountInBuildSettings)
        {
            buildIndex = 0;
        }

        // load target scene
        SceneManager.LoadScene(buildIndex);
    }

    void SpawnBricks()
    {
        Vector3 startPosition = transform.position - ((Vector3.right * xOffset * (columns - 1)) + (Vector3.down * yOffset * (rows - 1))) / 2f;

        Brick newBrick;

        for (int y = 0; y < rows; y++) // rows
        {
            for (int x = 0; x < columns; x++) // columns
            {
                newBrick = Instantiate(
                    original: brickPrefab,
                    position: startPosition + (Vector3.right * xOffset * x) + (Vector3.down * yOffset * y),
                    rotation: Quaternion.identity,
                    parent: transform
                    );

                newBrick.gameObject.name = $"Brick({x}|{y})";

                newBrick.SetBrickSpawner(this);
            }
        }
    }

    private void OnValidate()
    {
        columns = Mathf.Clamp(columns, 1, columns);
        rows = Mathf.Clamp(rows, 1, rows);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.matrix = transform.localToWorldMatrix; // draws gizmos in local space from here on

        Gizmos.color = Color.green;

        Vector3 startPosition = -((Vector3.right * xOffset * (columns - 1)) + (Vector3.down * yOffset * (rows - 1))) / 2f;

        for (int y = 0; y < rows; y++) // rows
        {
            for (int x = 0; x < columns; x++) // columns
            {
                Gizmos.DrawWireCube(
                    center: startPosition + (Vector3.right * xOffset * x) + (Vector3.down * yOffset * y),
                    size: new Vector3(1f, 0.5f, 0)
                    );
            }
        }
    }
}
