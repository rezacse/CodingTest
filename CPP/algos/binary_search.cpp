#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int> v, int l, int h, int t) {
    if (l <= h) {
        int m = (l + h) / 2;
        if (v[m] == t) return m;
        if (t < v[m]) return binarySearch(v, l, m - 1, t);
        else return binarySearch(v, m + 1, h, t);
    }
}