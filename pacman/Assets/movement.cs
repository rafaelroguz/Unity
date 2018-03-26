using UnityEngine;
using UnityEngine.UI;


public class movement : MonoBehaviour {
    public float speed;
    public Text scoreText;
    public Text winText;
    public Rigidbody2D rb;

    private int score;
    private int totalDots;

	// Use this for initialization
	void Start () {
        score = 0;
        totalDots = 56;
        scoreText.text = "Score: " + score.ToString();
        winText.text = "";
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            totalDots = totalDots - 1;
            scoreText.text = "Score: " + score.ToString();

            if (totalDots == 0)
            {
                winText.text = "You win!";
            }
        }
        else
        {
            if (other.gameObject.CompareTag("ghost"))
            {
                score = score - 5;
                scoreText.text = "Score: " + score.ToString();
                //other.gameObject.SetActive(false);

                if (score <= 0)
                {
                    winText.text = "You lost!";
                }
            }
        }
    }
}
