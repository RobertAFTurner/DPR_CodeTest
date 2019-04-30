
My approach.

I started out initially with just one test data driven test that I decieded to split up into several result partitioned boundary tests.
This was mainly due to MSTest not handling the results view for data driven testing as well as NUnit would and I wanted the tests to be easy
read and be clear on that they were testing. This I felt, though not requested was a step closer to BDD which I think is always a positive
way of developing.

I did not want to over complicate things with a fancy UI and just focused on the calculator and the tests as TDD seems 
to be an important requirement of yours and I didn't want to distract from that. Though I do hope I have not gone the other way and 
kept it too simple!

After my failing tests were written I built and fleshed out the calculator. I created an Interface with the idea that their could be other
calculator types that might calculate interest based on different parameters such as ammount deposited over a certain time vs what is 
the current balance, or something of that nature that I just haven't thought of.

PS. Thank you for asking for that for providing the example "A balance of £1,001 would pay interest at 1.5% resulting in an
interest rate of £15.02" When I plugged this into my tests it helped me find a bug in my code where I was not rounding up correctly :-)