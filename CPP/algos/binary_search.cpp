#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int> v, int t) {
    int l = 0, h = v.size() - 1, i = -1;
    while (l <= h) {
        int m = (l + h) / 2;
        if (v[m] == t) {
            i = m;
            break;
        }
        if (t < v[m]) h = m - 1;
        else l = m + 1;
    }
    return i;
}