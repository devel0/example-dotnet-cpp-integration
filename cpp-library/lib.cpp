#include <stdio.h>
#include <stdlib.h>

extern "C"
{
    int sum(int a, int b)
    {
        return a + b;
    }
}