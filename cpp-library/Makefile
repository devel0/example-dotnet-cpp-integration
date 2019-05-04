CC=g++
CFLAGS=-c -Wall -fPIC
LDFLAGS=-shared
SOURCES=lib.cpp
OBJECTS=$(SOURCES:.cpp=.o)
LIBRARY=lib.so

all: $(SOURCES) $(LIBRARY)

$(LIBRARY): $(OBJECTS)
	mkdir -p `dirname $(LIBRARY)`
	$(CC) $(LDFLAGS) $(OBJECTS) -o $@

.cpp.o:
	$(CC) $(CFLAGS) $< -o $@

clean:
	rm -f *.o *.so