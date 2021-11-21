christopher-fietzs-macbook-3:GroceryCo cwfietz$ dotnet new console -o GroceryCoProject

Welcome to .NET Core!
---------------------
Learn more about .NET Core: https://aka.ms/dotnet-docs
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli-docs

Telemetry
---------
The .NET Core tools collect usage data in order to help us improve your experience. The data is anonymous and doesn't include command-line arguments. The data is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET Core CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

ASP.NET Core
------------
Successfully installed the ASP.NET Core HTTPS Development Certificate.
To trust the certificate run 'dotnet dev-certs https --trust' (Windows and macOS only). For establishing trust on other platforms refer to the platform specific documentation.
For more information on configuring HTTPS see https://go.microsoft.com/fwlink/?linkid=848054.
Getting ready...
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on GroceryCoProject/GroceryCoProject.csproj...
  Restoring packages for /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/GroceryCoProject.csproj...
  Generating MSBuild file /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/obj/GroceryCoProject.csproj.nuget.g.props.
  Generating MSBuild file /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/obj/GroceryCoProject.csproj.nuget.g.targets.
  Restore completed in 2.33 sec for /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/GroceryCoProject.csproj.

Restore succeeded.



-----------

[How to code in C# on Mac](https://www.macworld.co.uk/how-to/code-c-sharp-mac-3640347/)
[Visual Studio Code C# Beginner Tutorial: Hello World](https://www.youtube.com/watch?v=jIpybrA1j68)

Output doesn't include any "Hello World"!
> Executing task: dotnet build /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/GroceryCoProject.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary <

Microsoft (R) Build Engine version 15.7.179.6572 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 97.09 ms for /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/GroceryCoProject.csproj.
  GroceryCoProject -> /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/bin/Debug/netcoreapp2.1/GroceryCoProject.dll

Terminal will be reused by tasks, press any key to close it.

[Tutorial: Debug a .NET console application using Visual Studio Code - Set up for terminal input](https://docs.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0#set-up-for-terminal-input)

[Set up a .NET Core C# Development Environment on macOS | Tutorial](https://www.youtube.com/watch?v=w8vQnmS3EZ4)

[GitHub - cwfietz/GroceryCo](https://github.com/cwfietz/GroceryCo/tree/main/GroceryCoProject)

Last login: Thu Nov 18 14:49:59 on ttys000
christopher-fietzs-macbook-3:~ cwfietz$ dotnet --version
2.1.302
christopher-fietzs-macbook-3:~ cwfietz$ which dotnet
/usr/local/share/dotnet/dotnet
christopher-fietzs-macbook-3:~ cwfietz$ 
christopher-fietzs-macbook-3:~ cwfietz$ dotnet --info
.NET Core SDK (reflecting any global.json):
 Version:   2.1.302
 Commit:    9048955601

Runtime Environment:
 OS Name:     Mac OS X
 OS Version:  10.12
 OS Platform: Darwin
 RID:         osx.10.12-x64
 Base Path:   /usr/local/share/dotnet/sdk/2.1.302/

Host (useful for support):
  Version: 2.1.2
  Commit:  811c3ce6c0

.NET Core SDKs installed:
  2.1.302 [/usr/local/share/dotnet/sdk]

.NET Core runtimes installed:
  Microsoft.AspNetCore.All 2.1.2 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.App 2.1.2 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 2.1.2 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]

To install additional .NET Core runtimes or SDKs:
  https://aka.ms/dotnet-download
christopher-fietzs-macbook-3:~ cwfietz$ 


The following was installed at /usr/local/share/dotnet 
	•	.NET Core SDK 3.1.415
	•	.NET Core Runtime 3.1.21
	•	ASP.NET Core Runtime 3.1.21

This product collects usage data 
	•	More information and opt-out

Resources 
	•	Core Documentation (https://docs.microsoft.com/en-ca/dotnet/fundamentals/)
	•	SDK Documentation (https://docs.microsoft.com/en-ca/dotnet/core/tools/)
	•	Release Notes (https://github.com/dotnet/core/blob/main/release-notes/3.0/README.md)
	•	Tutorials (https://docs.microsoft.com/en-ca/dotnet/core/tutorials/)



christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ ./dotnet-core-uninstall --version
1.5.0
christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ ./dotnet-core-uninstall list

This tool cannot uninstall versions of the runtime or SDK that are installed using zip/scripts. The versions that can be uninstalled with this tool are:

.NET Core SDKs:
  3.1.415  (x64)  [Used by Visual Studio for Mac. Specify individually or use —-force to remove]
  2.1.302  (x64)                                                                                

.NET Core Runtimes:
  3.1.21  (x64)  [Used by Visual Studio for Mac or SDKs. Specify individually or use —-force to remove]
  2.1.2   (x64)  [Used by Visual Studio for Mac or SDKs. Specify individually or use —-force to remove]
christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$


christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ ./dotnet-core-uninstall dry-run --sdk 3.1.415
*** DRY RUN OUTPUT
Specified versions:
  Microsoft .NET Core SDK 3.1.415 (x64)
*** END DRY RUN OUTPUT

To avoid breaking Visual Studio for Mac or other problems, read https://aka.ms/dotnet-core-uninstall-docs.

Run as administrator and use the remove command to uninstall these items.

Warning: Microsoft .NET Core SDK 3.1.415 (x64): Used by Visual Studio for Mac. Specify individually or use —-force to remove
Uninstalling this item will cause Visual Studio for to break.


./dotnet-core-uninstall dry-run --runtime 3.1.21

christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ ./dotnet-core-uninstall dry-run --runtime 3.1.21
*** DRY RUN OUTPUT
Specified versions:
  Microsoft .NET Core Runtime 3.1.21 (x64)
*** END DRY RUN OUTPUT

To avoid breaking Visual Studio for Mac or other problems, read https://aka.ms/dotnet-core-uninstall-docs.

Run as administrator and use the remove command to uninstall these items.

Warning: Microsoft .NET Core Runtime 3.1.21 (x64): Used by Visual Studio for Mac or SDKs. Specify individually or use —-force to remove
Uninstalling this item will cause Visual Studio for to break.
christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ 



./dotnet-core-uninstall remove --runtime 3.1.21
sudo ./dotnet-core-uninstall remove --sdk 3.1.415



christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ sudo ./dotnet-core-uninstall remove --runtime 3.1.21
Password:
The following items will be removed:
  Microsoft .NET Core Runtime 3.1.21 (x64)

To avoid breaking Visual Studio for Mac or other problems, read https://aka.ms/dotnet-core-uninstall-docs.

Do you want to continue? [y/n] y

Microsoft .NET Core Runtime 3.1.21 (x64): Used by Visual Studio for Mac or SDKs. Specify individually or use —-force to remove

Uninstalling this item will cause Visual Studio for Mac to break.

Are you sure you want to continue? [y/n] y
Uninstalling: Microsoft .NET Core Runtime 3.1.21 (x64).
christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$




christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ sudo ./dotnet-core-uninstall remove --sdk 3.1.415
Password:
The following items will be removed:
  Microsoft .NET Core SDK 3.1.415 (x64)

To avoid breaking Visual Studio for Mac or other problems, read https://aka.ms/dotnet-core-uninstall-docs.

Do you want to continue? [y/n] y

Microsoft .NET Core SDK 3.1.415 (x64): Used by Visual Studio for Mac. Specify individually or use —-force to remove

Uninstalling this item will cause Visual Studio for Mac to break.

Are you sure you want to continue? [y/n] y
Uninstalling: Microsoft .NET Core SDK 3.1.415 (x64).
christopher-fietzs-macbook-3:814.2.23 DotNet cwfietz$ 


still getting error on running dotnet
restarted Terminal

>env

PATH=
/Users/cwfietz/.nvm/versions/node/v14.17.3/bin:
/usr/local/bin:
/usr/local/sbin:
//usr/bin:
/bin:
/usr/sbin:
/sbin:
/usr/local/bin:
/Library/PostgresSQL/9.6/bin:
/opt/X11/bin:

/usr/local/share/dotnet:
~/.dotnet/tools:

/usr/local/git/bin:
/Library/Frameworks/Mono.framework/Versions/Current/Commands:
/Library/TeX/texbin:
/Applications/Xamarin Workbooks.app/Contents/SharedSupport/path-bin:
/usr/bin

PATH=“
/Users/cwfietz/.nvm/versions/node/v14.17.3/bin:
/usr/local/bin:
/usr/local/sbin:
//usr/bin:
/bin:
/usr/sbin:
/sbin:
/usr/local/bin:
/Library/PostgresSQL/9.6/bin:
/opt/X11/bin:
/usr/local/git/bin:
/Library/Frameworks/Mono.framework/Versions/Current/Commands:
/Library/TeX/texbin:
/Applications/Xamarin Workbooks.app/Contents/SharedSupport/path-bin:
/usr/bin”




declare -x PATH=“
/Users/cwfietz/.nvm/versions/node/v14.17.3/bin:
/usr/local/bin:
/usr/local/sbin:
//usr/bin:
/bin:
/usr/sbin:
/sbin:
/usr/local/bin:
/Library/PostgresSQL/9.6/bin:
/opt/X11/bin:
/usr/local/git/bin:
/Library/Frameworks/Mono.framework/Versions/Current/Commands:
/Library/TeX/texbin:
/Applications/Xamarin Workbooks.app/Contents/SharedSupport/path-bin:
/usr/bin”

declare -x PATH=/Users/cwfietz/.nvm/versions/node/v14.17.3/bin:/usr/local/bin:/usr/local/sbin://usr/bin:/bin:/usr/sbin:/sbin:/usr/local/bin:/Library/PostgresSQL/9.6/bin:/opt/X11/bin:/usr/local/git/bin:/Library/Frameworks/Mono.framework/Versions/Current/Commands:/Library/TeX/texbin:/Applications/Xamarin Workbooks.app/Contents/SharedSupport/path-bin:/usr/bin

Now dotnet is just a command that can’t be found.


Used TimeMachine to restore the Sept.25th version of the /usr/local/shared/dotnet files to ~/Users/cwfietz/temp. Changed the current /usr/local/shared/dotnet directory to /usr/local/shared/dotnet_old and then copied the restored /dotnet directory to /usr/local/shared/.

christopher-fietzs-macbook-3:~ cwfietz$ dotnet --version
2.1.302
christopher-fietzs-macbook-3:~ cwfietz$ dotnet --info
.NET Core SDK (reflecting any global.json):
 Version:   2.1.302
 Commit:    9048955601

Runtime Environment:
 OS Name:     Mac OS X
 OS Version:  10.12
 OS Platform: Darwin
 RID:         osx.10.12-x64
 Base Path:   /usr/local/share/dotnet/sdk/2.1.302/

Host (useful for support):
  Version: 2.1.2
  Commit:  811c3ce6c0

.NET Core SDKs installed:
  2.1.302 [/usr/local/share/dotnet/sdk]

.NET Core runtimes installed:
  Microsoft.AspNetCore.All 2.1.2 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.App 2.1.2 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 2.1.2 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]

To install additional .NET Core runtimes or SDKs:
  https://aka.ms/dotnet-download
christopher-fietzs-macbook-3:~ cwfietz$ 


Yea!

christopher-fietzs-macbook-3:GroceryCoProject cwfietz$ dotnet run
Hello everyone
What is your name?
Christopher

Hello, Christopher, on 2021-11-18 9:01:27 PM

Press a key to exit.
christopher-fietzs-macbook-3:GroceryCoProject cwfietz$ 

Yeah!

Now I’m back to where I started.


Exploring different options:

[Visual Studio 2017 for Mac Product Family System Requirements](https://docs.microsoft.com/en-us/visualstudio/releases/2017/vs2017-system-requirements-mac)
Versions 2019 and 2022 require newer operating systems.

Upgrading the Lenovo ThinkCentre M91p Desktop (with i5 processors)
[Microsoft Windows 10 Upgrade: A step-by-step procedure checklist](https://pcsupport.lenovo.com/py/en/products/desktops-and-all-in-ones/thinkcentre-m-series-desktops/thinkcentre-m91p/7052/solutions/HT104203)

[M91p: BIOS compatibility for Win10 (1903 update fails to install)](https://forums.lenovo.com/t5/ThinkCentre-A-E-M-S-Series/M91p-BIOS-compatibility-for-Win10-1903-update-fails-to-install/m-p/4529781)


Visual Studio
  - 2022
    - Windows 10 version 1909 or higher: Home, Professional, Education, and Enterprise.
  - 2019
    - Windows 10 version 1703 or higher: Home, Professional, Education, and Enterprise (LTSC and S are not supported)
    Windows 8.1 (with Update 2919355): Core, Professional, and Enterprise
    Windows 7 SP1 (with latest Windows Updates): Home Premium, Professional, Enterprise, Ultimate
  - 2017
    - 
    Windows 10 version 1507 or higher: Home, Professional, Education, and Enterprise (LTSC and S are not supported)
    Windows 8.1 (with Update 2919355): Core, Professional, and Enterprise
    Windows 7 SP1 (with latest Windows Updates): Home Premium, Professional, Enterprise, Ultimate

What about JetBrains Rider?
Requires
Microsoft Windows 8.1 or 10 (I have 7 but maybe could upgrade?)
macOS 10.14+ (I have 10.12) Maybe I could rebuild my computer? ooph.



What about making my current system work?

VS Code with .Net sdk 2.1.302




Commit message:

Attempt to debug Hello World


Attempt to debug Hello World on my MacBook Pro (2010) as I don't have my previous .Net C# computer anymore.

Run Hello World in the VS Code IDE 

But output doesn't include any "Hello World"!
  > Executing task: dotnet build /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/GroceryCoProject.csproj /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary <

  Microsoft (R) Build Engine version 15.7.179.6572 for .NET Core
  Copyright (C) Microsoft Corporation. All rights reserved.

    Restore completed in 97.09 ms for /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/GroceryCoProject.csproj.
    GroceryCoProject -> /Users/cwfietz/src/Projects/GroceryCo/GroceryCoProject/bin/Debug/netcoreapp2.1/GroceryCoProject.dll

  Terminal will be reused by tasks, press any key to close it.

But when I run "dotnet run" from the command line in the terminal I do get "Hello World"


Follow steps in [Tutorial: Debug a .NET console application using Visual Studio Code - Set up for terminal input](https://docs.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0#set-up-for-terminal-input) etc.)

Same result. Only works from running "dotnet run" at the command line.

Attempted to install .Net 6 and .Net 5 but these are too new for OS X 10.12
Installed .NET Core 3.1 SDK (v3.1.415) but even running dotnet resulted in an error
Eventually used an uninstaller and backups from TimeMachine to restore the orginal .Net Core 2.1.2 SDK (v2.1.302) files and returned to being able to call dotnet run from the command line.

Spent lots of time considering different IDEs (VS Code, Visual Studio for Mac, Rider) and different hardware and operating systems (Lenovo ThinkCentre M91p with Windows 7 and VS Code, Visual Studio or Rider). Each will require non-trivial amounts of time to implement.

Wrote Lawrence Joshua "LJ", Senior Talent Acquisition Partner at Absorb to ask which of these hardware, OS, and IDE combinations would be closest to what is used at Absorb so I can at least practice the best set of keyboard shortcuts.

Still don't have a means to run the code from the IDE with a key or icon press. Don't have a testing frame work. So no TDD yet. I'd rather now develop without at least these. I would also like to use Approval Tests [https://approvaltests.com/]

Will consider using current computer, with current IDE. Will continue in the morning.
I will start with [Visual Studio Code - Debugging](https://code.visualstudio.com/docs/editor/debugging) Launch configurations#




Next, day. 
Just going to download Visual Studio for Mac and try Hellow world again.



[Visual Studio - older versions](https://visualstudio.microsoft.com/vs/older-downloads/#visual-studio-2017-and-other-products)

https://my.visualstudio.com/Downloads?q=visual%20studio%202017&wt.mc_id=o~msft~vscom~older-downloads

saved to:
/Users/cwfietz/Documents/800 Interests/814 Computer/814.2 Applications/814.2.30 Microsoft Visual Studio

There is an older installer here too.

The installer checked for .NET 2.x which is good.

What would you like to install?

Visual Studio for Mac 7.7.0
Platforms
.NET Core + ASP.NET 2.0.5 - installed
Android + Xaminrin.Forms 9.1.0
    Mobile OpenJDK  1.8.0
    Intel(R) HAXM - 7.3.2
    Android SDK 27.0.0
iOS + Xamarin.Forms 12.2.1
macOS 5.2.1
Tools
Xamarin Workbooks 1.5.0

Links to “Getting started documents”

[Visual Studio 2019 for Mac tour](https://docs.microsoft.com/en-ca/visualstudio/mac/ide-tour?view=vsmac-2019)

[Visual Studio Tools for Unity](https://docs.microsoft.com/en-ca/visualstudio/gamedev/unity/get-started/visual-studio-tools-for-unity?view=vsmac-2019)

[Getting Started with ASP.NET Core](https://docs.microsoft.com/en-ca/visualstudio/mac/asp-net-core?view=vsmac-2019)

[Xamarin documentation](https://docs.microsoft.com/en-ca/xamarin/)

The Intel(R) HAXM - 7.3.2 part failed to install. I tried again. It failed again. I deselected it and tried again.

[What is Intel(R) HAXM]
https://www.google.com/search?client=firefox-b-d&q=What+is+Intel%28R%29+HAXM
HAXM is a cross-platform hardware-assisted virtualization engine (hypervisor), widely used as an accelerator for Android Emulator and QEMU. It has always supported running on Windows and macOS, and has been ported to other host operating systems as well, such as Linux and NetBSD.

https://github.com/intel/haxm

Installer seemed to finish. Created dashboard link to VisualStudio.app in the Applications directory and clicked it.

Once opened I can see it found the files for 6 previous C# projects, including HelloWorld

There are updates and files to read. 

https://docs.microsoft.com/en-us/visualstudio/releasenotes/vs2017-mac-relnotes-v7.7#---visual-studio-2017-for-mac-version-7741

installing and restarting
There are so many extensions to consider.
Opening the Hello World project from Udemy C# class to see if it runs.
It does!

Taking a break





Printed Coding Exercise v. 1.1.3.pdf
Noted nouns and verbs as first step to determine object model

Users:
Customers
Marketing team

Nouns:
a prototype checkout system
current price catalog
products, items
regular price, effective price
promotions (limited time)
        On Sale price = a price less than the regular price
    Advanced:
        Group promotional price based on the quantity purchased
        Additional product discount
Quantity of specific product, an attribute of the customer basket or a promotion
Time for promotions and time of checkout
Customer’s basket
final total price
Latest pricing rules
    (current price catalog, promotions)
Itemized receipt
    (item, regular price, discount or saving, [effective price?]) + final total price

Inputs:
current price catalog
promotions
customer’s basket = a simple file containing *unsorted* list of items=products in which a product can be listed multiple times

Verbs:
Checkout
apply promotion
Calculate
Display
Print itemized receipt

Output
Itemized receipt
    (item, regular price, discount or saving, [effective price?]) + total price

Assumptions
prices in dollars though ‘$’ can be replaced with other symbols
dollars - tenths and hundredths, rounded
rounding in GroceryCo’s favour

All time in local time - events would otherwise be recorded in UTC - we make this assumption as the kiosks are in physical stores and the transactions aren’t happening all hours of the day possibly crossing midnight and therefore different dates.
Promotions change at the last minute but are assumed to be in effect only on given dates not during different hours or minutes of a day.
Future challenge: use UTC times for everything so as to make a promotion effective at a moment rather than a date.

each line of the customer’s basket file represents only one item, no instances of
“3 apples”, only
“
apple
apple
apple
”
Won’t use commas in customer basket file

current price catalog and promotions as input text files rather than database engine data

width of receipt on paper fixed

effective price listed on receipt even though it isn’t called for in the instructions

lowest price (regular or effective) is zero. No negative prices.
No sales that increase the prices.

No logging as I am not yet familiar with C#’s logging modules

No consideration for translating amounts into other currencies. e.g. no translating into U.S.A. dollars.

Spelling? Yes,
Case of letters? is rose=Rose?





What?
What do you know:
I could have been using C# and NUnit last Thursday afternoon.
https://cyber-dojo.org/creator/choose_type?exercise_name=Fizz%20Buzz&language_name=C%23%2C%20NUnit
<sign>
But this would not provide the git repository itself to put on gitHub?

Now, back to running Hello World.
Yes! I can set a break point, run the code in debug mode, it will stop and I can inspect the state and then step forward in the code!
Finally.

Don’t forget to lookup variable naming standards for C#.

[C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)

[C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)


Visual Studio Community 2017 for Mac is not opening the previous repository so I am starting a new one.

PrototypeCheckoutSystem


Copied previous Notes file to this new repository.

Now to commit and push to GitHub

Now to rename "Master" branch to "main" in git
git branch -m master main


