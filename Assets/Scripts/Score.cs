
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (player.position.z >= 0)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
