
CSC=csc
CSC=mcs

PROG=xdotool.exe



all: $(PROG) test

$(PROG): xdotool.cs
	$(CSC) xdotool.cs


test:
	$(PROG) -h
	$(PROG) key "{Escape}^v"
