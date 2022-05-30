#pragma once
#ifndef SYSALGORITHM_H
#define SYSALGORITHM_H

#include <fstream>
#include <string>

class Calculator
{
public:
	Calculator();
	~Calculator();

	int add(int a, int b);
	int subtract(int a, int b);
};

#endif // !SYSALGORITHM_H
