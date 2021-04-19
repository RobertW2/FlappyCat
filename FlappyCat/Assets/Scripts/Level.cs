using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private const float CAMERA_ORTHO_SIZE = 50f;
    private const float PIPE_WIDTH = 7.8f;
    private const float PIPE_HEAD_HEIGHT = 3.75f;

    private void Start()
    {
        CreatePipe(50f, 0f);
        CreatePipe(50f, 20f);

    }

    private void CreatePipe(float height, float xPosition)
    {
        // Set up Pipe Head
       Transform pipeHead = Instantiate(GameAssets.GetInstance().pfPipeHead);
        pipeHead.position = new Vector3(xPosition, -CAMERA_ORTHO_SIZE + height - PIPE_HEAD_HEIGHT * 0.5f);

        // Set up Body
       Transform pipeBody = Instantiate(GameAssets.GetInstance().pfPipeBody);
        pipeBody.position = new Vector3(xPosition, -CAMERA_ORTHO_SIZE);

        SpriteRenderer pipeBodySpriteRender = pipeBody.GetComponent<SpriteRenderer>();
        pipeBodySpriteRender.size = new Vector2(PIPE_WIDTH, height);

        BoxCollider2D pipeBodyBoxCollider = pipeBody.GetComponent<BoxCollider2D>();
        pipeBodyBoxCollider.size = new Vector2(PIPE_WIDTH, height);
        pipeBodyBoxCollider.offset = new Vector2(0f, height * .5f);
    }
}
