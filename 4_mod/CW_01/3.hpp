#include <bits/stdc++.h>

int sol3() {

    int curr = -1;
    int count = 0;
    int data;
    std::cin >> data;
    while (data != 0) {

        if (data == curr) {
            count++;
        } else {
            if (count == 0) {
                curr = data;
                count = 1;
            } else {
                count--;
            }
        }
        std::cin >> data;
    }
    std::cout << curr << std::endl;
}