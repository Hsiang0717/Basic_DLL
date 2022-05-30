#include "pch.h"
#include "SysAlgorithm.h"
#define MyDLL_API __declspec(dllexport)


//https://openweather.blogspot.com/2020/03/c-c-dll.html

extern "C" MyDLL_API int add(int a, int b)
{
	Calculator Calculator;
	return Calculator.add(a, b);
}

extern "C" MyDLL_API int subtract(int a, int b)
{
	Calculator Calculator;
	return Calculator.subtract(a, b);
}