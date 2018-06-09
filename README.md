![alt text](https://github.com/MojtabaTajik/BeSafe/blob/master/Resources/Besaf_Logo.png)

BeSafe

Today there are many antiviruses around the world that protect users from threats. each AV product have special features and benefits but all of theme have problems like :

- Effect wide system softwares
- Reduce system speed and sometimes stability
- False positive detections
- Not detect threat that detected by other product

BeSafe is a robust threat analyzer which helps securing your desktop environment and be aware of what's happening around you.
By using VirusTotal public API, BeSafe got power of more than 56 antivirus products without need to install any client engines in light and robust solution.
Except VirusTotal's power, BeSafe uses other techniques and tricks to protect your environments from known and unknown threats.

Key features :

- [x] Monitor running process, modules and URLs
- [x] Monitor suspicious registry modifications
- [x] Secure volume that prevent execution of malicious files
- [ ] Yara signature scanner engine
- [x] Ability to automatically kill suspicious processes
- [x] Ability to quarantine suspicious files & processes
- [ ] Improve scan results using VirusTotal engine
- [x] Plugin base engine that let developers to write custom scanner engines
- [ ] Cloud analyzer which analyzes client's data in anonymous manner
- [ ] Multipile reports about active world threats, frequency map, threats birth point and relations and etc.

BeSafe developed using C#.7 in VisualStudio.2017 using folowing free libraries :

- Dokan user mode file system library for Windows : http://dokan-dev.github.io/
- MonoFlat WinForms theme by HazelDev
- Named Pipe Wrapper library                      : https://github.com/acdvorak/named-pipe-wrapper

:exclamation: Dependencies automatically handled by NuGet package manager of VisualStudio.

Access the project's Trello board here : http://bit.do/BeSafeBoard

Here are some screenshots of BeSafe Windows client UI :

<img width="400" src="https://raw.githubusercontent.com/MojtabaTajik/BeSafe/master/Resources/UI%20Screenshots/UI_Configuration.png"> |
<img width="400" src="https://raw.githubusercontent.com/MojtabaTajik/BeSafe/master/Resources/UI%20Screenshots/UI_Plugins.png"> |
<img width="400" src="https://raw.githubusercontent.com/MojtabaTajik/BeSafe/master/Resources/UI%20Screenshots/UI_Account.png"> |
:------------------------:|:-------------------------:|:-------------------------:

 <img width="400" src="https://raw.githubusercontent.com/MojtabaTajik/BeSafe/master/Resources/UI%20Screenshots/UI_ThreatInfo.png"> |
 <img width="400" src="https://raw.githubusercontent.com/MojtabaTajik/BeSafe/master/Resources/UI%20Screenshots/UI_LogHistory.png">
:------------------------:|:-------------------------:

Be safe and keep calm :)
