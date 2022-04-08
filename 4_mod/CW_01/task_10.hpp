#include <bits/stdc++.h>

int task_10() {
    long long n;
    std::cin >> n;
    std::vector<int> ans1, ans2;

    for (long long i = 1; i * i <= n; ++i) {
        if (n % i == 0) {
            ans1.push_back(i);
            if (i * i != n)
                ans2.push_back(n / i);
        }
    }

    for (int i : ans1) {
        std::cout << i << ' ';
    }

    // тут магия с кастом -1 у unsigned int
    for (size_t i = ans2.size() - 1; i != -1; --i) {
        std::cout << ans2[i] << ' ';
    }
}