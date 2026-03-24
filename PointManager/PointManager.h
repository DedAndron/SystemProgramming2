#pragma once
#include <vector>
using namespace std;

class PointManager
{
private:
    vector<pair<int, int>> points;

public:
    void AddPoint(int x, int y);
    void RemovePoint(int index);
    void GetPoint(int index, int* x, int* y);
    int Count();
};