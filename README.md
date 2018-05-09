![alt text](https://github.com/MojtabaTajik/BeSafe/blob/master/Resources/Besaf_Logo.png)

BeSafe

Today there are many antiviruses in the world that protect users from threats. each AV product have special features and benefits but all of theme have problems like :

- Effect wide system softwares
- Reduce system speed and sometimes stability
- False positives detections
- Not detect threat that detected by othe product

BeSafe is robust threat analyzer which help to secure your desktop environment and know what's happening around you.
By using VirusTotal public API BeSafe got power of more than 56 antivirus products without need to install any client engines in light and robust solution.
Except VirusTotal's power, BeSafe use other techniques and tricks to protect your environments from known and unknown threats.

Key features :

- Scan running process, modules and URLs
- Secure volume that prevent execution of malicious files
- Yara signature scanner engine
- Static scan of executable files for suspicious trail (Strings,Icon,EOF,Sections and etc.)
- Dynamic scan of running process for suspicious trail (Run PE,Process Hollowing and etc.)
- Ability to automatically kill suspect process
- Ability to quarantine suspect files & process
- Improve scan results uing VirusTotal engine
- Cloud analyzer which analyze clients data in anonymous manner
- Multipile reports about active world threats, frequency map, threats birth point and relations and etc.

BeSafe developed using C#.7 in VisualStudio.2017 using folowing free libraries :

- Dokan user mode file system library for Windows : http://dokan-dev.github.io/
- MonoFlat WinForms theme by HazelDev

:exclamation: Dependencies automatically handled by NuGet package manager of VisualStudio.

Access the project's Trello board here : http://bit.do/BeSafeBoard

Here are some screenshots of BeSafe Windows client UI :

![](https://github.com/MojtabaTajik/BeSafe/blob/master/Resources/UI%20Screenshots/UI_Configuration.png)  |  ![](https://github.com/MojtabaTajik/BeSafe/blob/master/Resources/UI%20Screenshots/UI_Plugins.png) | ![](https://github.com/MojtabaTajik/BeSafe/blob/master/Resources/UI%20Screenshots/UI_Account.png)
:------------------------:|:-------------------------:|:-------------------------:

Be safe and keep calm ;)
