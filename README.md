# xdotool-for-windows
Command line implementation of xdotool for windows. 

Only one feature of the linux tool xdotool is implemented so far, that is:

- Send keys to the active window

The program is written in C-sharp.
This repository contains the source code, compatible Mono or Microsoft.

The program can be used with [wmctrl-for-windows](https://github.com/ebranlard/wmctrl-for-windows/) to switch to a given window before executing keys. 

## Binaries
The latest binary is available [here](https://github.com/ebranlard/xdotool-for-windows/raw/master/_bin/xdotool.exe)

## Features/ usage
Typical usage:
```bash
# Send control-v
xdotool key "^v"
# Send alt-F4
xdotool key "%{F4}"
# Send Shift-6 (that's the "^" character)
xdotool key "+6"
# Send Arrow keys (up three times)
xdotool key "{Up}{Up}{Up}"
# Send "windows" key (not supported for now..)
```

Command-line usage:
```bash
xdotool [options] cmd [args]

options:
  -h         : show this help

cmd:
  key <KEYS>: send keys
```


## Installation
Compile.
Put the exe file somewhere in your system path.
