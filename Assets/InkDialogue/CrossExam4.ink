VAR current_statement = ""
VAR current_ce = ""

-> Trial4

== Trial4 ==
#mode Normal
#speaker Arthur
#bg prosecution
#expression speak
Witness, Please state your name and occupation.

#speaker Eileen
#bg witness
I'm Eileen, um, my last name is Lore. So Eileen Lore.

I-I worked for Madeline Bain as her cosmetologist.

I'd do her makeup before performances, and sometimes she'd come back for touch-ups.

#speaker Anna
#bg defence
#expression speak
Sorry if this comes off as rude, but how old are you?

#speaker Eileen
#bg witness
I'm 26.

#speaker Anna
#bg defence
#expression think
Oh, wow, I did not expect that. You look very young. I thought you were a late-teenager, working for such a selective industry.

#speaker Eileen
#bg witness
I know, I g-get that a lot. I did enter the industry when I was in my mid-teens, actually. My mother worked as a celebrity cosmetologist.

Sorry, I-I'm a little nervous. I haven't been doing very well since the incident.

#speaker Anna
#bg defence
#expression speak
I... I see. Let's get on with your testimony, shall we?

#expression think
\*Poor girl. From her stature and timidness, the industry definitely did a number on her.*

\*Let's get through her testimony quickly. I really don't want to keep her here for too long.”

-> Eileen_Witness_Testimony_1 



== Eileen_Witness_Testimony_1 ==
#mode WitnessTestimony
#speaker Eileen
#bg witness
I did Ms. Bain's makeup and hair earlier that day. 

Right before the show, she um... She wanted me to do some touch-ups. I was running very late, as this request was very last-minute. 

I arrived minutes after the show was supposed to start, and there were police crowding the area. I n-never saw her body, but I was still apprehended on the spot.

The murder weapon was the hairpin she wore. It had the victim's fingerprints, mine, her lover's, and a fourth set of fingerprints.

The first three people make sense, as I work with Ms. Bain's hair and her lover... You know what, n-nevermind. So I thought it must've been Ms. Kanna's... since she was there...

But Ms. Kanna isn't supposed to be there... unless she... um... did it...

#speaker Anna
#bg defence
#expression think
\*A what? Did she just say a fourth set of fingerprints? This doesn't make any sense at all. I'll have to call out her lie!*

-> Eileen_Cross_Examination_1



== Eileen_Cross_Examination_1 ==
~current_ce = "Eileen_CE1"
#mode CrossExamination
#speaker Eileen
#bg witness

-> A1


== A1 ==
#mode CrossExamination
#speaker Eileen
#bg witness
~ current_statement = "CE1_L1"
I did Ms. Bain's makeup and hair earlier that day. 

+ [Next]
    -> A2

-> DONE



== A2 ==
#speaker Eileen
#bg witness
~ current_statement = "CE1_L2"
Right before the show, she um... She wanted me to do some touch-ups. I was running very late, as this request was very last-minute.  

+ [Next]
    -> A3

+ [Previous]
    -> A1

-> DONE



== A3 ==
#speaker Eileen
#bg witness
~ current_statement = "CE1_L3"
I arrived minutes after the show was supposed to start, and there were police crowding the area. I n-never saw her body, but I was still apprehended on the spot.

+ [Next]
    -> A4

+ [Previous]
    -> A2

-> DONE



== A4 ==
#speaker Eileen
#bg witness
~ current_statement = "CE1_L4"
The murder weapon was the hairpin she wore. It had the victim's fingerprints, mine, her lover's, and a fourth set of fingerprints.

+ [Next]
    -> A5

+ [Previous]
    -> A3

-> DONE



== A5 ==
#speaker Eileen
#bg witness
~ current_statement = "CE1_L5"
The first three people make sense, as I work with Ms. Bain's hair and her lover... You know what, n-nevermind. So I thought it must've been Ms. Kanna's... since she was there...

+ [Next]
    -> A6

+ [Previous]
    -> A4

-> DONE



== A6 ==
#speaker Eileen
#bg witness
~ current_statement = "CE1_L6"
But Ms. Kanna isn't supposed to be there... unless she... um... did it...

+ [Previous]
    -> A5

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



== Objection_CE1_L6 ==
#mode Normal
#speaker Anna
#expression speak
#bg defence
Ms. Lore, where did you get the idea that the hairpin had a fourth set of fingerprints?

#speaker Eileen
#bg witness
T-That's what I heard from Ms. Smith, the manager. She said the crime lab people told her that.

#speaker Anna
#expression think
#bg defence
\*Gosh, Kaylee must be the queen of spreading misinformation.*

#expression speak
Ms. Lore, you see, my client's fingerprints were, in fact, not on the hairpin, according to the crime lab results I received.

Ms. Bains, Mr. Kanna's, and your fingerprints were the only three found on the hairpin.

#speaker Arthur
#expression talk
#bg prosecution
Ms. Nyugen, are you sure your crime lab report is up-to-date?

#speaker Anna
#expression speak
#bg defence
Yes. Even if it wasn't, it's actually impossible for my client's fingerprints to be on the murder weapon.

#speaker Judge
#bg judge
What? What do you mean by impossible?

#speaker Anna
#expression speak
#bg defence
It's because my client wears long opera gloves that prevent her fingerprints from getting anywhere.

#speaker Arthur
#expression talk
#bg prosecution
Do you realize that makes her look even worse? Wearing gloves all the time, she can hypothetically have touched anything.

#speaker Anna
#expression speak
#bg defence
Mr. Splanoir, you seem like you misunderstood. That's not the point I'm trying to prove.

That only eliminates the existence of any proof that my client did touch the murder weapon.

#speaker Judge
#bg judge
The defence has a really good point. Witness, the fourth fingerprint you mentioned... Do you yourself have proof of that?

#speaker Anna
#expression speak
#bg defence
No, she doesn't. She said herself that it was her manager who told her that. The same woman who kept spiraling into blatant lies during the first testimony.

#speaker Judge
#bg judge
Right. Ma'am, from now on, you must clarify the information you heard through a secondary source.

#speaker Eileen
#bg witness
Oh... I see. I didn't know that. I'm sorry, Y-Your Honor.

#speaker Judge
#bg judge
Very well. defence, is there anything else you'd like to ask the witness?

#speaker Anna
#expression speak
#bg defence
Yes, actually. You never described what you were doing before you showed up to touch up the victim's makeup.

Please provide more details in that regard.

#speaker Eileen
#bg witness
Okay, I-I'll do that. 

-> Eileen_Witness_Testimony_2


== Eileen_Witness_Testimony_2 ==
#mode WitnessTestimony
#speaker Eileen
#bg witness
Before making my way to the beauty room, I was reading a m-magazine in the backstage lounge area, all by myself.

I lost track of time and ended up showing up after 7:00 PM, way later than the time Ms. Bain wanted me to come...

That was completely my fault, I shouldn't have neglected my duties like that...

But when I showed up to the scene, I saw Ms. Kanna being escorted by the police.

There was no one else apprehended, just me, Mister Kanna, and Ms. Smith. W-Wait, and Ms. Kanna of course.

#speaker Anna
#expression think
#bg defence
\*Wait, what? This has to be a slip-up of some sort.*

-> Eileen_Cross_Examination_2



== Eileen_Cross_Examination_2 ==
~current_ce = "Eileen_CE2"
#mode CrossExamination
#speaker Eileen
#bg witness

->B1



== B1 ==
#mode CrossExamination
#speaker Eileen
#bg witness
~ current_statement = "CE2_L1"
Before making my way to the beauty room, I was reading a m-magazine in the backstage lounge area, all by myself.

+ [Next]
    -> B2

-> DONE



== B2 ==
#speaker Eileen
#bg witness
~ current_statement = "CE2_L2"
I lost track of time and ended up showing up after 7:00 PM, way later than the time Ms. Bain wanted me to come...

+ [Next]
    -> B3

+ [Previous]
    -> B1

-> DONE



== B3 ==
#speaker Eileen
#bg witness
~ current_statement = "CE2_L3"
That was completely my fault, I shouldn't have neglected my duties like that...

+ [Next]
    -> B4

+ [Previous]
    -> B2

-> DONE



== B4 ==
#speaker Eileen
#bg witness
~ current_statement = "CE2_L4"
But when I showed up to the scene, I saw Ms. Kanna being escorted by the police.

+ [Next]
    -> B5

+ [Previous]
    -> B3

-> DONE



== B5 ==
#speaker Eileen
#bg witness
~ current_statement = "CE2_L4"
There was no one else apprehended, just me, Mister Kanna, and Ms. Smith. W-Wait, and Ms. Kanna of course.

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



== Objection_CE2_L4 ==
#mode Normal
#speaker Anna
#expression think
#bg defence
It's funny that I'm presenting this piece of evidence for like the sixth or seventh time...

But the photo of my client being escorted by the police...

#expression speak
It was taken at 6:47 PM, and it seems to be in the Neapolitan Museum parking lot, as the paparazzi could not be backstage at the time.

#speaker Eileen
#bg witness
...! Um...

#speaker Anna
#expression speak
#bg defence
Are you saying you arrived after 7:00 PM and you saw the police escorting my client out?

That's a blatant lie.

#speaker Eileen
#bg witness
I-I'm sorry, I... I think I misremembered... I'm just really not okay right now...

I worked under Madeline Bain, I w-wouldn't purposely lie to not bring justice to her killer...

#speaker Judge
#bg judge
Witness, please do try your best to tell the truth and only the truth.

#speaker Eileen
#bg witness
I'm sorry! I definitely will from now on... 

#speaker Anna
#expression think
#bg defence
\*Wait. There's something... really strange about this witness.*

\*It's nothing she's said, but the way she looks... definitely poses some questions now that I think about it*

\*Why is her makeup so heavy, for someone who is “not okay right now”?*

\*On my worst days, I wouldn't go through with my beauty routine. I'd prioritize feeling comfortable and go out bare-faced.*

\*Sure, it's different for everyone, and Eileen is a cosmetologist after all...*

\*But I can see the cracks in her foundation from here. And it's hot in this room. Why hasn't she taken off her winter hat and scarf?*

\*Her outfit choice is as if she's trying to hide something...*

\*I guess it wouldn't hurt to ask.*

#speaker Judge
#bg judge
defence, is there anything additional you'd like to ask the witness?

#speaker Anna
#expression speak
#bg defence
Ms. Lore. I have a question that doesn't sound relevant, but I'm genuinely curious.

Why are you wearing heavy makeup right now?

#speaker Eileen
#bg witness
... Um, well, doing my own makeup helps me deal with anxiety.

It's a very soothing way to pass the time. I also t-thought it wouldn't hurt to look pretty for court.

#speaker Anna
#expression think
#bg defence
Understood. For someone seemingly so shaken up, I just didn't expect you'd be in the mood for makeup.

#speaker Arthur
#expression talk
#bg prosecution
Objection, Your Honor, relevance.

#speaker Judge
#bg judge
Objection sustained. defence, please do not spiral into irrelevant conversations with the witness, and allow them to proceed with their cross-examination.

#speaker Anna
#expression think
#bg defence

\*Dammit, I hate this guy! I swear, everything in my gut tells me this witness is suspicious.*

\*I need this witness to ‘fess up! I just need to figure out how to do it... Maybe I can follow-up with a request...*

-> Choices



== Choices ==
*[Take off your hat, scarf, and coat.] -> Choice
*[Wash off your makeup.] -> Choice.



== Choice ==
#speaker Judge
#bg judge
Defence, what is the meaning behind such an invasive question?

#speaker Anna
#expression speak
#bg defence
Your Honor, this may not seem relevant to the case, but you have to trust me, it is.

#speaker Arthur
#expression talk
#bg prosecution
This is invading the witness's privacy. You can't forcibly make someone do that unless you have evidence they're really hiding something.

#speaker Anna
#expression speak
#bg defence
Witness, what do you say to that? If you're not hiding something, what's the harm of taking it off?

#speaker Eileen
#bg witness
...

...I refuse.

#speaker Arthur
#expression talk
#bg prosecution
And that's her choice. The witness makes the final call.

#speaker Anna
#expression speak
#bg defence
No, you don't understand. This is relevant!

#speaker Judge
#bg judge
How so?

#speaker Anna
#expression think
#bg defence
Remember that one piece of evidence we talked about earlier?

#speaker Judge
#bg judge
Which piece of evidence are you talking about in particular?

#speaker Anna
#expression think
#bg defence
\*The one that suggests there might have been a struggle before the murder... this has to be it!*

#speaker Narrator
Anna shows everyone Ms. Bain's autopsy report and the shattered mirror she found in an investigation.

#speaker Anna
#expression speak
#bg defence
That the victim was the one who broke the mirror right before she was murdered due to her bruised and scratched knuckles.

#expression object
This proves there was a struggle before the murder occurred, meaning the murderer probably has visible wounds!

And the way the witness is heavily covered with foundation and covered from head to toe in this warm room raises questions.

#speaker Judge
#bg judge
The defence does have a point. Witness, can you explain yourself?

#speaker Eileen
#bg witness
...

...?

...Ah. O-Okay. So I'm being accused as the murderer now, huh.

W-What... What is wrong with you, Ms. Nyugen?

#speaker Anna
#expression think
#bg defence
\*She's playing the victim... and using first names now... great.*

#speaker Eileen
#bg witness
Sure, I do have injuries under my makeup and clothes. That's true. But they have nothing to do with the case.

#speaker Anna
#expression think
#bg defence
\*How convenient. So she's confirmed it. I just need to convince the court that her injuries do have to do with the case!*

#speaker Arthur
#expression talk
#bg prosecution
Unless you have evidence to link her injuries to the case, your claims are null, and she does not have to elaborate further.

#speaker Anna
#expression think
#bg defence
\*Ugh, how do I even prove that? I'm stuck in a dead end!* 

#speaker Arthur
#expression talk
#bg prosecution
Nothing, Ms. Nyugen? Then this trial is over! There is no evidence to link this witness to the murder.

#speaker Anna
#expression think
#bg defence
\*Wait... what if we worked backwards. And instead of trying to prove that Ms. Lore may be the murderer...*

\*We pretend that fact is already established, and use it to make sense of the gaps of this case!*

#speaker Judge
#bg judge
Is there anything else the defence would like to say?

#speaker Anna
#expression think
#bg defence
\*Here goes nothing...*

#expression speak
Yes, Your Honor.

So just because I don't have proof to link her injuries to the case, we're just going to ignore the fact that she's conveniently injured after a case involving a struggle?

Please, Your Honor, hear me out. 

Let me expand on my theory and use proof to back it up!

#speaker Judge
#bg judge
Go on. If it leads nowhere, the defence will be penalized.

#speaker Anna
#expression speak
#bg defence
Understood, Your Honor.

From the previous testimony, we've established that someone dressed up as my client and left the beauty room.

#expression object
Meaning my unproven theory was that they were hiding somewhere in there when the police came.

But with this witness as a suspect, I believe it can actually be possible.

#speaker Arthur
#expression talk
#bg prosecution
Several police officers went into that small, open room, with nowhere to hide. What point are you trying to make, exactly?

#speaker Anna
#expression speak
#bg defence
There is one possible hiding spot the murderer could've taken on, assuming that the murderer is the witness standing before us right now.

That is...

#speaker Narrator
Anna shows everyone the costume rack large enough to hide a person...

#speaker Anna
#expression speak
#bg defence
Look at the witness's small stature. You, me, my client, we're all way too tall to fit between the layers of costumes on that rack and be concealed.

This witness, however, can easily slip in due to her petite size, and no one would think to search in there.

She hid there until the cops cleared out, and wore one of Ms. Kanna's gowns. She stole her signature hat, which she had forgotten in the beauty room, to disguise herself.

Then, she threw the costume out somewhere and changed into a regular outfit, showing up to the scene like she had just arrived.

#speaker Eileen
#bg witness
Y-You... that's really a stretch, Anna. I appreciate your dedication to saving your client, but pinning it on me is just not right.

If you're claiming I took the outfit, then where is that outfit now? Did you find that Nadine Kanna disguise anywhere on the site? 

#speaker Arthur
#expression talk
#bg prosecution
While there were copies of Ms. Kanna's dress present on site, it's nothing unusual. Celebrity costumes are scattered around backstage in case of wardrobe malfunctions. There were copies of other celebrity costumes too. 

The police did not report any sightings of Ms. Kanna's signature hat, though. So there is no concrete proof that the whole impersonation theory is even real.

#speaker Anna
#expression think
#bg defence
\*There's no sightings of Nadine's signature hat... huh...*

\*Wait... what Arthur just said. He just made the biggest slip-up possible.*

\*Where could the hat be... if no one found it anywhere backstage?*

\*I can actually use the prosecution's statement against them if my theory is correct.*

#expression speak
Ms. Lore. You were under surveillance the whole time after being apprehended backstage, yes?

#speaker Eileen
#bg witness
Yes, I was watched and monitored pretty much every moment for the past few days...

Except for using the bathroom and stuff like that, of course.

#speaker Anna
#expression think
#bg defence
\*So if my theory is true, then the signature hat... it has to be there!*

-> Choices2


== Choices2 ==
* [In a bathroom bin] -> Choice21
* [Somewhere backstage] -> Choice21
* [On Eileen's person] -> Choice22



== Choice21 ==
#speaker Arthur
#expression talk
#bg prosecution
Sorry Ms. Nyugen, these places are searched thoroughly and no trace of the hat has been found...

-> Choices2 



== Choice22 ==
#speaker Anna
#expression object
#bg defence
Eileen, you must be carrying Nadine Kanna's signature hat with you, right here, right now!

#speaker Eileen
#bg witness
...

#speaker Anna
#expression speak
#bg defence
You had no opportunity to have thrown it out anywhere, nor could you risk it. It's a one-of-a-kind hat, so if someone saw it, you would immediately be under suspicion. 

Therefore, you had to keep it to yourself.

It must be tightly stuffed in that tiny purse you're carrying right now!

#speaker Eileen
#bg witness
...

#speaker Arthur
#expression talk
#bg prosecution
You can't force someone to--

#speaker Judge
#bg judge
I grant the defence permission to search the witness's purse.

#speaker Anna
#expression think
#bg defence
\*This is the moment of truth. If my theory is correct, the hat should be in there. If not, then everything was for nothing.*

\*I'm certain this is the answer to everything. This witness... She's the real culprit behind the murder of Madeline Bain!*

#speaker Eileen
#bg witness
There's no need to search in my bag.

Yes, Ms. Kanna's hat is in there. 

I pretended to dress up as her and leave the room. 

And yes, I was the one who killed Ms. Bain.

#speaker Arthur
#expression talk
#bg prosecution
...!

#speaker Judge
#bg judge
...

#speaker Eileen
#bg witness
So there's your answer. Are you happy, Ms. Lore?

#speaker Anna
#expression speak
#bg defence
I...

Why did you do it, Ms. Lore?

#speaker Eileen
#bg witness
Your reasons to suspect me were correct. I'm not covering a bit of my body, but my entire body, because of Madeline Bain.

Since I was contracted to work for her as her cosmetologist, s-she'd hit me if something didn't go her way.

My manager, Ms. Smith, has always told me to stay silent about the abuse for the sake of Ms.Bain 's image, and even paid me in hush money.

My limbs, my face, they're all bruised up. I-It's pretty horrific.

#speaker Anna
#expression think
#bg defence
I see. Why... What made you kill her on that specific day?

#speaker Eileen
#bg witness
I didn't mean to kill her. It was an accident.

#speaker Anna
#expression speak
#bg defence
An... accident?

#speaker Eileen
#bg witness
She told me to meet her and give her a touch-up at 6:20 PM, but I showed up at 6:25 PM. I wasn't lying when I said I was late.

She lost her temper and tried to p-punch me. Instead, she hit the mirror, and it shattered.

So she went for a second blow. I was holding the hairpin in my hand at that moment. I... I instinctively blocked it to defend myself, but I ended up jamming it in her neck.

#speaker Anna
#expression speak
#bg defence
So you murdered her in self-defence.

#speaker Eileen
#bg witness
She fell over and died. I realized I had murdered her. I-I, I didn't know what to do! I was scared, and just hid...

I just hid in the costume rack until I could compose myself...

#speaker Anna
#expression speak
#bg defence
And what made you think of dressing up as my client?

#speaker Eileen
#bg witness
I saw Ms. Kanna's full costume on that costume rack, along with her signature hat...

I knew if I just took it and pretended to be her, maybe someone would think it was Ms. Kanna...

They're rivals, after all...

I'm so sorry, Ms. Kanna. 

I'm sorry for trying to frame you! I just didn't think I deserved any of this...

#speaker Anna
#expression speak
#bg defence
But you thought my client did? And were you content with her taking the fall for you?

#speaker Eileen
#bg witness
I'm sorry.

#speaker Judge
#bg judge
What a tragic turn of events. This is definitely no case for the soft-hearted.

But you, witness... I'm afraid this does convict you as a murderer.

However, you are lucky because we're not in Japan. We're in America. Meaning being convicted of murder in self-defence does not sentence you to the death penalty.

#speaker Anna
#expression speak
#bg defence
Ms. Lore, you do realize that you could've been honest from the start and pleaded self-defence?

#speaker Eileen
#bg witness
I really didn't, I d-didn't know what to do at all. I'm not familiar with any of that fancy legal stuff.

#speaker Judge
#bg judge
Then we will try you for murder in self-defence at a later date. Depending on the outcome, your sentence will be lighter. It's also possible you may not even serve one at all.

#speaker Anna
#expression speak
#bg defence
I'm willing to represent you, Ms. Lore. I strongly sympathize with your situation.

Even though framing Ms. Kanna was despicable of you, no one deserves to be treated like that in the industry.

#speaker Eileen
#bg witness
...Thank you. I really appreciate it. I will gratefully accept this opportunity and commence with the upcoming trial.

#speaker Judge
#bg judge
And with that, the case is closed.

The defendant, Nadine Kanna, is not guilty.

...

-> END
