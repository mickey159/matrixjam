using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MatrixJam.Team10
{
    public class DarkRoom : MonoBehaviour
    {
        public GameObject Panel;
        public Text PanelTitle;
        public Text PanelMessage;
        public GameObject PanelInput;
        public Button PanelButton;

        private List<string[]> DeathList;
        
        public void cinema(string game){
            Panel.SetActive(true);
        }

        public void leave(){
            Panel.SetActive(false);
        }

        // public void startScene(){
        //     Panel.SetActive(true);
        //     PanelTitle.gameObject.SetActive(true);
        //     PanelMessage.gameObject.SetActive(true);
        //     PanelInput.SetActive(true);
        //     PanelButton.gameObject.SetActive(true);

        //     PanelTitle.text = "a day in a life - 2020 edition";
        //     // PanelButton.text = "start";
        //     StartCoroutine(TypeMessegeAffect(new string[] {"just another day in life...",
        //         "living with roommates", "and playing around", "waiting for 2021..", "hopefully it will be better then now..."}));
        // }

        // public void DeathScene(int deathId, bool isRoommate, bool isBossCorona){
        //     Panel.SetActive(true);
        //     PanelMessage.gameObject.SetActive(true);
        //     PanelButton.gameObject.SetActive(true);

        //     // exitNum = id;
        //     PanelMessage.text = "";
        //     // PanelButton.text = "move on";
        //     // StartCoroutine(TypeMessegeAffect(deathList[id]));
        // }

        // // IEnumerator TypeMessegeAffect(string[] sentences){
        // //     foreach(string sentence in sentences){
        // //         foreach (char letter in sentence.ToCharArray())
        // //         {
        // //             PanelMessage.text += letter;
        // //             // yield return new WaitForSeconds(typingSpeed);
        // //         }
        // //         PanelMessage.text += "\n";
        // //     }
        // // }

        // private List<string[]> DeathListGen(){
        //     List<string[]> a = new List<string[]>();
        //     //clean - did not get cleaned as needed
        //     a.Add(new string[] { "you dirty maggot! don't you know it's 2020!!!", "you should, at the very least, wash your hands.",
        //         "now look, you got the corona virus. are you happy?","well, too bad, we dont care.","anyways, you died..."});
        //     //hunger - not eating
        //     a.Add(new string[] { "just because it's a game,", "it does not mean you can starve your character.",
        //         "poor <name>, it died of starvation...." , "and so young..." , "btw", "that's also means you died" });
        //     //work - getting fired
        //     a.Add(new string[] { "you do realize you need to work in order to pay rent, rright???", "cause you got fired, couldn't pay your bills",
        //         "and now you are homeless... with corona... and dead...", "obviously, since we gave up on you",
        //         "cause you don't work and we don't like that...", "welph, at least it didnt happen in real life, rightt?" });
        //     //killOrder - rommate dont like the way you talk
        //     a.Add(new string[] {"your roommates got annoyed with you", "and decieded to throw you out of the apartment...",
        //         "welll.... you know the drill...", "you met a corona zombie, got infected and died.", "now go away...", "i'm trying to take a nap here....."});
        //     //paranoia - reapeting similar actions 6 times
        //     a.Add(new string[] { "you are seriously paranoid and should get that checked...",
        //         "anyways, this paranoia of yours didn't help and you still got the corona virus.", "you died!" });
        //     //win
        //     a.Add(new string[] { "congratulations!", "you made it till the end", "but just to make sure, you didn't cheat right?",
        //         "i mean, we made it extremely difficult, you see...", "anyways, you won - you, your roommate, and ect.",
        //         "we have other ending, you should check it out" });
        //     //sleep (repeat)
        //     a.Add(new string[] {"zzzzzz", "we love sleeping, don't we?", 
        //         "it's such a lovely thing", "but guess what?",
        //         "like in real life, you can also die here from oversleeping",
        //         "like we said.... you died"});
        //     //hide (repeat)
        //     a.Add(new string[] {"life is such a mysterious thing", 
        //         "you see... some things are necessary in life even if we think otherwise",
        //         "one of them is the air we breathe",
        //         "so you died... since you didn't want to come out of the closet...."});
        //     //play (repeat)
        //     a.Add(new string[] {"wow...", "even inside a game, you are totally binge gaming...",
        //         "this is trully the case of a character taking after it's player",
        //         "go on - move on to the next game", "we won't stop you"});
        //     //world crash (instaDeath)
        //     a.Add(new string[] {"we have an existentail crisis here",
        //         "you have done something others wouldn't dare!!", 
        //         "due to your thoughtless action, the entire worlds is now collapsing",
        //         "way to go, bro... you just killed everyone else with you",
        //         "are you happy?"});
        //     // ---------------- 10 ---------------------
        //     //leave house (instaDeath)
        //     a.Add(new string[] {"excuse me?", "did you think it's 2019,",
        //         "that you can just leave the house? no way!",
        //         "you got corona now", "andd~ you died"});
        //     // matrix - 2 pills
        //     a.Add(new string[] {"you died from pill overdose","just because it's still there",
        //         "does not mean you should take it"});
        //     // corona \ batman - special end
        //     a.Add(new string[] {"Boss corona", "we concoured the world", "everyone is infected and zombiefied",
        //         "good luck in your next mission" });
        //     // roomate - special end
        //     a.Add(new string[] {"THIS IS A FARCE.",
        //     "you died but you got a clone in another room so in the end you did survive.", "minus one clone though"});
        //     return a;
        // }
    }
}