== OlafPhoneCall ==
#speaker Olaf
Hello? Who is this?

#speaker Anna
Hello, this is Anna Nyugen, the attorney on Madeline Bain’s case. I am calling to ask about your relationship with the victim.

#speaker Olaf
How did you get my contact?
-> OlafChoices1

== OlafChoices1 ==
+ [From Madeline's Manager]
    -> OlafPhoneCallContinued1
+ [From your sister]
    -> OlafPhoneCallContinued1
    
== OlafPhoneCallContinued1 ==
#speaker Olaf
I see… that makes sense. What would you like to know?
-> OlafChoices2

== OlafChoices2 ==
* [Record Conversation]
-> OlafRecordConversation
+ [Relationship with Victim]
-> OlafRelationshipWithVictim
+ [Where were you]
-> OlafWhereWereYou
+ [That's all.]
-> OlafPhoneEnd

== OlafRecordConversation ==
#speaker Anna
Before we begin, I would like to record this conversation and potentially use it in court. Do you consent to that?
-> OlafPhoneCallContinued1

== OlafRelationshipWithVictim ==
#speaker Anna
What is your relationship with the victim?

#speaker Olaf
Madeline was my lover… as you know. 

We met backstage at this exact gala a few years back, actually, which is why this all feels so… surreal. 

I can’t believe she is gone.

#speaker Anna
Were you two close then?

#speaker Olaf
Yes, but it was hard to meet as frequently as we would have liked.

I’m not a public figure, and if the public found out, there would be a scandal.

#speaker Anna

Was the victim aware of your relationship with my client?

#speaker Olaf
...

No.

-> OlafPhoneCallContinued1

== OlafWhereWereYou ==
#speaker Anna
Where were you on the day of the murder?

#speaker Olaf
I arrived at the gala as a guest and also to show my support for Madeline.

As my sister was also present, I went to meet with her. 

I was with her at the bar when I heard a ruckus about Madeline being missing.

I didn’t even get to talk to Madeline before her death…

#speaker Narrator
Olaf begins to tear up.
-> OlafPhoneCallContinued1

== OlafPhoneEnd ==
#speaker Anna
Thank you for your time… And I am sorry for your loss.

#speaker Olaf
Thank you.

#speaker Anna
Are you available to meet in person?

#speaker Olaf
Yes. Is there more to talk about? I can send you my schedule over text.

#speaker Anna
That would be appreciated. Thank you.

-> END

== DavidYellowPhoneCall ==
#speaker David
Hello. David speaking. Who am I talking to?

#speaker Anna
Hello, this is Anna Nyugen. I am calling to ask about Madeline—

#speaker David
Ah, yes. For business inquiries and payment, could you please send me an email instead?

#speaker Anna
Excuse me?

#speaker David
You’re calling about compensating me for my services, aren’t you?

-> DavidChoice1


== DavidChoice1 ==
* [No.] -> DavidNoPayment
   Choice_Attorney
* [Could we meet?] -> DavidMeetInPerson

== DavidNoPayment ==
#speaker Anna
 I’m Rae’s attorney. I’m calling to discuss your relationship with Madeline Bain.

#speaker David
I’m sorry. I think you have the wrong number.

-> END

== DavidMeetInPerson ==
#speaker Anna
Could we meet in person and discuss further?

#speaker David
Is Ms. Bain worried about leaving behind phone records?

Well, alright. I can meet you in person tomorrow.

Ms. Bain’s office, right?

#speaker Anna
Yes. 

#speaker David
Okay. See you then.
-> END


== FanPhoneCall==
#speaker Dillie
Hello?

#speaker Anna
Hello, this is Anna Nyugen speaking, the attorney on Madeline Bain’s case. I am calling to ask about—

#speaker Dillie
OMG! I know you! I saw you walking around just earlier today.

Did you call to ask about Madeline?

Did you know I’m a huge fan of hers? I’m Dillie Shino, by the way.

#speaker Anna
…

#speaker Dillie
You know, I was SO devastated by the news. I was so upset. I totally think Madeline was murdered.

I was a fan of her for such a long time, you know?

I would even sneak backstage to go see her! All the time!

My entire room is dedicated to her. She is the love of my life.

You must bring her justice. I’m sure it is her rival who did it!

#speaker Narrator
Sensing that you won’t be able to get your questions in like this, you decided to take a different approach.

#speaker Anna
Ms. Shino, would you be willing to discuss this more in-depth in person?

#speaker Dillie
OMG! Will you take me backstage? Will I get to see Madeline’s body? Can I say goodbye to her?

#speaker Anna
We can discuss what is appropriate when we meet.

#speaker Dillie
Just tell me when, I will be there!

#speaker Anna
I will text you the details.

#speaker Dillie
Oh, yes! Okay! Bye!
-> END

== DrLiuPhoneCall ==
#speaker Anna
Hello Dr. Liu! I heard that you have some new insight for the case?

#speaker Dr.Liu
Nice to hear from you again, Ms. Nyugen.

I can’t call you unless there’s an insight? 

Just kidding, haha. Of course I won’t.

Okay but before everything, I’d like to go through what we have on hand again. 

Now don’t argue with me— before the trial, you’ll have to make sure everything is in place. 

#speaker Anna
…

Okay ma’am.

#speaker Dr.Liu
Ma’am? I’m only three months older than you!

Anyways, at approximately 6:30 PM, February 8th, 20XX, Madeline Bain was found dead at the backstage of a gala.

She was found by her manager, Kaylee Smith, who witnessed Nadine Kanna, Bain’s famous public rival, fleeing the crime scene was also reported.

#speaker Anna
Ms. Kanna is my client. I know this well enough…

#speaker Dr.Liu
The police arrived shortly after, and so, they arrested Ms. Kanna.

#speaker Anna
And from what I’ve gathered, they also questioned and put under surveillance several others who are related to the victim and the suspected murderer.

#speaker Dr.Liu
And what I’m about to tell you came straight from my lab, about the victim.

First of all, we got a definite time of death for Bain. It was no earlier than 18:20 that night.

#speaker Anna
From what she told me and my speculation, Nadine and Kaylee saw the body at around that time! If only Madeline could hold on for a few more minutes...

#speaker Dr.Liu
Well that’s interesting because the second finding is that she died almost immediately after the attack from significant blood loss.

#speaker Anna
The death was immediate?

Do you have any info about the cause of death?

#speaker Dr.Liu
She died from significant blood loss. As for the murder weapon, I don't know yet.

We are still examining the wound and the presumable murder weapon. Before the results are out, I cannot give you any information.

However, I have something else for you.

The victim's knuckles are slightly bruised with scratches all over the hands. They all seemed to be formed before death.

#speaker Anna
\*What happened before her death? What was she punching?*

This is really important information! Thank you so much Dr. Liu!

#speaker Dr.Liu
You’re welcome. I’m glad I can help.

-> END

== EileenPhoneCall ==

#speaker Eileen
H-hello. This is Eileen Lour speaking. I’m not currently taking on new clients. May I ask who this is?

#speaker Anna
Hello, this is Anna Nyugen, the attorney on Madeline Bain’s case. I am calling to ask about your relationship with the victim.

#speaker Eileen
Oh… Yes. Kaylee mentioned you briefly.

#speaker Anna
Really? Kaylee didn’t tell me about you.

#speaker Eileen
Ah, well, my work isn’t that important.

#speaker Anna
That’s not true. Madeline wouldn’t have made it this far without you.

#speaker Eileen
…

#speaker Anna
My understanding is that Madeline was found in the makeup and dressing room.

#speaker Eileen
Yes… That- that is what Kaylee told me.

#speaker Anna
Do you know what she was doing there?

#speaker Eileen
I-I’m not sure. I think she wanted to do a quick touch-up.

#speaker Narrator
Sensing Eileen’s nervousness, you decide to ask to speak in person.

#speaker Anna
Would you be more comfortable speaking in person?

#speaker Eileen
Um…

#speaker Anna
We can meet in the makeup room-

#speaker Eileen
N-no! I don’t want to be there.

It’s scary being there.

#speaker Anna
I understand. I’m sure you find it very disturbing.

#speaker Anna
We can meet in Kaylee’s office then. Would that work for you?

#speaker Eileen
Y-yes. That’s okay.

#speaker Anna
Wonderful, I will see you then.

-> END

== NoAnswer ==
#speaker Narrator
You've reached ---- voice mail.

Please leave a message after the tone.

Beep!

-> END
