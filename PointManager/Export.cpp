#include "PointManager.h"

extern "C"
{
    __declspec(dllexport) PointManager* CreatePointManager()
    {
        return new PointManager();
    }

    __declspec(dllexport) void DestroyPointManager(PointManager* pm)
    {
        delete pm;
    }

    __declspec(dllexport) void PointManager_AddPoint(PointManager* pm, int x, int y)
    {
        pm->AddPoint(x, y);
    }

    __declspec(dllexport) void PointManager_RemovePoint(PointManager* pm, int index)
    {
        pm->RemovePoint(index);
    }

    __declspec(dllexport) void PointManager_GetPoint(PointManager* pm, int index, int* x, int* y)
    {
        pm->GetPoint(index, x, y);
    }

    __declspec(dllexport) int PointManager_Count(PointManager* pm)
    {
        return pm->Count();
    }
}
#include "pch.h"