VAR current_statement = ""
VAR returnPoint = ""

-> Beginning
== Beginning ==
#speaker Anna
#mode Normal
Your honour...
After this testimony, I want to call someone to the stand.

#speaker Judge
Who is it that you want to call to the stand?

#speaker Anna
#expression object
I want to call Olaf to the stand please.
What happened that day?

-> Lover_WitnessTestimony

== Lover_WitnessTestimony ==
#speaker Olaf
#mode WitnessTestimony
I understand. I’ll tell you everything I remember—just… please go easy on me, alright?

I saw Mr. Halden hurrying down the street with someone in a hooded coat following behind him. Moments later, I heard a gasp and found him dead in the alley.

The hooded person didn’t run—they walked after him like they had all the time in the world. By the time I gathered the courage to follow, the alley was already silent.

I couldn’t see the attacker’s face, but their coat was drenched from the rain. Whoever they were, they didn’t even look back after the murder.

I swear I heard Mr. Halden whisper something before he collapsed. It sounded like he was trying to say a name, but the words never came out.

There were no other people on the street at that hour. Just Mr. Halden… and that shadowy figure trailing behind him.

Right after the gasp, I heard footsteps—slow ones—like the killer wasn’t in a hurry to escape. When I reached the alley, all that was left was the victim and a single puddle of blood.
-> Lover_CrossExamination

== Lover_CrossExamination ==
#speaker Olaf
#mode CrossExamination
"Start of Cross Examination"

-> L1

== L1 ==
#mode CrossExamination
#speaker Olaf
#statement L1
~ current_statement = "L1"
I understand. I’ll tell you everything I remember—just… please go easy on me, alright?
+ [Next]
    -> L2
->DONE

== L2 ==
#statement L2
~ current_statement = "L2"
I saw Mr. Halden hurrying down the street with someone in a hooded coat following behind him. Moments later, I heard a gasp and found him dead in the alley.
+ [Previous]
    -> L1

+ [Next]
    -> L3
->DONE

== L3 ==
#statement L3
~ current_statement = "L3"
The hooded person didn’t run—they walked after him like they had all the time in the world. By the time I gathered the courage to follow, the alley was already silent.

+ [Previous]
    -> L2

+ [Next]
    -> L4
    
->DONE

== L4 ==
#statement L4
~ current_statement = "L4"
I couldn’t see the attacker’s face, but their coat was drenched from the rain. Whoever they were, they didn’t even look back after the murder.

+ [Previous]
    -> L3

+ [Next]
    -> L5

->DONE

== L5 ==
#statement L5
~ current_statement = "L5"
I swear I heard Mr. Halden whisper something before he collapsed. It sounded like he was trying to say a name, but the words never came out.

+ [Previous]
    -> L4

+ [Next]
    -> L6

->DONE

== L6 ==
#statement L6
~ current_statement = "L6"
There were no other people on the street at that hour. Just Mr. Halden… and that shadowy figure trailing behind him.

+ [Previous]
    -> L5

+ [Next]
    -> L7

->DONE

== L7 ==
#statement L7
~ current_statement = "L7"
Right after the gasp, I heard footsteps—slow ones—like the killer wasn’t in a hurry to escape. When I reached the alley, all that was left was the victim and a single puddle of blood.

+ [Previous]
    -> L6
-> DONE

== Objection_L4 ==

->DONE

== WrongObjection ==
#mode Normal
#speaker Anna
#expression object
Your honor! There is a clear contradiction here...

#speaker Judge
I don't see a contradiction here...

#speaker Anna
#expression think
(...)
(I must have made a mistake...)
->Reset_Mode

== Reset_Mode ==
-> L1

== Objection_L2 ==
#mode Normal
#speaker Anna
#expression object
Take That!
As you can see here, this piece of evidence contradicts what you say!

#speaker Judge
What do you mean?

#speaker Anna
So .... this piece of evidence does this .... so this is why that happened!
(ok this is going well!)
->DONE

->DONE

