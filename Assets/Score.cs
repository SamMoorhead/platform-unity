using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //1
public class Score : MonoBehaviour
{
public Text scoreText; //2
private int score = 0; //3
// Start is called before the first frame update
void Start()
{
}
// Update is called once per frame
void Update()
{
}
void OnTriggerEnter2D(Collider2D col) //4
{
if (col.gameObject.tag == "gem" || col.gameObject.tag == "Cherry") //5
{
score += 10; //6
scoreText.text = "Score: " + score;
}
}
}