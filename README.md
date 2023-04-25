# AnyCubic Kobra/Plus/Max UI - ShadowUI

This is a new UI for the AnyCubic Kobra/Plus/Max 3D printers. This replaces the clunky monochrome UI with a colorful and user friendly experience. This is only a UI update and should work with either factory or custom firmwares.

This is written to support many languages. The current list is Chinese, Dutch, English, French, German, Italian, Spanish, and Thai. These were generated with Google translate. If there are any inaccuracies or someone believes the translations to be correct, feel free to message me in regards to this.

Each language was overwritten on the English screens. So you would need to re-flash with the appropriate set of files for the desired language. Also, the “Language” button has been disabled since this is the process for changing languages.

This should work with 3 of the Kobra series printers. The Kobra and Kobra Plus have not been fully tested. The Kobra Max has been thoroughly tested.

![Preview 1](/Source/Media/121.png)
![Preview 1](/Source/Media/124.png)
![Preview 1](/Source/Media/128.png)
![Preview 1](/Source/Media/140.png)
![Preview 1](/Source/Media/153.png)
![Preview 1](/Source/Media/204.png)

[![Preview Video](https://img.youtube.com/vi/XPdt1kJQ2_s/maxresdefault.jpg)](https://youtu.be/XPdt1kJQ2_s)


## Installing ShadowUI firmware

1. Download the latest release and locate the build for the desired language.

2. Copy the DWIN_SET folder to the root of a blank SD card.

3. Turn off the printer and insert the SD card under the screen (upside down, with the metal contacts up).

4. Turn on the printer and you should get a blue screen. Please wait while the firmware is updated. You should see that the file counts match [.CFG 001, .BIN 003, .ICL 001] and then near the top right it will display “END!” after the “SD Card Process…”. <see photo>

![Example](/Source/Media/Process.jpg)


## Reverting to original factory firmware

Note: This is to go back to factory defaults if you do not wish to continue using ShadowUI.

1. Go to AnyCubic’s website firmware page [https://www.anycubic.com/pages/firmware-software]. Select your printer series on the left. Select your model on the right. You should see latest firmware version and a link to download it.

2. Locate the “Screen\DWIN_SET” folder and copy the “DWIN_SET” folder to the root of your BLANK SD card. There should be several more files for the original firmware.

3. Turn off the printer and insert the SD card under the screen (upside down, with the metal contacts up).

4. Turn on the printer and you should get a blue screen. Please wait while the firmware is updated. You should see that the file counts match files from the download and then near the top right it will display “END!” after the “SD Card Process…”.
