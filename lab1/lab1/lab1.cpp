// lab1.cpp: определяет точку входа для приложения.
//

#include "stdafx.h"
#include "lab1.h"
#include "stdio.h"
#include "Math.h"

#include "LineAlgorithm.h"
#include "BranchedAlgorithm.h"
#include "CycledAlgorithm.h"

#define MAX_LOADSTRING 100

// Глобальные переменные:
HINSTANCE hInst;                                // текущий экземпляр
WCHAR szTitle[MAX_LOADSTRING];                  // Текст строки заголовка
WCHAR szWindowClass[MAX_LOADSTRING];            // имя класса главного окна

// Отправить объявления функций, включенных в этот модуль кода:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);


int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: разместите код здесь.

    // Инициализация глобальных строк
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_LAB1, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Выполнить инициализацию приложения:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_LAB1));

    MSG msg;

    // Цикл основного сообщения:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  ФУНКЦИЯ: MyRegisterClass()
//
//  НАЗНАЧЕНИЕ: регистрирует класс окна.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_LAB1));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_LAB1);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   ФУНКЦИЯ: InitInstance(HINSTANCE, int)
//
//   НАЗНАЧЕНИЕ: сохраняет обработку экземпляра и создает главное окно.
//
//   КОММЕНТАРИИ:
//
//        В данной функции дескриптор экземпляра сохраняется в глобальной переменной, а также
//        создается и выводится на экран главное окно программы.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Сохранить дескриптор экземпляра в глобальной переменной

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
	   400, 160, 590, 450, nullptr, nullptr, hInstance, nullptr);
   HFONT hFont = CreateFont(-16, 0, 0, 0, FW_NORMAL, 0, FALSE,
	   0, DEFAULT_CHARSET, OUT_DEFAULT_PRECIS,
	   CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY,
	   DEFAULT_PITCH | FF_SWISS, TEXT("Corbel"));
   HWND hEdit = CreateWindowEx(WS_EX_CLIENTEDGE, TEXT("edit"), "", WS_CHILD | WS_VISIBLE | ES_MULTILINE | ES_READONLY, 10, 10, 550, 300, hWnd, (HMENU)30000, hInstance, NULL);

   HWND hButLine			= CreateWindow(TEXT("button"), TEXT("Лінійний алгоритм"),	  WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON | BS_CENTER | BS_MULTILINE, 100, 320, 110, 40, hWnd, (HMENU)ID_LINE, hInstance, NULL);
   HWND hButBranched		= CreateWindow(TEXT("button"), TEXT("Розгалужений алгоритм"), WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON | BS_CENTER | BS_MULTILINE, 230, 320, 110, 40, hWnd, (HMENU)ID_BRANCHED, hInstance, NULL);
   HWND hButCycled		= CreateWindow(TEXT("button"), TEXT("Циклічний алгоритм"),	  WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON | BS_CENTER | BS_MULTILINE, 360, 320, 110, 40, hWnd, (HMENU)ID_CYCLED, hInstance, NULL);
   SendMessage(hButLine, WM_SETFONT, (WPARAM)hFont, 0);
   SendMessage(hButBranched, WM_SETFONT, (WPARAM)hFont, 0);
   SendMessage(hButCycled, WM_SETFONT, (WPARAM)hFont, 0);
   SendMessage(hEdit, WM_SETFONT, (WPARAM)hFont, 0);
   SetWindowText(hEdit, "Оберіть алгоритм:\t\t\t\t\t\t1.Лінійний \t\t\t\t\t\t2.Розгалужений \t\t\t\t\t\t3.Циклічний");

  
   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

//
//  ФУНКЦИЯ: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  НАЗНАЧЕНИЕ:  обрабатывает сообщения в главном окне.
//
//  WM_COMMAND — обработать меню приложения
//  WM_PAINT — отрисовать главное окно
//  WM_DESTROY — отправить сообщение о выходе и вернуться
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
			HINSTANCE hInstance = GetModuleHandle(NULL);
            // Разобрать выбор в меню:
            switch (wmId)
            {
			case ID_LINE:
				DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), hWnd, LineAlgoWnd);
				break;
			case ID_BRANCHED:
				DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG2), hWnd, BranchedAlgoWnd);
				break;
			case ID_CYCLED:
				DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG3), hWnd, CycledAlgoWnd);
				break;
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            PAINTSTRUCT ps;
			HDC hDC = BeginPaint(hWnd, &ps);
			EndPaint(hWnd, &ps);
        }
        break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Обработчик сообщений для окна "О программе".
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}


