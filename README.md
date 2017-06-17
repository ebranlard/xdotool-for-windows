# xdotool-for windows
Command line implementation of xdotool for windows (pseudo-equivalent)

Only one feature of the linux tool xdotool is implemented so far, that is:
    - Send keys to the active window

The program is written in C-sharp.
This repository contains the source code, compatible Mono or Microsoft.


## Binaries
The latest binary is available [here](https://github.com/elmanuelito/xdotool-for-windows/raw/master/_bin/xdotool.exe)

## Features/ usage
usage: xdotool [options] cmd [args]

options:
  -h         : show this help

cmd:
  key <KEYS>: send keys

## Installation
Compile.
Put the exe file somewhere in your system path.
