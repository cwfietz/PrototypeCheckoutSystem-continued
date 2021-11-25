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


Added a menu
[“C# console application menu system” Code Answer](https://www.codegrepper.com/code-examples/csharp/c%23+console+application+menu+system)

Would like to generalize it a bit more.
[What is the "correct" way of making a console menu?](https://stackoverflow.com/questions/53234070/what-is-the-correct-way-of-making-a-console-menu)
[Convert a string to an enum in C#](https://stackoverflow.com/questions/16100/convert-a-string-to-an-enum-in-c-sharp)
[Tutorial: Create a simple C# console app in Visual Studio 2017 (part 1 of 2)](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2017)
[Tutorial: Create a simple C# console app in Visual Studio 2022 (part 1 of 2)](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022)
[Tutorial: Extend C# console app and debug in Visual Studio (part 2 of 2)](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console-part-2?view=vs-2022)
There is no corresponding 2017 version
[Wellb - Create a Menu in C# Console Application](https://wellsb.com/csharp/beginners/create-menu-csharp-console-application)
[A Webdesign - Console App-Creating a Menu with Options and simple Calculations. Easy to follow tutorial](Console App-Creating a Menu with Options and simple Calculations. Easy to follow tutorial)

Oh! Logging!
[Reference .NET libraries: Write to a log](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console-part-2?view=vs-2022#reference-net-libraries-write-to-a-log)


Focusing on:
"Here is another approach, which is to create a class that represents a MenuItem, which has a description and an associated method that should be called if that item is chosen."
of
[What is the "correct" way of making a console menu?](https://stackoverflow.com/questions/53234070/what-is-the-correct-way-of-making-a-console-menu)

12345678901234567890123456789012345678901234567890

Change to numbered menu 

Menu now extensable and allows the user to select 
an integer instead of pressing the down arrow a
number of times.
Would like to generalize and refactor more but it
is time to move onto the heart of the program.

Next,
Change "Edit" options to "Show"
Create simple input files and begin developing the core Calculate algorithm, then work out from there.


[Despite .NET Core 3 Deprecation, Newtonsoft JSON Serializer Still Rules NuGet Roost](https://visualstudiomagazine.com/articles/2020/07/28/json-serializers.aspx)

https://www.newtonsoft.com/json


[How to serialize and deserialize (marshal and unmarshal) JSON in .NET]()


I had problems getting System.Text.Json to work so I found an example of making newtonsoft.json version 11.01 work.

see commit message: Experiments with reading and writing json

Now to build a product to price catalogue

[What is the best data type to use for currency in C#?](https://www.tutorialspoint.com/what-is-the-best-data-type-to-use-for-currency-in-chash)
decimal

[C# Dictionary In C#](https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/)

And we are well past time to start using TDD 
[How to Unit Test using Visual Studio for Mac (it's easy!) - Method 2: Add NUnit to an Existing Project](https://grantwinney.com/tdd-test-driven-development-using-visual-studio-for-mac/#method-2-add-nunit-to-an-existing-project)

[How to do constructor chaining in C#](https://stackoverflow.com/questions/1814953/how-to-do-constructor-chaining-in-c-sharp)

[Embedding Quotes Within A C# String](https://www.davidgiard.com/2018/11/02/EmbeddingQuotesWithinACString.aspx)

As of:
    Mon Nov 22 19:41:19 2021 -0700
        Add Product
        
I have products that have regular price.

Next, put a few of products into a dictionary and then save it to json file to see the result.

[How do I convert a dictionary to a JSON String in C#?](https://stackoverflow.com/questions/5597349/how-do-i-convert-a-dictionary-to-a-json-string-in-c)
[SortedDictionary<TKey,TValue> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2?redirectedfrom=MSDN&view=net-6.0#remarks)
"If the list is populated all at once from sorted data, SortedList<TKey,TValue> is faster than SortedDictionary<TKey,TValue>."
- But the customer basket will not be sorted and the calculation process will need have the data structed holding the results of the customer basket being built each time.

[Dictionary<TKey,TValue> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0#remarks)


Add more catalogue tests and notes


Deciding if I should have
<string name, Product> 
    pairs in which the name is repeated,
<string, Amount> pairs, or
<string, decimal> pairs

Just use the pair in the dictionary to represent 
what I've been calling a product.

I'll continue with the current experiment for now.

ExampleCatalogueAsDictOfProducts.json:
{
  "Pineapple": {
    "RegularPrice": {
      "Symbol": "$",
      "Amount": 1.08
    },
    "Name": "Pineapple"
  },
  "Pepperoni": {
    "RegularPrice": {
      "Symbol": "$",
      "Amount": 5.73
    },
    "Name": "Pepperoni"
  }
}

I can see that this will work but it is a bit
over done. Having the name as a property and the 
key of each entry is redundant. Having the Symbol
repeated for each entry is redundant.

I'm am considering symplifying things knowing I can
add the product object back in if needed.

         
All that is needed now is:

{
  "Pineapple": 1.08,
  "Pepperoni": 5.73
}
         
But, using the json serializers means I don't have
to do the serialization manually. The output to the
screen or a saved file for users can be different.
Will continue the experiment with a new 
toString() method. The dictionary of the catalogue
would mostly likely be data stored behind a 
database engine.

What is the process of reading in the basket?
It will result in a sorted dictionary of product 
name as the key and the quantity as the value.

The calculation will begin with retrieving the 
regular price for each of the product names in the
sorted dictionary. This will require the name as 
the key and then pulling out the 
product.regularprice.amount and appending that to
 the value in the dictionary
then applay promitions by item and quantity to 
get the effective price for the product

Then the total can be found by totalling the 
effective prices. These results can be achieve by 
a more functional style. Would the process be 
easier if the amount is pulled from a name: amount 
paring in the dicionary. I don't see there being a 
big difference.

Next, make a new diplay method.

12345678901234567890123456789012345678901234567890
         1         2         3         4         5
                  
[How to Sort a C# Dictionary By Key (and when not to!)]()https://csharpsage.com/sort-dictionary-by-key/#One-off_sorting_dictionary_by_key_and_by_value)



Now that I'm attempting to read in the ProductCatalogue from a file, it is clear that a simple <string, decimal value> pair will be much easier to read back into a dictionary.
So, next, simplify the whole ProductCatalogue class.
[How do I read and write a C# string Dictionary to a file?](https://stackoverflow.com/questions/27025435/how-do-i-read-and-write-a-c-sharp-string-dictionary-to-a-file)

OPTION 3 - Use JSON.NET
File.WriteAllText("SomeFile.Txt", JsonConvert.SerializeObject(dictionary));

Read:

var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>
    (File.ReadAllText("SomeFile.txt"));
    
    
Or with JSON.Net you can serialize your dictionary to JSON and then write it to file and then deserialize it, like:
    ```
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    dictionary.Add("1", "Some value 1");
    dictionary.Add("2", "Something");
    ```
Storing Dictionary in file:
    ```
    string json = JsonConvert.SerializeObject(dictionary);
    File.WriteAllText("SomeFile.Txt", json);
    ```
Getting Dictionary back from file:
    ```
    Dictionary<string, string> previousDictionary =
     JsonConvert.DeserializeObject<Dictionary<string, string>>
                                     (File.ReadAllText("SomeFile.txt"));
    ```


I can not write to files from tests but I can write to files from the production code.

I can use
```
JsonConvert.SerializeObject(catalogue, Formatting.Indented);
```
to fomat the file to be eaiser to read.

Now to commit and rebuild the ProductCatalogue class.



Test writing and reading catalogue to file


Now that I'm attempting to read in the ProductCatalogue from a file, it is clear that a simple <string, decimal value> pair will be much easier to read back into a dictionary.
So, next, simplify the whole ProductCatalogue class.


ExampleCatalogueAsDictOfProducts.json:
{
  "Pineapple": {
    "RegularPrice": {
      "Symbol": "$",
      "Amount": 1.08
    },
    "Name": "Pineapple"
  },
  "Pepperoni": {
    "RegularPrice": {
      "Symbol": "$",
      "Amount": 5.73
    },
    "Name": "Pepperoni"
  }
}

Is harder to work with than:
CatalogueFile.json
{
  "Pineapple": 3.99,
  "Pepperoni": 5.73,
  "Apple": 1.08,
  "Orange": 1.68,
  "Banana": 0.79,
  "Milk": 2.85,
  "Salmon": 20.64,
  "Cheese": 7.42,
  "Bread": 3.54,
  "Olive oil": 12.58,
  "Chocolate bar": 2.15,
  "Fennel seeds": 3.45,
  "Pepper": 4.05,
  "Cantaloupe": 3.79,
  "Eggs": 8.14,
  "Celery": 2.75,
  "Lettus": 6.0,
  "Nutmeg": 4.93
}


Redo MoneyAmount and Product tests

Having the ProductCatalogue retrieve the data from the file is proving untestable and probably a bad design.
Tomorrow I will try separating the file read and writing parts of the ProductCatalogue so that the other operations can be tested.



Add CustomerBasket 

using ProductCatalogue as a template
neither should refer to reading the file in the constructor

Spent too much time setting up a dev environment and too much time focusing on files instead of the core problem, implementing promotions.
Next, implement Calculate and Promotions

Spending too much time on Classes and Builders

Continuing to develop solution using TDD.


Add RetrievePricesForBasket()

and ProductReceiptDetails as list items for a simple receipt.
Added a stub for Promotions as an empty string.
Next, total price

- Used a dictionary for the Product Catalogue as it can be queried at O(1). I'd expect an actual catalogue to be very large.
- Used a sorted dictionary for sorting the basket as I do not expect the basket to be so large that O(n*log()n)) is too much of a cost and it provides the sorting.
- Used a list for the ProductReceiptEntries as the baskets has been sorted.

Remove unecessary usings

uncommented and fixed tests
for ProductCatalogueTests
