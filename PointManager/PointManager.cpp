#include "PointManager.h"

void PointManager::AddPoint(int x, int y)
{
    points.push_back({ x, y });
}

void PointManager::RemovePoint(int index)
{
    if (index >= 0 && index < points.size())
    {
        points.erase(points.begin() + index);
    }
}

void PointManager::GetPoint(int index, int* x, int* y)
{
    if (index >= 0 && index < points.size())
    {
        *x = points[index].first;
        *y = points[index].second;
    }
}

int PointManager::Count()
{
    return (int)points.size();
}
#include "pch.h"