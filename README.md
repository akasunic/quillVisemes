**Overview**

The idea: this is an all-in-one tool for analyzing one or multiple audio files to extract viseme information and then transfer that viseme information to characters you have created in Quill. It makes use of [Joan Charmant’s SharpQuill](https://github.com/JoanCharmant/SharpQuill), a library for reading and writing Quill files, and [Daniel S Wolf’s Rhubarb Lip Sync](https://github.com/DanielSWolf/rhubarb-lip-sync) command line interface for generating viseme outputs. I used C#, Visual Studio, WinForms to create the standalone application. The github repository for this and other mini projects I made using SharpQuill is [here](https://github.com/akasunic/SharpQuill).

In practice, there are some issues. More on that below. But perhaps this can be a starting point for future work, or may already help as is in some cases.

**Preparation for running the tool**



* **You must download/install [Rhubarb Lip Sync](https://github.com/DanielSWolf/rhubarb-lip-sync/releases)**. This tool uses v1.13.0. The first time you use the Viseme Automator, you will be asked to set the location of the rhubarb.exe file. After that, you no longer have to set it (I keep the set or replace option there in case you move the .exe file’s location for some reason). 
* For each character you want to add lip sync to, you must have a mouth folder that contains viseme folders, each of which should contain a paint layer (multiple okay, too) with that viseme. 
* This project uses the visemes and associated naming structure from Rhubarb Lip Sync. These are: A, B, C, D, E, F, G, H, X. See chart on [Daniel S Wolf’s Rhubarb Lip Sync](https://github.com/DanielSWolf/rhubarb-lip-sync).
* Don’t add audio: Add your audio files _after_ you’ve created the visemes-automated version using this tool. If you include audio files in your input Quill project, they won’t transfer to the edited viseme project. So you might as well add them in after. More on this under Limitations.


**Running the tool/troubleshooting**



* Please feel free to contact me via email (or discord dm on Virtual Animation) – both amkasunic. Email is gmail. 
* I’ve tried to make the tool itself pretty straightforward, but I did no user testing; I basically designed the interface for myself. So it may not always be obvious. If you have questions or requests, let me know.
* I also did some bug hunting explorations, so the tool should catch some user errors and output some advice (look for the outdated flashing red Xs…). But I’m sure I missed some. If anyone uses this tool and encounters issues, please feel free to contact me. 
* If you press Create but then see a red X error somewhere on the form, that means you have user errors that are preventing the tool from running rhubarb and/or creating the Quill project. Hover over the X’s for more information. You must fix those errors first and try again.

**Expectations for the resulting Quill project**



* This tool will create a new project; your original project will not be tampered with. You can expect to see the viseme folders with In and Out Timeline Keyframes. 
* You will still need to add audio, and match those audio files up with the mouth layers in the timeline for proper results.
* At the end of the layer list, you will also see NeutralMouth folders for each of the characters. This is just a copy of the original X viseme mouth. This way, if you are stringing together multiple audio files per character, or have gaps, you can make use of this if you’d like. 
* To ease transitions between visemes, you can use frame-by-frame on the paint layers.

**Limitations & Future Work**

_Winforms_



* I built this in WinForms, which is very outdated, but it was a straightforward way to build on SharpQuill. But afterwards, I realized I could have just been editing Quill.json directly since I don’t technically need to modify the qbin for this project. 
* SharpQuill does not currently include methods for decoding audio data from the qbin file, and that’s out of my wheelhouse. Because I used SharpQuill instead of editing Quill.json directly, I can’t successfully copy an audio file from one Quill project to another. If anyone wants to tackle this problem, that would be awesome.

_Rhubarb results, analyzing audio separately, other viseme analyzers, load times_



* Rhubarb is great at automatically analyzing, but the results are not always perfect. This tool does not allow for editing the output directly.
* This tool’s “all-in-one” approach is not always ideal; it might be better in many cases to analyze the audio separately, and feed in a viseme output file. This would also allow the tool to be more versatile, allowing for use of output from other programs like [Papagayo](https://github.com/morevnaproject-org/papagayo-ng). 
* Rhubarb buffers its shell output, so I had trouble parsing that info piece by piece. Hence the long wait times while Rhubarb is analyzing audio files (especially for long audio files) with no progress percent feedback. Contributions welcome here!

**Credits**

Thanks to Joan Charmant for[ SharpQuill](https://github.com/JoanCharmant/SharpQuill) and Daniel S Wolf for [Rhubarb Lip Sync](https://github.com/DanielSWolf/rhubarb-lip-sync). Check them both out on Github!

I also used a couple of free icons from Noun Project and elsewhere (trash, add, attach, mouth for icon) in my pathetic attempt to “modernize” WinForms a bit. This a reminder to myself to add the credits for those icons later. 
