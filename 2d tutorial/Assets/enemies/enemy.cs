using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] GameObject _gameState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * _speed, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Player")
            gameState.Instance.InitiateGameOver();

        Destroy(collision.gameObject);
        gameState.Instance.IncreaseScore(10);

        Destroy(gameObject);
    }
}
