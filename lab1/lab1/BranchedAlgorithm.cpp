#include "stdafx.h"
#include "BranchedAlgorithm.h"
#include <fstream>
static char* fileValues = "branched_values.txt";
static char* fileResult = "branched_result.txt";
using namespace std;

double function(double a, double b, double x) {
	if (x > 0) {
		return ((a*pow(x, 3)) - (b*pow(x, 2)));
	}
	else {
		return ((b*pow(x, 3)) + (a*pow(x, 2)));

	}
}

INT_PTR CALLBACK BranchedAlgoWnd(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
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
		case IDC_BUTTON2_READ:
		{
			fstream file;
			file.open(fileValues);
			double a, b, x;
			const int len = 30;
			TCHAR strA[len];
			TCHAR strB[len];
			TCHAR strX[len];
			file >> a >> b >> x;
			sprintf_s(strA, "%f", a);
			sprintf_s(strB, "%f", b);
			sprintf_s(strX, "%f", x);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT2_A), strA);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT2_B), strB);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT2_X), strX);
			file.close();
			break;
		}
		case IDC_BUTTON2_WRITE:
		{
			fstream file;
			file.open(fileResult, ios::trunc);
			double y;
			const int len = 30;
			TCHAR strY[len];
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT2_Y), strY, len);
			y = atof(strY);
			file << y;
			MessageBox(NULL, "Відповідь записано", "Message", MB_OK);
			file.close();
			break;
		}
		case IDC_BUTTON2_CALC:
		{
			double a, b, x, y;
			const int len = 30;
			TCHAR strA[len];
			TCHAR strB[len];
			TCHAR strX[len];
			TCHAR strY[len];
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT2_A), strA, len);
			a = atof(strA);
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT2_B), strB, len);
			b = atof(strB);
			GetWindowText(GetDlgItem(hDlg, IDC_EDIT2_X), strX, len);
			x = atof(strX);
			y = function(a, b, x);
			sprintf_s(strY, "%f", y);
			SetWindowText(GetDlgItem(hDlg, IDC_EDIT2_Y), strY);
			break;
		}
		case IDCANCEL2:
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
