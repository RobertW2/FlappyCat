using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{

   
    private Text ScoreText;
    // private Text scoreText;

    // private void Awake()
    //  {
    //    ScoreText = transform.Find("ScoreText").GetComponent<Text>();

    //   transform.Find("RetryButton").GetComponent<Button>().onClick
    // }


    //   public Button yourButton;
    //
    void Start()
    {
        //       Button btn = yourButton.GetComponent<Button>();
        //       btn.onClick.AddListener(TaskOnClick);
        //
        Bird.GetInstance().OnDied += Bird_OnDied;
        b.onClick.AddListener(TaskOnClick);
               Hide();
        //   }
        //
        //   void TaskOnClick()
        //   {
        //       UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene"); 
           }
        //
        private void Bird_OnDied(object sender, System.EventArgs e)
        {
      //      ScoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
            Show();
        }

        private void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
    


    public Button b;

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
