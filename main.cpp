#include <iostream>
using namespace std;

int main()
{
    int t;
    cin >> t;
    while (t--)
    {
        int n, s, i, a[101];
        cin >> n >> s;
        for (i = 1; i <= n; i++)
            cin >> a[i];

        getIndex(a, n, s);
    }

    return 0;
}