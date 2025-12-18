VAR current_statement = ""
VAR current_ce = ""
-> Trial1

== Trial1 ==
#mode Normal
#speaker Judge
#bg judge
Today is the trial of 29-year-old Nadine Kanna, celebrity artist, accused of the murder of 28-year-old celebrity artist Madeline Bain.

Prosecution, please deliver the case summary.

#speaker Arthur
#bg prosecution
#expression default
The murder took place on February 8th this year, in the Neapolitan Museum of Fine Art.

#expression talk
This was an annually hosted event for artists who’ve topped this year’s charts.

The show, specifically for the defendant and the victim, was scheduled for 7:00 PM that evening.

#expression default
However, it was cancelled when the victim’s corpse was discovered in the backstage beauty room.

She was found with her own hairpin lodged in her throat. Everyone backstage was apprehended and put under surveillance.

The defendant was found on the scene of the murder, being the top suspect. She also happened to have had a long-term career rivalry with the victim.

I do want to add that the defendant has previously alleged the victim of plagiarism to the public. So there’s your motive.

#expression talk
That is essentially the case summary. Your Honor, please proceed with the case.

#speaker Judge
#bg judge
Very well, the court is now in session. Please call up the first witness.

#speaker Arthur
#bg prosecution
Witness, please state your name and occupation.

#speaker Kaylee
#bg witness
My name is Kaylee Smith. I worked as Madeline Bain’s manager for almost three years.

#speaker Arthur
#bg prosecution
Now, please tell the court what you witnessed that day.

#speaker Kaylee
#bg witness
Yes, of course.

#speaker Anna
#bg defence
#expression think
She’ll definitely be testifying against my client! Here goes nothing.

-> Kaylee_Witness_Testimony_1
== Kaylee_Witness_Testimony_1 ==
#mode WitnessTestimony
#speaker Kaylee
#bg witness
The person who murdered Madeline Bain was undoubtedly no one other than Nadine Kanna.

The two got into a physical altercation before I entered the room.

I then saw Ms. Kanna ran out of the room. Ms. Bain was on the ground, bleeding out.

Ms. Bain looked at me with vengeance in her eyes during her final moments. I knew I had to bring Ms. Kanna to justice.

So in conclusion, Nadine murdered her. The case can rest.

#speaker Anna
#bg defence
#expression think
Wow, straight to the point, huh? She hasn’t even described what she saw properly.

Maybe there’s a slip-up somewhere?

-> Kaylee_Cross_Examination_1
== Kaylee_Cross_Examination_1 ==
~current_ce = "Kaylee_CE1"
#mode CrossExamination
#speaker Kaylee
#bg witness

->A1

== A1 ==
#mode CrossExamination
#speaker Kaylee
#bg witness
~ current_statement = "CE1_L1"
The person who murdered Madeline Bain was undoubtedly no one other than Nadine Kanna.
+ [Next]
    -> A2
-> DONE

== A2 ==
~ current_statement = "CE1_L2"
The two got into a physical altercation before I entered the room.
+ [Previous]
    -> A1
+ [Next]
    -> A3
-> DONE

== A3 ==
~ current_statement = "CE1_L3"
I then saw Ms. Kanna ran out of the room. Ms. Bain was on the ground, bleeding out.
+ [Previous]
    -> A2
+ [Next]
    -> A4
-> DONE

== A4 ==
~ current_statement = "CE1_L4"
Ms. Bain looked at me with vengeance in her eyes during her final moments. I knew I had to bring Ms. Kanna to justice.
+ [Previous]
    -> A3
+ [Next]
    -> A5
-> DONE

== A5 ==
~ current_statement = "CE1_L5"
So in conclusion, Nadine murdered her. The case can rest.
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


== Objection_CE1_L4 ==
#mode Normal
#speaker Arthur
#bg prosecution
#expression default
This case is over. We have a witness who states that the victim and defendant were in an altercation right before the victim’s death.

There is nobody else other than the defendant who is responsible for the victim’s death.

#speaker Anna
#bg defence
#expression object
Actually, Mr. Splanoir, we haven’t confirmed a few details yet.

Ms. Smith, you said Ms. Bain looked at you during her final moments? Did she say anything?

#speaker Kaylee
#bg witness
Not that I recall. But Ms. Bain stared at me intensely while she bled out slowly on the ground. I thought I could save her.

#speaker Anna
#bg defence
#expression object
I’m sorry to say this, but that isn’t at all possible. The autopsy performed at the crime lab says otherwise.

#speaker Kaylee
#bg witness
Huh, what do you mean? Are you saying she didn’t die from being stabbed in the throat?

#speaker Anna
#bg defence
#expression object
She definitely died from that. There is no doubt. But your description implies that Ms. Bain lived for some time after she was stabbed.

The autopsy says she died instantly!

#speaker Judge
#bg judge
Witness, what do you have to say about this?

#speaker Kaylee
#bg witness
Okay, wait. I think I’ve been mixing things up.

Ms. Bain was unconscious by the time I walked in. I think I was imagining things.

#speaker Anna
#bg defence
#expression think
Are you… serious…

#speaker Judge
#bg judge
Witness, for your next testimony, please go into detail about exactly what you saw, not what you imagined.

Fabricating details can get you in legal trouble. This is your last warning.

#speaker Kaylee
#bg witness
I apologize, your Honor. I will describe what I saw step-by-step.

-> Kaylee_Witness_Testimony_2
== Kaylee_Witness_Testimony_2 ==
#mode WitnessTestimony
#speaker Kaylee
#bg witness
I was using the restroom next to the beauty room during my preparation for the show.

Then suddenly, I heard a loud thud in the beauty room followed by rapid footsteps.

I left the bathroom and saw Nadine rushing out of that room and down the hallway.

When I entered that room, I found a horrific sight… Ms. Bain’s own hairpin was lodged in her throat.

It was too late to get help. Her heart had already stopped beating.

Oh, poor sweet Madeline… what a painful fate to endure…

#speaker Anna
#bg defence
#expression think
This isn’t looking the best for Nadine.

But there’s something weird about her testimony for sure. I just need to put my finger on it!

-> Kaylee_Cross_Examination_2


== Kaylee_Cross_Examination_2 ==
~current_ce = "Kaylee_CE2"
~ current_statement = ""
#mode CrossExamination
#speaker Kaylee
#bg witness

->B1

== B1 ==
#mode CrossExamination
#speaker Kaylee
#bg witness
~ current_statement = "CE2_L1"
I was using the restroom next to the beauty room during my preparation for the show.
+ [Next]
    -> B2
-> DONE

== B2 ==
~ current_statement = "CE2_L2"
Then suddenly, I heard a loud thud in the beauty room followed by rapid footsteps.
+ [Previous]
    -> B1
+ [Next]
    -> B3
-> DONE

== B3 ==
~ current_statement = "CE2_L3"
I left the bathroom and saw Nadine rushing out of that room and down the hallway.
+ [Previous]
    -> B2
+ [Next]
    -> B4
-> DONE

== B4 ==
~ current_statement = "CE2_L4"
When I entered that room, I found a horrific sight… Madeline’s own hairpin was lodged in her throat.
+ [Previous]
    -> B3
+ [Next]
    -> B5
-> DONE

== B5 ==
~ current_statement = "CE2_L5"
It was too late to get help. Her heart had already stopped beating. 
+ [Previous]
    -> B4
+ [Next]
    -> B6
-> DONE

== B6 ==
~ current_statement = "CE2_L6"
Oh, poor sweet Madeline… what a painful fate to endure…
+ [Previous]
    -> B5
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


== Objection_CE2_L2 ==
#mode Normal
#speaker Anna
#bg defence
#expression object
Kaylee, was the loud thud the only thing you heard?

#speaker Kaylee
#bg witness
I mean, yes, that is what caused me to enter the room.

#speaker Anna
#bg defence
#expression speak
Are you sure you didn’t hear the sound of glass shattering? I’d imagine that would be louder than a body falling to the ground.

#speaker Kaylee
#bg witness
Ah, you mean the broken mirror in the makeup room? No, I believe that was always there.

#speaker Anna
#bg defence
#expression object
And you never bothered to clean up that mess? You know how dangerous glass shards are, right?

#speaker Kaylee
#bg witness
We were in a rush to prepare for the event. Someone was clumsy and accidentally knocked it over.

#speaker Anna
#bg defence
#expression object
I don’t think that’s true. I’ve heard from others that the mirror was not shattered until after the incident.

And I think I know exactly who shattered it.

#speaker Arthur
#bg prosecution
#expression talk
Are you saying the victim punched a mirror before she died? What a bold claim to make.

How are you going to prove she punched a mirror?

#speaker Anna
#bg defence
#expression think
This guy needs to shut up. I have the exact proof this courtroom needs.

#speaker Anna
#bg defence
#expression object
Your Honor, the victim’s autopsy stated that she had bruises and scratches on her knuckles before she died.

My client and another witness heard the mirror break at the time of the murder. And no one has proof otherwise.

As absurd as it sounds, Madeline Bain really did punch the mirror during her last moments for some unknown reason.

If no one else knows exactly how the mirror broke, this is the most logical conclusion!

#speaker Judge
#bg judge
Witness, I am convinced that you are not completely honest with your testimonies. Therefore, I put you under contempt of court for perjury.

Please allow the bailiff to escort you out.

#speaker Kaylee
#bg witness
Wait! No, no, no, you don’t understand. This was an honest mistake!

I didn’t hear the mirror shatter. I’m answering to the best of my ability, I swear!

Please allow me to testify one last time. I haven’t said what happened after I saw Ms. Bain's body.

#speaker Anna
#bg defence
#expression think
This woman… Fine. She has a point. I do need to hear about what happened after Madeline’s death.

Your Honor, I do wish to hear this witness’s last testimony. I have a feeling this is important.

#speaker Judge
#bg judge
…Well then. If the defense thinks what you have to say will contribute to this case, your request is sustained.

#speaker Kaylee
#bg witness
Thank you, Your Honor. Please allow me to redeem my honor.

-> Kaylee_Witness_Testimony_3
== Kaylee_Witness_Testimony_3 ==
#mode WitnessTestimony

#speaker Kaylee
#bg witness
After I saw what happened, I called the local police immediately.

I told them about Ms. Kanna running out of the room, and they arrested her on sight.

Ms. Bain’s body was transported to the crime lab.

I remember the hairpin was still lodged in her throat.

Police searched the beauty room for additional evidence, and we made sure the entire backstage area was secured.

This meant no one unrelated could roam around the beauty room without being caught, let alone leave or enter the backstage area.

Everyone on site, meaning me, makeup artist Eileen Lore, and Ms. Kanna's brother Olaf Kanna, was taken in for questioning.  

With that being said, there was no opportunity for anyone besides Ms. Kanna to leave the beauty room, so she has to be the culprit!

#speaker Anna
#bg defence
#expression think
Hm, wait, if what she’s saying is true, then how did *that* happen?  
When was the backstage area secured?

-> Kaylee_Cross_Examination_3


== Kaylee_Cross_Examination_3 ==
~current_ce = "Kaylee_CE3"
#mode CrossExamination
#speaker Kaylee
#bg witness

->C1

== C1 ==
#mode CrossExamination
#speaker Kaylee
#bg witness
~ current_statement = "CE3_L1"
After I saw what happened, I called the local police immediately.
+ [Next]
    -> C2
-> DONE

== C2 ==
~ current_statement = "CE3_L2"
I told them about Nadine running out of the room, and they arrested her on sight.
+ [Previous]
    -> C1
+ [Next]
    -> C3
-> DONE

== C3 ==
~ current_statement = "CE3_L3"
Madeline’s body was transported to the crime lab. The hairpin was still lodged in her throat.
+ [Previous]
    -> C2
+ [Next]
    -> C4
-> DONE

== C4 ==
~ current_statement = "CE3_L4"
Police searched the beauty room for additional evidence, and we made sure the entire backstage area was secured.
+ [Previous]
    -> C3
+ [Next]
    -> C5
-> DONE

== C5 ==
~ current_statement = "CE3_L5"
This meant no one unrelated could roam around the beauty room without being caught, let alone leave or enter the backstage area.
+ [Previous]
    -> C4
+ [Next]
    -> C6
-> DONE

== C6 ==
~ current_statement = "CE3_L6"
Everyone on site, meaning me, makeup artist Eileen Lore, and Nadine’s brother Olaf Kanna, were taken in for questioning.
+ [Previous]
    -> C5
+ [Next]
    -> C7
-> DONE

== C7 ==
~ current_statement = "CE3_L7"
With that being said, there was no opportunity for anyone besides Nadine to leave the beauty room, so she has to be the culprit!
+ [Previous]
    -> C6
-> DONE


== WrongObjection3 ==
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
->C1


== Objection_CE3_L4 ==
#mode Normal
#speaker Kaylee
#bg witness
Around 6:40 PM, I think? Several minutes after the murder had happened.

#speaker Anna
#bg defence
#expression object
Now, you see, if the entire backstage area was closed off before 7:00 PM, when the show was supposed to start…

Could you explain how a fan letter managed to get in after the cancellation announcement?

#speaker Kaylee
#bg witness
A… a what? What fan letter?

#speaker Anna
#bg defence
#expression object
A fan letter was slipped under the beauty room door. Your Honor, please accept that as evidence.

#speaker Judge
#bg judge
I’m not sure I understand. Can you elaborate?

#speaker Arthur
#bg prosecution
#expression talk
Before you do so, Ms. Nyugen, let me ask you—  
How do you know that the fan letter was not there before the murder happened?

I think your little piece of evidence is irrelevant to the case.

#speaker Anna
#bg defence
#expression speak
The contents of the letter prove exactly why it was written after the backstage was closed. Let me read it out loud…

“So sad the show got cancelled! If you see this, please text me — Dillie Juno.”

This means this note was written after the show was cancelled, which was at 7:00 PM.  
So this fan slipped it under the door *after* 7:00 PM.

#speaker Anna
#bg defence
#expression object
Do you understand the logic behind that, Mr. Splanoir?  
Or would you like me to explain it again, but like I’m explaining it to a child?

#speaker Arthur
#bg prosecution
#expression default
…!

#speaker Anna
#bg defence
#expression object
So, Ms. Smith—make up your mind.  
Was the backstage really fully guarded or not?

If a fan can sneak in there, then there’s no doubt the culprit had at least one opportunity to leave the beauty room!

#speaker Kaylee
#bg witness
W-What? Well, I was being apprehended… The police told me they secured the area at least…

I wasn’t responsible for that! It was negligence on their part!

#speaker Judge
#bg judge
So you're saying there was someone else on site during this whole situation? A fan?

#speaker Anna
#bg defence
#expression speak
Yes. Their name is Dillie Juno. I was able to get in contact with them.

#speaker Judge
#bg judge
Please see if you can get this witness to attend today’s court session.

I’d like to hear from them before today’s testimonies are finished.

#speaker Anna
#bg defence
#expression speak
Yes, Your Honor. I will call her to come here as soon as possible.

#speaker Judge
#bg judge
Witness, if there are no other things you’d like to testify to, you are excused from the stand.

#speaker Kaylee
#bg witness
Thank you, Your Honor. I hope I wasn’t too much trouble.

#speaker Judge
#bg judge
Bailiff, please call up the next witness.

-> END
