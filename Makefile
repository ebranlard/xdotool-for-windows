
CSC=csc
CSC=mcs
CSFLAGS=/r:System.Windows.Forms.dll

PROG=xdotool.exe



all: $(PROG) test

$(PROG): xdotool.cs
	$(CSC) xdotool.cs $(CSFLAGS)


test:
	$(PROG) -h
	$(PROG) key "{Escape}^v"
