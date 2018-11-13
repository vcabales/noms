using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComplimentGenerator : MonoBehaviour {
    Text text;
    public string[] ComplimentList;
    public static System.Random rand = new System.Random();
    public int last;

    void Start () {
        // Quotes taken from http://emergencycompliment.com/, https://www.verywellmind.com/positivity-boosting-compliments-1717559, and sort of my brain
        ComplimentList = new string[] {
            "Your handshake conveys intelligence, confidence and minor claminess.",
            "Sushi chefs are wowed by your chopstick dexterity.",
            "Coworkers fantasize about getting stuck in the elevator with you.",
            "You never forget to fill the ice-cube tray, and I appreciate that so much.",
            "Your principal would call you to the office just to look cool.",
            "A doctor once saw your butt through the hospital gown. They approve!",
            "If you were a potato, you'd be a sweet potato.",
            "If cartoon bluebirds were real, a couple of 'em would be sitting on your shoulders singing right now.",
            "Being around you is like a happy little vacation.",
            "Actions speak louder than words, and yours tell an incredible story.",
            "You're gorgeous—and that's the least interesting thing about you, too.",
            "When you're not afraid to be yourself, that's when you're incredible.",
            "You're better than a triple-scoop ice cream cone. With sprinkles.",
            "If you were a box of crayons, you'd be the big industrial name-brand one with a built-in sharpener.",
            "Who raised you? They deserve a medal for a job well done.",
            "In high school, I bet you were voted \"most likely to continue being awesome.\"",
            "At least two friends are going to name their child and/or goldfish after you.",
            "I’d give you the last piece of my gum even if I’d just ate garlic.",
            "You are someone's \"the one that got away.\"",
            "You are freakishly good at thumb wars.",
            "You are freakishly good at this game.",
            "You could make up a weird religion or diet and everyone would follow it.",
            "Someone almost got a tattoo of your name once, but their mom talked them out of it.",
            "Everyone at sleepovers thought you were the bravest during thunderstorms.",
            "Some dudes hope you start a band so they can start a cover band of that band.",
            "Your siblings are pissed that your photo is the star of your parent's mantle.",
            "Are you from Tennessee? 'Cuz you're the only ten I see!",
            "People behind you at movies think you are the perfect height.",
            "80% of motorcycle gangs think you’d be a delightful sidecar.",
            "Everyone at the laundromat thinks you have the cutest underwear.",
            "You’re more of a superhero than any Marvel character out there.",
            "Whoa, who's that 12 outta 10 person lookin' this way!? Oh, wait. It's you. ;)",
            "A 3rd tier cable network would totally create a television show about you."
        };
        text = GetComponent<Text>();
        Debug.Log(text);
        int r = rand.Next(0, ComplimentList.Length);
        Debug.Log(r);
        last = r;
        text.text = ComplimentList[r];
    }
    public void GenerateNewCompliment() {
        Debug.Log("calling function");
        int r = rand.Next(0, ComplimentList.Length);
        text.text = ComplimentList[r];
        //if (r != last)
        //    text.text = ComplimentList[r];
        //else {
        //    if (r < ComplimentList.Length)
        //        r += 1;
        //    else
        //        r -= 1;
        //    text.text = ComplimentList[r];
        //}
        //last = r;
            
    }
}
