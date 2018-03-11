#include <iostream>

using namespace std;

int main()
{
    int t, n, i, a[1000];
    cin >> t;
    while (t--)
    {
        cin >> n;
        for (i = 0; i < n; i++)
            cin >> a[i];
            
        //BETTER SOLUTION
        i = 0;
        int m = a[i];
        while (i < n)
        {
            int lm = a[i];
            int temp = lm;
            for (int j = i + 1; j < n; j++)
            {
                temp += a[j];
                if (temp > lm)
                {
                    lm = temp;
                }
            }

            if (lm > m)
            {
                m = lm;
                i++;
            } else {
                i++;
            }
        }
        cout << m << endl;

        //FIRST SOLUTION
        // i = 0;
        // int m = a[i];
        // while (i < n)
        // {
        //     int lm = a[i];
        //     int temp = lm;
        //     for (int j = i + 1; j < n; j++)
        //     {
        //         temp += a[j];
        //         if (temp > lm)
        //         {
        //             lm = temp;
        //         }
        //     }

        //     if (lm > m)
        //     {
        //         m = lm;
        //         i++;
        //     } else {
        //         i++;
        //     }
        // }
        // cout << m << endl;
    }

    return 0;
}