== Olaf ==
#speaker Olaf 
Hello? Who is this?

#speaker Anna 
Hello, this is Anna Nyugen, the attorney on Madeline Bain's case. I am calling to ask about your relationship with the victim.

#speaker Olaf 
How did you get my contact?

-> Olaf_Choice_One 


== Olaf_Choice_One == 
* [From Madeline’s Manager] -> Continue
* [From your sister] -> Continue


== Continue ==
#speaker Olaf Kanna
I see... that makes sense. What would you like to know?

-> Olaf_Choice_Two


== Olaf_Choice_Two == 
* [Record conversation] -> Choice_Record
* [Ask about relationship] -> Choice_Relationship
* [Ask about where] -> Choice_Where
* [That’s all] -> Choice_End


== Choice_Record ==
#speaker Anna
Before we begin, I would like to record this conversation and potentially use it in court. 

Do you consent to that?

#speaker Olaf 
Yes. I consent to being recorded.

#speaker Narrator
- Phone call transcript will now be stored in the Inventory -
	
-> Olaf_Choice_Two 


== Choice_Relationship ==
#speaker Anna
What is your relationship with the victim?

#speaker Olaf 
Madeline was my lover… as you know. We met backstage at this exact gala a few years back, actually, which is why this all feels so... surreal. 

I can't believe she is gone.

#speaker Anna 
Were you two close?

#speaker Olaf 
Yes, but it was hard to meet as frequently as we would have liked.

I'm not a public figure, and if the public found out, there would be a scandal.
	
#speaker Anna 
Was she aware of your relationship with my client?

#speaker Olaf 
...

No.
	
-> Olaf_Choice_Two 


== Choice_Where ==
#speaker Anna
Where were you that day?

#speaker Olaf 
I arrived at the gala as a guest and also to show my support for Madeline.

As my sister is also present, I went to meet with her at the bar. 

Later when she went backstage to get something, I heard a ruckus about Madeline being missing.

I didn't even get to talk to Madeline before her death...

#speaker Narrator
Olaf begins to tear up.

-> Olaf_Choice_Two 


== Choice_End == 
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


== David ==
#speaker David 
Hello. David speaking. Who am I talking to?

#speaker Anna 
Hello, this is Anna Nyugen. I am calling to ask about Madeline Bain--

#speaker David 
Ah, yes. For business inquiries and payment, could you please send me an email instead?

#speaker Anna 
Excuse me?

#speaker David 
You're calling about compensating me for my services, aren't you?

-> David_Choice 


== David_Choice ==
* [No. I'm Rae’s attorney. I'm calling to discuss your relationship with Madeline Bain.] -> Choice_Attorney
* [Could we meet in person and talk?] -> Choice_Meet


== Choice_Attorney ==
#speaker David 
I’m sorry. I think you have the wrong number.

-> David_Choice


== Choice_Meet ==
#speaker David 
Worried about leaving behind phone records?

Well, alright. I can meet you in person tomorrow.

Ms. Bain's office, right?

#speaker Anna Nyugen
Yes. 

#speaker David 
Okay. See you then.

-> END




== DrLiu ==
#speaker Anna
Hello Dr. Liu! I heard that you have some new insight for the case?

#speaker Dr.Liu
Nice to hear from you again, Miss Nyugen.

I can't call you unless there's an insight? 

Just kidding, haha. Of course I won’t.

Okay but before everything, I'd like to go through what we have on hand again. Now don't argue with me - before the trial, you'll have to make everything in your case indelible.

#speaker Anna
...

Okay ma'am.

#speaker Dr.Liu
Ma'am? I’m just 3.1 months older than you!

Anyways, at approximately 6:30 PM, February 8th, 20XX, Madeline Bain was found dead at the backstage of a gala.

She was found by her manager, Kaylee Smith, from whom a witness of Nadine Kanna, Bain's famous public rival, fleeing the crime scene was also reported.

#speaker Anna
Nadine is my client. I know this well enough...

#speaker Dr.Liu
The police arrived shortly after, and so, they arrested Kanna.

#speaker Anna
And from what I've gathered, they also questioned and put under surveillance several others who are related to the victim and the suspected murderer.

#speaker Dr.Liu
And what I'm about to tell you came straight from my lab, about the victim.

First of all, we got a defined time of death on Bain. It was no earlier than 18:20 that night.

#speaker Anna
From what she told me and my speculation, Nadine and Kaylee saw the body at around that time! If only Madeline could hold on for a few more minutes...

#speaker Dr.Liu
Well that's interesting because the second finding is that she died almost immediately after the attack from significant blood loss.

#speaker Anna
So the murderer could still be backstage when they found the body?

Speaking of attack. Do you have any info about the cause of death?

#speaker Dr.Liu
It's significant blood loss! And if what you mean is the murder weapon, sorry I don't.

We are still examining the wound and the presumable murder weapon. Before the results are out, I cannot give you any information.

However, I have something else for you.

The victim's knuckles are slightly bruised with scratches all over the hands. They all seemed to be formed before death.

#speaker Anna
(What happened before her death? What was she punching?)

This is really important information! Thank you so much Dr. Liu!

#speaker Dr.Liu
You're welcome. I'm glad I can help.

-> END
