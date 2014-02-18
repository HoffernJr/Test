using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hopp
{
    class Levels
    {
        private int[,] level1;
        public int[,] Level1
        {
            get { return level1; }
        }

        private int[,] level2;
        public int[,] Level2
        {
            get { return level2; }
        }

        private int[,] level3;
        public int[,] Level3
        {
            get { return level3; }
        }

        private int[,] level4;
        public int[,] Level4
        {
            get { return level4; }
        }

        private int[,] level5;
        public int[,] Level5
        {
            get { return level5; }
        }

        public Levels() {
            setLevel1();
            setLevel2();
            setLevel3();
            setLevel4();
            setLevel5();
        }
        private void setLevel1() 
        { 
            level1 = new int[,]{
                {0,0,0},
                {4,4,4},
                {0,0,4},
                {4,0,0},
                {0,0,4},
                {3,3,3},
                {0,0,3},
                {0,3,0},
                {3,0,0},
                {0,0,3},
                {2,2,2},
                {2,0,0},
                {0,2,0},
                {0,0,2},
                {1,1,1},
                {0,1,0},
                {0,1,0},
                {0,0,1}};
        }
        private void setLevel2()
        {
            level2 = new int[,]{
                {0,0,0},
                {4,4,4},
                {0,4,0},
                {0,4,0},
                {0,4,0},
                {3,3,3},
                {0,3,0},
                {0,3,0},
                {0,3,0},
                {0,3,0},
                {2,2,2},
                {0,2,0},
                {0,2,0},
                {0,2,0},
                {1,1,1},
                {0,1,0},
                {0,1,0},
                {0,1,0}};
        }
        private void setLevel3()
        {
            level3 = new int[,]{
                {0,0,0},
                {4,4,4},
                {0,0,4},
                {4,0,0},
                {0,0,4},
                {3,3,3},
                {0,0,3},
                {0,3,0},
                {3,0,0},
                {0,0,3},
                {2,2,2},
                {2,0,0},
                {0,2,0},
                {0,0,2},
                {1,1,1},
                {0,1,0},
                {0,1,0},
                {0,0,1}};
        }
        private void setLevel4()
        {
            level4 = new int[,]{
                {0,0,0},
                {4,4,4},
                {0,0,4},
                {4,0,0},
                {0,0,4},
                {3,3,3},
                {0,0,3},
                {0,3,0},
                {3,0,0},
                {0,0,3},
                {2,2,2},
                {2,0,0},
                {0,2,0},
                {0,0,2},
                {1,1,1},
                {0,1,0},
                {0,1,0},
                {0,0,1}};
        }
        private void setLevel5()
        {
            level5 = new int[,]{
                {0,0,0,0,0},
                {1,1,1,1,1},
                {0,0,0,1,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {1,0,0,0,0},
                {0,1,0,0,0},
                {0,0,1,0,0},
                {0,0,0,1,0},
                {0,0,0,0,1},
                {0,0,1,0,0}};
        }
    }
}
