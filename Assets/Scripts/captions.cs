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
    private bool isNext;
    private Queue<string> lyrics;
    // Start is called before the first frame update
    void Start()
    {
        this.captionTextLine = this.GetComponent<TextMeshProUGUI>();
        this.isNext = false;
        lyrics = new Queue<string>();
        // This way is so stupid. I will never do this again. 
        lyrics.Enqueue("I don't understand");
        lyrics.Enqueue("I can't ever find it");
        lyrics.Enqueue("Not the right answer, not what normal is");
        lyrics.Enqueue("It's in a place where I can't reach it");

        lyrics.Enqueue("And the spring that embraced the pools of sunlight...");
        lyrics.Enqueue("Feels like it will disappear because the summer shines too brightly");
        lyrics.Enqueue("If I'm just going to end up withered and dry on the asphalt,");
        lyrics.Enqueue("Then I wish I'd stayed hidden under the rocks");

        lyrics.Enqueue("I destroyed it all again");
        lyrics.Enqueue("I didn't want to lose it, I didn't want to forget it");
        lyrics.Enqueue("But I wasn't strong enough and I ended up letting go...");
        lyrics.Enqueue("Even though I knew that it was important");
        lyrics.Enqueue("Oh, everything's ended up a mess,");
        lyrics.Enqueue("But if everything hasn't disappeared yet... then I want to go back");
        lyrics.Enqueue("I want to tell them");
        lyrics.Enqueue("If it's allowed, then I don't want to give up!");

        lyrics.Enqueue("I didn't want anyone to find me");
        lyrics.Enqueue("But being with you made me so very happy");
        lyrics.Enqueue("And I haven't told you that, so...");
        lyrics.Enqueue("So, please...");
        lyrics.Enqueue("I didn't want to hurt anyone");
        lyrics.Enqueue("I didn't want to leave you this way");
        lyrics.Enqueue("What should I do?");
        lyrics.Enqueue("The words I couldn't say... are still words I want to reach you!");

        lyrics.Enqueue("The song I sing; I'll sing it now");
        lyrics.Enqueue("Please reach all the way to your heart");
        lyrics.Enqueue("Is there still time?");
        lyrics.Enqueue("I'll scream my heart, so that I can get past the words");
        lyrics.Enqueue("Because this is the only way I can do it");
        lyrics.Enqueue("I'll keep singing until it reaches you");

        lyrics.Enqueue("I want to cry together");
        lyrics.Enqueue("I want to laugh together");
        lyrics.Enqueue("Even if our paths only run parallel");
        lyrics.Enqueue("Still holding tightly to yesterday");
        lyrics.Enqueue("Trembling with a throbbing pain");
        lyrics.Enqueue("The more it hurts, the more your emotions came through, so I won't leave you");

        lyrics.Enqueue("I'll sing this song that will link my hands with yours");
        lyrics.Enqueue("I don't want to let go, let's stay together forever");
        lyrics.Enqueue("I'll sing this song that will help us become ourselves");
        lyrics.Enqueue("I'll sing and let's begin here one more time");
    }

    // Update is called once per frame
    void Update()
    {
        if (isNext)
        {
            isNext = false;
            this.captionTextLine.SetText(lyrics.Dequeue());
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            NextLine();
        }
    }

    // NextLine is called when the camera following object enters the next region
    // Discarded function
    public void NextLine()
    {
        isNext = true;
    }
}
