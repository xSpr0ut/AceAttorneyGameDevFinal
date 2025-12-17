VAR current_statement = ""
VAR current_ce = ""

-> Trial2 

== Trial2 ==
#mode Normal
#speaker Anna
#bg defence
#expression speak
This witness is working with the defence.

Witness, please state your name and occupation.

#speaker Olaf
#bg witness
My name is Olaf Kanna. I am currently working as a bank teller at St. Marshalls Bank.

I’m the defendant’s older brother, and I was seeing the victim before her murder.

#speaker Arthur
#bg prosecution
#expression talk
What do you mean that you were seeing the victim?

#speaker Olaf
#bg witness
We were romantically involved. I believe that was something I was not supposed to disclose to the public, but how can I hide such a thing when I’m in such grief?

#speaker Arthur
#bg prosecution
#expression default
I’m very sorry, Mr. Kanna.

#speaker Olaf
#bg witness
What’s done is done. However, I must state: Madeline and I did not meet on the day of the murder.

#speaker Arthur
#bg prosecution
#expression talk
Then what were you doing to be apprehended?

#speaker Olaf
#bg witness
I was meeting with my sister before the show. She invited me to discuss some matters.

We talked right before the murder occurred. I’m sure my sister is innocent.

But first, I would like to clear my name of any direct involvement in this case.

#speaker Anna
#bg defence
#expression talk
Very interesting. Why don’t you elaborate, Mr. Kanna?

#speaker Olaf
#bg witness
Definitely, will do.

#speaker Anna
#bg defence
#expression think
\*Time to begin my direct-examination. This should be easy.*

-> Olaf_Witness_Testimony_1



== Olaf_Witness_Testimony_1 ==
#mode WitnessTestimony
#speaker Olaf
#bg witness

I met up with my sister before the murder happened.

Then, my sister said she needed to retrieve her sunhat from the beauty room before the show started. 

She left, and the rest is whatever happened in that room. I did not go in with her.

#speaker Anna
#bg defence
#expression think
\*My first priority is to prove that he didn’t have direct involvement with the case.*


-> Olaf_Cross_Examination_1


== Olaf_Cross_Examination_1 ==
~current_ce = "Olaf_CE1"
#mode CrossExamination
#speaker Olaf
#bg witness

->A1

== A1 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE1_L1"
I met up with my sister before the murder happened.

+ [Next]
    -> A2

-> DONE



== A2 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE1_L2"
Then, my sister said she needed to retrieve her sunhat from the beauty room before the show started. 

+ [Previous]
    -> A1

+ [Next]
    -> A3

-> DONE

== A3 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE1_L3"
She left, and the rest is whatever happened in that room. I did not go in with her.

+ [Previous]
    -> A2
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



== Objection_CE1_L3 ==
#mode Normal
#speaker Anna
#expression speak
#bg defence
This witness could not have entered the beauty room even if he wanted to.

The ID Scanner only allows certain people in with no exceptions. Other than authority, of course.

#speaker Olaf
#bg witness
Right. In that case, I have never even stepped foot into that room.

Now, I’m here to clear my sister’s name. She had an alibi right before the murder.

-> Olaf_Witness_Testimony_2



== Olaf_Witness_Testimony_2 ==
#mode WitnessTestimony
#speaker Olaf
#bg witness
My sister and I met up before 6:00 PM and talked for quite a while.

She wanted to talk about the fact that I was seeing her career rival. Though she does not exactly approve of our relationship, she said she was content with it.

Even so, I realized how wrong it was, as by dating her, I was disrespecting my sister and her career. So I thought about cutting off our relationship after the show was over.

Later, she left. That was precisely when the murder happened, so my sister had an alibi!

-> Olaf_Cross_Examination_2



== Olaf_Cross_Examination_2 ==
~current_ce = "Olaf_CE2"
#mode CrossExamination
#speaker Olaf
#bg witness

->B1

== B1 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE2_L1"
My sister and I met up before 6:00 PM and talked for quite a while.

+ [Next]
    -> B2
-> DONE

== B2 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE2_L2"
She wanted to talk about the fact that I was seeing her career rival. Though she does not exactly approve of our relationship, she said she was content with it.

+ [Previous]
    -> B1

+ [Next]
    -> B3

-> DONE



== B3 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE2_L3"
Even so, I realized how wrong it was, as by dating her, I was disrespecting my sister and her career. So I thought about cutting off our relationship after the show was over.

+ [Previous]
    -> B2

+ [Next]
    -> B4

-> DONE



== B4 ==
#mode CrossExamination
#speaker Olaf
#bg witness
~ current_statement = "CE2_L4"
Later, she left. That was precisely when the murder happened, so my sister had an alibi!

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



== Objection_CE2_L1 ==
#mode Normal
#speaker Arthur
#expression talk
#bg prosecution
Only you and the defendant can't possibly prove that you two met together to talk before the murder happened.

Therefore, Your Honor, I’m not sure if we can accept that as evidence.

#speaker Anna
#expression objection
#bg defence
That unfortunately isn’t the case, dear prosecutor.

#expression speak
I conveniently received photographic evidence of the two meeting beforehand from the paparazzi, and would like to submit those photos as evidence.

#speaker Judge
#bg judge
Oh? Show this to the court, defence.

#speaker Arthur
#expression talk
#bg prosecution
A photograph of the witness and defendant speaking at 6:15 PM... And is that, the defendant getting arrested? Today must be your lucky day, Ms. Nyugen.

#speaker Anna
#expression think
#bg defence
That’s correct. They were together at 6:15 PM, meaning this witness is telling nothing but the truth. And my client’s name should be cleared.

#speaker Arthur
#expression talk
#bg prosecution
Not so fast. They could have met at 6:15 PM, but there is no proof your client did not just leave after the photograph was taken and murdered the victim in the beauty room.

#speaker Anna
#expression think
#bg defence
You are not wrong on that, but we need to keep the witness’s testimony in mind.

#expression speak
If my client showed up to the beauty room at the time of the murder, she could have walked in on the scene and rushed out in panic to get help.

#speaker Judge
#bg judge
That definitely is a possibility! 

-> END