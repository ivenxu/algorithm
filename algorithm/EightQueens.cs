using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm {
    public static class EightQueens {
        private static readonly int[] _rowPositions = new int[] { -1, -1, -1, -1, -1, -1, -1, -1 };
        private static readonly int COUNT = _rowPositions.Length;
        private static int _suc = 0;

        public static void BackTrack() {

            BackTrack(0);
        }

        private static void BackTrack(int queenNum) {
            if (queenNum == COUNT) {
                _suc++;
                Print();
                return;
            }

            for (int i = 0; i < COUNT; i++) {
                _rowPositions[queenNum] = i;

                if (IsBadPosition(queenNum)) {
                    BackTrack(queenNum + 1);
                }
            }
        }

        private static bool IsBadPosition(int queenNum) {
            for (int i = 0; i < queenNum; i++) {
                if (_rowPositions[i] == _rowPositions[queenNum]) return false;

                if (Math.Abs(_rowPositions[queenNum] - _rowPositions[i]) == queenNum - i) return false;
            }
            return true;
        }

        private static void Print() {
            Console.WriteLine("No. {0}:", _suc);
            for (int i = 0; i < COUNT; i++) {
                Console.WriteLine("[{0},{1}]", _rowPositions[i], i);
            }
        }
    }
}
