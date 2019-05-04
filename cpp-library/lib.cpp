#include <stdio.h>
#include <stdlib.h>
#include <sstream>

extern "C"
{
    int sum(int a, int b)
    {
        return a + b;
    }

    void follower(int q, void *(fn)(const char *msg))
    {
        for (int x = 0; x < q; ++x)
        {
            std::stringstream ss;

            ss << "sample message iteration n." << x;

            fn(ss.str().c_str());
        }
    }
}