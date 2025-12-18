-> Co_Worker
== Co_Worker ==
#speaker Diego
Hi boss! How’d the investigation go? Did you find anything useful?

#speaker Anna 
Got some information on the case...

-> Co_Choice_One


== Co_Choice_One ==
+ [She seems suspicious.] -> Co_Suspicious
+ [I got some numbers.] -> Co_Contact
+ [Gotta go.] -> Co_End 


== Co_Suspicious ==
#speaker Anna
Kaylee, the manager, seems very suspicious. Where is she anyways?

#speaker Diego
She left right after you went into the office. Got something you wanna ask her? What do you mean suspicious? 

#speaker Anna
Yes, but... well forget about it.

There’s a magazine draft with Kaylee’s note on it scolding the reporter who wrote an article about some secrets that Madeline supposedly was hiding…

#speaker Diego
What could she have done? Madeline was one of the most popular and well-loved celebrities of our time!

#speaker Anna
Well, my defendant said otherwise… but that wasn’t the only thing I found.

There’s a medkit in the office. It’s brand new but already half-used. Why would a celebrity's office require so many medical supplies?

#speaker Diego
Who knows, maybe our scary manager here loves to fight people in the basement of a bar or something! But you’re right, I hope some more investigations will help unearth this mystery.

-> Co_Choice_One


== Co_Contact==
#speaker Anna
I got some contact information of people who might be of use for our case.

#speaker Diego
Oh wow that’s great! 

Speaking of this, Dr. Liu from the forensics called and said that there is some new info available. Call her when you get the chance!

#speaker Narrator
— new contact added: Dr. Liu —

-> Co_Choice_One


== Co_End ==
#speaker Anna
That’s all I got. Going back to our office now.

#speaker Diego
Okay, okay, see you! Remember to check out the new telephone we got. You can call people there.

#speaker Anna
I will. Thanks for coming with me. Bye!

-> END
