#include "stdafx.h"
#include "CycledAlgorithm.h"
#include <fstream>
#include "lab1.h"
static char* fileValues = "cycled_values.txt";
static char* fileResult = "cycled_result.txt";
using namespace std;

int factorial(int k) {
	int value = 1;
	if (k == 0)
		return 1;
	else
	{
		for (int i = 1; i <= k; i++)
		{
			value *= i;
		}
		return value;
	}
}



int function(int i, int	 j, int n)
{
	if (i<0 || j<0)
	{
		MessageBox(NULL, "i, j должны быть неотрицательными!", "Ошибка", MB_OK);
		return NULL;
	}
	else
	{
		int tempVar1 = 1, tempVar2 = 0;
		for (int p = j; p <= n; p++)
		{
			tempVar1 *= factorial(p);
		}
		for (int p = i; p <= n; p++)
		{
			tempVar2 += factorial(p);
		}
		return tempVar1 - tempVar2;

	}

}
INT_PTR CALLBACK CycledAlgoWnd(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		return (INT_PTR)TRUE;
	case WM_COMMAND:
	{
		int wmId = LOWORD(wParam);
		switch (wmId)
		{
		case IDC_BUTTON3_READ:
		{
			fstream file;
			file.open(fileValues);
			int i, j, n;
			const int len = 30;
			TCHAR strI[len];
			TCHAR strJ[len];
			TCHAR strN[len];
			file >> i >> j >> n;
			sprintf_s(strI, "%i", i);
			sprintf_s(strJ, "%i", j);
			sprintf_s(strN, "%i", n);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT3_I), strI);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT3_J), strJ);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT3_N), strN);
			file.close();
			break;
		}
		case IDC_BUTTON3_WRITE:
		{
			fstream file;
			file.open(fileResult);
			file.clear();
			int y;
			const int len = 30;
			TCHAR strY[len];
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT3_Y), strY, len);
			y = atoi(strY);
			file << y;
			MessageBox(NULL, "Відповідь записано", "Message", MB_OK);
			file.close();
			break;
		}
		case IDC_BUTTON3_CALC:
		{
			int i, j, n, y;
			const int len = 30;
			TCHAR strI[len];
			TCHAR strJ[len];
			TCHAR strN[len];
			TCHAR strY[len];
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT3_I), strI, len);
			i = atoi(strI);
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT3_J), strJ, len);
			j = atoi(strJ);
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT3_N), strN, len);
			n = atoi(strN);

			y = function(i, j, n);
			sprintf_s(strY, "%i", y);

			SetWindowText(GetDlgItem(hDlg, IDC_EDIT3_Y), strY);
			break;
		}
		case IDCANCEL3:
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
			break;
		default:
			return DefWindowProc(hDlg, message, wParam, lParam);
		}
		break;
	}
	}
	return (INT_PTR)FALSE;
}

