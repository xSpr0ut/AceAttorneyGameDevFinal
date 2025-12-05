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
