// pch.cpp: файл исходного кода, соответствующий предварительно скомпилированному заголовочному файлу

#include "pch.h"

// При использовании предварительно скомпилированных заголовочных файлов необходим следующий файл исходного кода для выполнения сборки.
#include "Calcutator.h"
extern "C" {
	__declspec(dllexport)Calculator* CreateCalculatorObject() {
		return new Calculator();
	}
	__declspec(dllexport) void DeleteCalculatorObject(Calculator* obj) {
		delete obj;
	}
	__declspec(dllexport)int Add(Calculator* obj, int a, int b) {
		if (obj != nullptr) {
			return obj->Add(a, b);
		}
		throw "Object is nullptr";
	}
}
