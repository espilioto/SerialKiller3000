# SerialKiller3000


This is a GUI that controls the MSP430 through simple UART commands. 
The MSP430 then parses the commands and sets the PWM values for the RGB led/strip or whatever. 
It's written in C# / VS2013.

Here is the C code for the uC (TI CCS5)
 - https://github.com/espilioto/SERIAL-KILLER-MSP430

At first this was meant to be a room mood lighting - led strip..thing. Then I dropped that for no reason and decided to install it in my pc case. 

I'll update this and link some gerbers when I finish designing the pcb.





Many thanks to the 43oh forum for the help (even though I didn't even start a new thread) :P 
It's a very nice place even if you're not into this stuff :D

Threads that helped me develop this: 
 - http://forum.43oh.com/topic/253-pwm-codes-and-timera/ PWM stuff 
 - http://forum.43oh.com/topic/1643-g2553-hardware-uart-hello-world-example/ Serial stuff 
 - http://forum.43oh.com/topic/1764-msp430g2553launchpad-uart-rx-example/ More serial stuff

This project was the one that actually gave me the idea, and made me look into serial comms.
 - http://www.msp430launchpad.com/2010/12/njcs-launchscope-launchpad-oscilloscope.html 

###Many thanks to all of you!






tl;dr: A UART led blinker for the MSP430

***SouLSLayeR***
