﻿using System;
using System.Text;
using System.Runtime.InteropServices;

namespace WindowTextExtractor
{
    static class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AttachConsole(int processID);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleOutputCP();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleOutputCharacter(IntPtr hConsoleOutput, [Out] char[] lpCharacter, uint nLength, Coord dwReadCoord, out uint lpNumberOfCharsRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, out ConsoleScreenBufferInfo lpConsoleScreenBufferInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(int nStdHandle);
    }
}