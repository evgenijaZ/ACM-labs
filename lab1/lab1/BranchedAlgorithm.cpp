#include "stdafx.h"
#include "BranchedAlgorithm.h"
#include "lab1.h"


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
