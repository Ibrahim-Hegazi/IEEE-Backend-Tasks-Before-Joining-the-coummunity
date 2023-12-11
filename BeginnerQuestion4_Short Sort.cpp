#include <iostream>
#include <iomanip>
#include <math.h>
#include <cmath>
#include<bits/stdc++.h>
#define fast ios::sync_with_stdio(0);cin.tie(0);cout.tie(0);
#define ll long long
#define ld long 
#define ull unsigned long long
#define loop(n) for(ll i=0;i<n;i++)
#define lop(m) for(ll j=0;j<m:j++)
#define lpse(i,s,e)for (ll i = s; i <=e ; i++)
using namespace std;

int main() {
    // Problem Link : https://codeforces.com/problemset/problem/1873/A
    //My Algorithm description
    //Here we gonna count how many letter is not in its right place and increase the counter.
    //If the counter value is greater than 2 we will output no because the question said that we can only change the positions of 2 letter just only once
    int t; cin >> t;
    string s;
    for (int i = 0; i < t; i++)
    {
        cin >> s;
        int cnt{ 0 };
        if (s[0] != 'a')cnt++;
        if (s[1] != 'b')cnt++;
        if (s[2] != 'c')cnt++;
        if (cnt > 2)cout << "NO\n";
        else cout << "YES\n";
    }
    return 0;
}
