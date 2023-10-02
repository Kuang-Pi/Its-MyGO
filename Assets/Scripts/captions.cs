using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class captions : MonoBehaviour
{
    /*
     * This is script is use to control the change of the 
     */
    private TextMeshProUGUI captionTextLine;
    private float cd;
    private Queue<string> lyrics;
    private Queue<float> pitchs;
    // Start is called before the first frame update
    void Start()
    {
        this.captionTextLine = this.GetComponent<TextMeshProUGUI>();
        // This way is so stupid. I will never do this again. 
        cd = 15.95f;
        pitchs = new Queue<float>();

        lyrics = new Queue<string>();
        lyrics.Enqueue("I don't understand");
        pitchs.Enqueue(2.16f);
        lyrics.Enqueue("I can't ever find it");
        pitchs.Enqueue(2.65f);
        lyrics.Enqueue("Not the right answer, not what normal is");
        pitchs.Enqueue(5.58f);
        lyrics.Enqueue("It's in a place where I can't reach it");
        pitchs.Enqueue(2.931f);

        lyrics.Enqueue("And the spring that embraced the pools of sunlight...");
        pitchs.Enqueue(2.539f);
        lyrics.Enqueue("Feels like it will disappear because the summer shines too brightly");
        pitchs.Enqueue(3.67f);
        lyrics.Enqueue("If I'm just going to end up withered and dry on the asphalt,");
        pitchs.Enqueue(2.73f);
        lyrics.Enqueue("Then I wish I'd stayed hidden under the rocks");
        pitchs.Enqueue(4.99f);

        lyrics.Enqueue("");
        pitchs.Enqueue(18.6f);

        lyrics.Enqueue("I destroyed it all again");
        pitchs.Enqueue(2.89f);
        lyrics.Enqueue("I didn't want to lose it, I didn't want to forget it");
        pitchs.Enqueue(2.76f);
        lyrics.Enqueue("But I wasn't strong enough and I ended up letting go...");
        pitchs.Enqueue(2.79f);
        lyrics.Enqueue("Even though I knew that it was important");
        pitchs.Enqueue(2.66f);
        lyrics.Enqueue("Oh, everything's ended up a mess,");
        pitchs.Enqueue(2.24f);
        lyrics.Enqueue("But if everything hasn't really disappeared yet... then I want to go back");
        pitchs.Enqueue(3.17f);
        lyrics.Enqueue("Then I want to get it back!");
        pitchs.Enqueue(1.49f);
        lyrics.Enqueue("I want to tell them");
        pitchs.Enqueue(2.3f);
        lyrics.Enqueue("If it's allowed, then I don't want to give up!");
        pitchs.Enqueue(1.83f);

        lyrics.Enqueue("I didn't want anyone to find me");
        pitchs.Enqueue(2.18f);
        lyrics.Enqueue("But being with you made me so very happy");
        pitchs.Enqueue(3.71f);
        lyrics.Enqueue("And I haven't told you that, so...");
        pitchs.Enqueue(2.39f);
        lyrics.Enqueue("So, please...");
        pitchs.Enqueue(1.26f);
        lyrics.Enqueue("I didn't want to hurt anyone");
        pitchs.Enqueue(2.29f);
        lyrics.Enqueue("I didn't want to leave you this way");
        pitchs.Enqueue(2.73f);
        lyrics.Enqueue("What should I do?");
        pitchs.Enqueue(2.17f);
        lyrics.Enqueue("The words I couldn't say... are still words I want to reach you!");
        pitchs.Enqueue(5.41f);

        lyrics.Enqueue("");
        pitchs.Enqueue(9.4f);

        lyrics.Enqueue("The song I sing; I'll sing it now");
        pitchs.Enqueue(6.08f);
        lyrics.Enqueue("Is there still time to reach all the way to your heart? ");
        pitchs.Enqueue(3.88f);
        lyrics.Enqueue("I'll scream my heart, so that I can get past the words");
        pitchs.Enqueue(3.25f);
        lyrics.Enqueue("Because this is the only way I can do it");
        pitchs.Enqueue(4.75f);
        lyrics.Enqueue("I'll keep singing until it reaches you");
        pitchs.Enqueue(2.81f);

        lyrics.Enqueue("");
        pitchs.Enqueue(22.57f);

        lyrics.Enqueue("I want to cry together");
        pitchs.Enqueue(2.65f);
        lyrics.Enqueue("I want to laugh together");
        pitchs.Enqueue(2.58f);
        lyrics.Enqueue("Even if our paths only run parallel");
        pitchs.Enqueue(5.07f);
        lyrics.Enqueue("Still holding tightly to yesterday");
        pitchs.Enqueue(2.39f);
        lyrics.Enqueue("Trembling with a throbbing pain");
        pitchs.Enqueue(2.61f);
        lyrics.Enqueue("The more it hurts, the more your emotions came through, so I won't leave you");
        pitchs.Enqueue(5.89f);
        
        lyrics.Enqueue("");
        pitchs.Enqueue(13.18f);

        lyrics.Enqueue("I'll sing this song that will link my hands with yours");
        pitchs.Enqueue(6.75f);
        lyrics.Enqueue("I don't want to let go, let's stay together forever");
        pitchs.Enqueue(6.42f);
        lyrics.Enqueue("I'll sing this song that will help us become ourselves");
        pitchs.Enqueue(8.05f);
        lyrics.Enqueue("I'll sing and let's begin here one more time");
        pitchs.Enqueue(9.19f);

        lyrics.Enqueue("");
        pitchs.Enqueue(16.41f);
    }

    // Update is called once per frame
    void Update()
    {
        if(cd > 0){ cd -= Time.deltaTime; }
        if (cd<=0)
        {
            try
            {
                this.captionTextLine.SetText(lyrics.Dequeue());
            }
            catch (System.Exception e)
            {
                Application.Quit();
            }
            try
            {
                cd = pitchs.Dequeue();
            }
            catch (System.Exception e)
            {
                Application.Quit();
            }
        }
    }
}
