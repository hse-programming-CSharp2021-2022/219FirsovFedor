#include <iostream>

int task_06() {
    int data;
    std::cin >> data;

    int res = 0;
    int cur = 0;
    while (data != 0) {
        if (data % 2 == 0) {
            cur++;
        }
        else {
            res = std::max(res, cur);
            cur = 0;
        }
        std::cin >> data;
    }
    std::cout << res << std::endl;
}
