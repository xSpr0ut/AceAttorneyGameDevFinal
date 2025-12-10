VAR current_statement = ""
VAR current_ce = ""
-> Trial3

== Trial3 ==
#mode Normal
#speaker Judge
#bg judge
Thank you for your testimony, Mister Kanna. Why don’t we proceed onto the next witness?

This being the… fan we mentioned earlier?

#speaker Arthur
#bg prosecution
#expression talk
Yes, she just arrived. Please take the stand and introduce your name and occupation.

#speaker Dillie
#bg witness
Hello! OMG, this is my first time ever being in court, I’m like super-duper excited but nervous.

But anyway, I’m Dillie, I’m currently a first-year student studying at community college, and I work as a shelf stocker as a side hustle, which is so BORING!

I’m still so, so mad someone killed my idol Madeline! I have all her merch, I spent the entire night crying, and the night after, and the night after that…

#speaker Arthur
#bg prosecution
We called you here because a fan letter was found backstage with your name and number on it.

#expression talk
Is it true you were the one who wrote and delivered it?

#speaker Dillie
#bg witness
Yes, that was 100% me! 

#speaker Anna
#bg defence
#expression think
Quick question. 

#expression talk
You went in at a time when the police were patrolling the area. You didn’t even encounter any of them backstage?

#speaker Dillie
#bg witness
Well, I actually did, but they actually saw me enter the backstage and were chasing after me. But I didn’t get arrested so that’s good!

#speaker Anna
#bg defence
That makes sense. The people who were apprehended were all people who could’ve been backstage at the time of the murder.

#expression object
So this witness was seen entering backstage after the murder happened.

#speaker Arthur
#bg prosecution
Witness, please tell the court what you witnessed during your trip backstage.

#speaker Dillie
#bg witness
Okie-dokie, I gotcha'!

#speaker Anna
#bg defence
#expression think
\*What an eccentric character. Hopefully she doesn’t make my job too hard.*

-> Dillie_Witness_Testimony_1


== Dillie_Witness_Testimony_1 ==
#mode WitnessTestimony
#speaker Dillie
#bg witness
That day, I had a once-in-a-lifetime opportunity to sneak backstage to meet Madeline!

When the announcer said the show was cancelled, I checked the beauty room, but she wasn’t there. But when I was on my way out, I saw Nadine walking the other direction down the hallway.

She and Madeline are rivals, so I don’t really like her, but I still wanted to say hi! She seemed like she was in a hurry, though.

So I decided to write a letter on the spot, slip it under the door of the beauty room, and run out as fast as I can! I did the first two parts, but the police escorted me out.

Um… That’s all I know… Can I go now?

-> Dillie_Cross_Examination_1


== Dillie_Cross_Examination_1 ==
~current_ce = "Dillie_CE1"

#mode CrossExamination
#speaker Dillie
#bg witness
#expression default

->A1

== A1 ==
#mode CrossExamination
#speaker Dillie
#bg witness
~ current_statement = "CE1_L1"
That day, I had a once-in-a-lifetime opportunity to sneak backstage to meet Madeline Bain!
+ [Next]
    -> A2
-> DONE

== A2 ==
~ current_statement = "CE1_L2"
When the announcer said the show was cancelled, I checked the beauty room, but she wasn’t there. But when I was on my way out, I saw Nadine Kanna walking the other direction down the hallway.
+ [Previous]
    -> A1
+ [Next]
    -> A3
-> DONE

== A3 ==
~ current_statement = "CE1_L3"
She and Madeline are rivals, so I don’t really like her, but I still wanted to say hi! She seemed like she was in a hurry, though.
+ [Previous]
    -> A2
+ [Next]
    -> A4
-> DONE

== A4 ==
~ current_statement = "CE1_L4"
So I decided to write a letter on the spot, slip it under the door of the beauty room, and run out as fast as I can! I did the first two parts, but the police escorted me out.
+ [Previous]
    -> A3
+ [Next]
    -> A5
-> DONE

== A5 ==
~ current_statement = "CE1_L5"
Um… That’s all I know… Can I go now?
+ [Previous]
    -> A4
-> DONE

== WrongObjection1 ==
#mode Normal
#speaker Anna
#expression object
#bg defence
Your honor! There is a clear contradiction here...

#speaker Judge
#bg judge
I don't see a contradiction here...

#speaker Anna
#expression think
#bg defence
(...)
(I must have made a mistake...)
->A1


== Objection_CE1_L2 ==
#mode Normal
#speaker Anna
#bg defence
#expression think
Your Honor, there is something strange about the witness’s statement.

#expression talk
She said she saw my client leaving a bit after the show’s cancellation announcement, which was at 7:00.

#expression object
But this piece of evidence clearly states my client was arrested by police at 6:45!

#speaker Dillie
#bg witness
What? B-But, I clearly saw her, I pinky-promise! Why would I lie about something like this?

#speaker Anna
#bg defence
#expression talk
Are you sure it was after the show’s cancellation announcement?

#speaker Dillie
#bg witness
Yeah, I’m super duper certain! That was my queue to sneak in.

#speaker Anna
#bg defence
#expression object
Are you sure the person you saw was my client, and not someone who just looked like her?

#speaker Dillie
#bg witness
Um, yes!

I mean, well, now that I think about it, it all happened so fast, I’m not even so sure anymore...

#speaker Anna
#bg defence
#expresion default
Well then, do you think you can describe in detail the appearance of the person you saw?

#speaker Dillie
#bg witness
Nadine Kanna, just Nadine Kanna! But if you want super-details… I guess I’ll try to recall…

#speaker Anna
#bg defence
#expression think
(There must be something peculiar about what Dillie saw. I need to focus!)

-> Dillie_Witness_Testimony_2

== Dillie_Witness_Testimony_2 ==
#mode WitnessTestimony
#speaker Dillie
#bg witness
I didn’t get a good look at her, only a very brief glimpse of her backside.

But I could recognize her! A superfan like me could tell with no doubt from miles away!

She was fitted fully from head to toe, donning her glamorous dress and sunhat. I could never forget it.

Gosh, I regret not chasing after her! I should’ve asked for a selfie and asked her to sign my face.


#speaker Anna
#bg defence
#expression think
(No, I don’t doubt the witness. There has to be something going on.)
-> Dillie_Cross_Examination_2

== Dillie_Cross_Examination_2 ==
~current_ce = "Dillie_CE2"
~ current_statement = ""
#mode CrossExamination
#speaker Dillie
#bg witness
#expression default

->B1

== B1 ==
#mode CrossExamination
#speaker Dillie
#bg witness
~ current_statement = "CE2_L1"
I didn’t get a good look at her, only a very brief glimpse of her backside.
+ [Next]
    -> B2
-> DONE

== B2 ==
~ current_statement = "CE2_L2"
But I could recognize her! A superfan like me could tell with no doubt from miles away!
+ [Previous]
    -> B1
+ [Next]
    -> B3
-> DONE

== B3 ==
~ current_statement = "CE2_L3"
She was fitted fully from head to toe, donning her glamorous dress and sunhat. I could never forget it.
+ [Previous]
    -> B2
+ [Next]
    -> B4
-> DONE

== B4 ==
~ current_statement = "CE2_L4"
Gosh, I regret not chasing after her! I should’ve asked for a selfie and asked her to sign my face.
+ [Previous]
    -> B3
-> DONE

== WrongObjection2 ==
#mode Normal
#speaker Anna
#expression object
#bg defence
Your honor! There is a clear contradiction here...

#speaker Judge
#bg judge
I don't see a contradiction here...

#speaker Anna
#expression think
#bg defence
(...)
(I must have made a mistake...)
->B1

== Objection_CE2_L3 ==
#mode Normal
#speaker Anna
#bg defence
#expression object
I would like to address something about this photo that isn’t the obvious timestamp contradiction.

#expression think
(There is a possibility that…)
-> Choice_1

== Choice_1 ==
* [The witness remembered the time wrong]
    -> WrongChoice_1
* [The witness mistook the victim for someone else]
    -> WrongChoice_1
+ [Someone was impersonating the victim]
    -> CorrectChoice_1

== WrongChoice_1 ==
#speaker Anna
#bg defence
#expression think
(no that can't be right...)
-> Choice_1

== CorrectChoice_1 ==
#speaker Anna
#bg defence
Your Honor, the witness is telling the truth. There is one possible answer to why she saw my client after her arrest.

#speaker Judge
#bg judge
And what could that be?

#speaker Anna
#bg defence
#expression object
That person she saw…wasn’t my client!

#expression default
It was someone donning her signature dress and sunhat.

And that person has to be the real culprit of this case.

#speaker Arthur
#bg prosecution
#expression talk
What? Ridiculous! Pfft… you’re saying someone played dress up with your defendant to frame her and get away?

That only happens in crime skits and comic books!

#speaker Anna
#bg defence
#expression default
Oh, Mr. Splanoir, with all the times I’ve been prepared to back up my claim throughout this trial, you need to learn to accept I’m just better than you.

The is one piece of evidence that proves the person the witness saw was not my client.

#expression object
In fact, everyone already saw the piece of evidence. It’s the Paparazzi Photo, but everyone glazed over a small detail.

The detail is:
-> Choice_2

== Choice_2 ==
* [The timestamp on that photo]
    -> WrongChoice_2
+ [Nadine's sunhat]
    -> WrongChoice_2
* [Nadine's gloves]
    -> CorrectChoice_2
    
== WrongChoice_2 ==
#speaker Anna
#bg defence
#expression think
(no that can't be right...)
-> Choice_2

== CorrectChoice_2 ==
#speaker Anna
#bg defence
#expression think
My client, Nadine Kanna, has an iconic one-of-kind signature designer sunhat.

#expression default
Her sunhat is missing in that photo where she got arrested, meaning she probably never got to retrieve it from the beauty room!

#expression object
And Dillie, if you saw someone else wear that hat, they’re an impersonator, and they’re the one who has my client’s sunhat!

#speaker Judge
#bg judge
What a neat observation! 

#speaker Anna
#bg defence
Wait. Dillie. Hold on…

#speaker Dillie
#bg witness
Huh? What is it?

#speaker Anna
#bg defence
#expression think
You’re saying the person you saw… they were walking towards the other direction of the hallway…

#speaker Dillie
#bg witness
Yep! I figured they came from the beauty room, so that’s why I slipped my letter under there.

#speaker Anna
#bg defence
#expression think
…! So according to what you just said…

Someone was in the beauty room after the murder happened?

#speaker Arthur
#bg prosecution
#expression talk
That can’t be, the police cleared the area!

#speaker Anna
#bg defence
#expression object
That’s the only way that could be possible!  
Someone was hiding in there, dressed up as my client, then snuck out somewhere during that time window!

#speaker Arthur
#bg prosecution
#expression default
How did the police not catch them when they found the body?

#speaker Anna
#bg defence
#expression think
That… I don’t know.  
But that’s the only way the witness’s testimony could make sense.

Your Honor, I propose we call up the next witness.  
Maybe that will help us get to the bottom of this.

#speaker Judge
#bg judge
Sure thing.  
Thank you for testifying, witness, you are excused.

Bailiff, call up the next witness.

#speaker Dillie
#bg witness
You’re so welcome! Justice for Madeline Bain!

-> END