#include "stdafx.h"
#include "LineAlgorithm.h"
#include "lab1.h"
#include <fstream>
using namespace std;
char* fileValues = "line_values.txt";
char* fileAnswer= "line_answer.txt";

double function(double b, double c)
{
	if (c >= 0 && b >= 0) {
		return ((b*sqrt(c)) / pow(2, b)) - ((c*sqrt(b)) / pow(2, c));
	}
	else
	{
		MessageBox(NULL, "b, c должны быть положительными!", "Ошибка", MB_OK);
		return NULL;
	}
}
INT_PTR CALLBACK LineAlgoWnd(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
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
		case IDC_BUTTON1_READ:
		{
			fstream file;
			file.open(fileValues);
			double b, c;
			const int len = 30;
			TCHAR strB[len];
			TCHAR strC[len];
			file >> b >> c;
			sprintf_s(strB, "%f", b);
			sprintf_s(strC, "%f", c);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT1_B), strB);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT1_C), strC);
			file.close();
			break;
		}
		case IDC_BUTTON1_WRITE:
		{
			fstream file;
			file.open(fileAnswer);
			double y;
			const int len = 30;
			TCHAR strY[len];
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT1_Y), strY, len);
			y = atof(strY);
			file << y;
			MessageBox(NULL, "Відповідь записано", "Message", MB_OK);
			file.close();
			break;
		}
		case IDC_BUTTON1_CALC:
		{
			double b, c, y;
			const int len = 30;
			TCHAR strB[len];
			TCHAR strC[len];
			TCHAR strY[len];
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT1_B), strB, len);
			b = atof(strB);
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT1_C), strC, len);
			c = atof(strC);
			y = function(b, c);
			sprintf_s(strY, "%f", y);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT1_Y), strY);
			break;
		}
		case IDCANCEL1:
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
