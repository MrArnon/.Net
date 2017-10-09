using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace креститки_нолики
{
    class Game
    {
        public bool start;
        public bool pervhod;  //true - первым ходим компьютер
        public bool first;   //false сразу после первого хода игрока
        public int line;   //  для вычеркивания выигрышной комбинации
        public int x;
        public int y;
        public int xfir; //  первый ход игрока
        public int yfir; 
        public int xlast;//последний
        public int ylast;// ход игрока
        public int win;//если 1- выиграл компьютер, 2-пользователь, 3- ничья
        public bool Turn;//true - сейчас ход компьютера, false - ход пользователя
        public int pc;     //  1 - ходит компьютер, 2 первый ходит игрок
        public int n = 3;
        public int[,] Field = new int[3, 3];   //0=пустая клетка, равен 1 - ход компа, 2 - игрок
     
          public Game(){
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Field[i, j] = 0;
                }
               
            }
            start = false;
            pervhod = true;
            first = true;
            line = 0;
            x = -1;
            y = -1;
            xfir = -1;
            yfir = -1;
            xlast = -1;
            ylast = -1;
            win = 0;
            Turn = false;
            pc = 2;
           
        }
        public void Clearing()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Field[i, j] = 0;
                }

            }
            start = false;
            pervhod = true;
            first = true;
            line = 0;
            x = -1;
            y = -1;
            xfir = -1;
            yfir = -1;
            xlast = -1;
            ylast = -1;
            win = 0;
            Turn = false;
            pc = 2;
         

        }

       public void hod1()
        {
            if (Field[1, 1] == 0)
            {
                Field[1, 1] = 1;   //компьютер первым ходом всегда ходит в центр(если есть возможность), независимо от того какими он играет
            }
            /*else
            {
                random();
            }*/
            //paint();
            Turn = false;
            pervhod = false;
        }

        private void random()   //заполняем любую пустую клетку, для компьютера
        {
            bool rand = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rand == false)
                    {
                        if (Field[i, j] == 0)
                        {
                            Field[i, j] = 1;
                            rand = true;
                            Turn = false;
                            //paint();
                        }
                    }
                }
            }
        }
        private void defend()
        {
            // защита
            if ((Field[0, 0] + Field[0, 1] + Field[0, 2]) == 4 && Field[0, 0] != 1 && Field[0, 1] != 1 && Field[0, 2] != 1)   //1-4-7  - защита
            {
                for (int j = 0; j < n; j++)
                {
                    if (Field[0, j] == 0)
                    {
                       Field[0, j] = 1;
                        Turn = false;
                       // paint();
                    }
                }
            }
            else
            {
                if ((Field[1, 0] + Field[1, 1] + Field[1, 2]) == 4 && Field[1, 0] != 1 && Field[1, 1] != 1 && Field[1, 2] != 1)   //2-5-8  - защита
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (Field[1, j] == 0)
                        {
                            Field[1, j] = 1;
                            Turn = false;
                            //paint();
                        }
                    }
                }
                else
                {
                    if ((Field[2, 0] + Field[2, 1] + Field[2, 2]) == 4 && Field[2, 0] != 1 && Field[2, 1] != 1 && Field[2, 2] != 1)   //3-6-9  - защита
                    {
                        for (int j = 0; j <n; j++)
                        {
                            if (Field[2, j] == 0)
                            {
                                Field[2, j] = 1;
                               Turn = false;
                                //paint();

                            }
                        }
                    }
                    else
                    {
                        if ((Field[0, 0] + Field[1, 0] +Field[2, 0]) == 4 && Field[0, 0] != 1 && Field[1, 0] != 1 && Field[2, 0] != 1)   //1-2-3  - защита
                        {
                            for (int i = 0; i < n; i++)
                            {
                                if (Field[i, 0] == 0)
                                {
                                   Field[i, 0] = 1;
                                    Turn = false;
                                   // paint();
                                }
                            }
                        }
                        else
                        {
                            if ((Field[0, 1] + Field[1, 1] + Field[2, 1]) == 4 && Field[0, 1] != 1 && Field[1, 1] != 1 && Field[2, 1] != 1)   //4-5-6  - защита
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    if (Field[i, 1] == 0)
                                    {
                                        Field[i, 1] = 1;
                                        Turn = false;
                                       // paint();
                                    }
                                }
                            }
                            else
                            {
                                if ((Field[0, 2] + Field[1, 2] + Field[2, 2]) == 4 && Field[0, 2] != 1 && Field[1, 2] != 1 && Field[2, 2] != 1)   //7-8-9  - защита
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        if (Field[i, 2] == 0)
                                        {
                                           Field[i, 2] = 1;
                                           Turn = false;
                                           // paint();
                                        }
                                    }
                                }
                                else
                                {
                                    if ((Field[0, 0] + Field[1, 1] + Field[2, 2]) == 4 && Field[0, 0] != 1 && Field[1, 1] != 1 && Field[2, 2] != 1)   //1-5-9  - защита
                                    {
                                        if (Field[0, 0] == 0)
                                            Field[0, 0] = 1;
                                        if (Field[1, 1] == 0)
                                            Field[1, 1] = 1;
                                        if (Field[2, 2] == 0)
                                            Field[2, 2] = 1;
                                       Turn = false;
                                        //paint();
                                    }
                                    else
                                    {
                                        if ((Field[2, 0] + Field[1, 1] + Field[0, 2]) == 4 && Field[2, 0] != 1 && Field[1, 1] != 1 && Field[0, 2] != 1)   //3-5-7  - защита
                                        {
                                            if (Field[2, 0] == 0)
                                                Field[2, 0] = 1;
                                            if (Field[1, 1] == 0)
                                                Field[1, 1] = 1;
                                            if (Field[0, 2] == 0)
                                                Field[0, 2] = 1;
                                            Turn = false;
                                            //paint();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }       //конец защиты по 2 правилу
        }
        private void winning()
        {
            //НАЧИНАЕТСЯ НАПАДЕНИЕ(ПОПЫТКА ВЫИГРАТЬ, ЕСЛИ ЕСТЬ ВОЗМОЖНОСТЬ)
            if (((Field[0, 0] + Field[0, 1] + Field[0, 2]) == 2) && (Field[0, 0] == 1 || Field[0, 1] == 1 || Field[0, 2] == 1))  //1-4-7  - нападение
            {
                for (int j = 0; j < n; j++)
                {
                    if (Field[0, j] == 0)
                    {
                        Field[0, j] = 1;
                    }
                }
                win = 1;
                //paint();
                line = 4;
            }
            else
            {
                if (((Field[1, 0] + Field[1, 1] + Field[1, 2]) == 2) && (Field[1, 0] == 1 || Field[1, 1] == 1 || Field[1, 2] == 1))   //2-5-8  - нападение
                {

                    for (int j = 0; j < n; j++)
                    {
                        if (Field[1, j] == 0)
                        {
                            Field[1, j] = 1;
                        }
                    }
                    win = 1;
                    //paint();
                    line = 5;
                }
                else
                {
                    if (((Field[2, 0] + Field[2, 1] + Field[2, 2]) == 2) && (Field[2, 0] == 1 || Field[2, 1] == 1 || Field[2, 2] == 1))   //3-6-9  - нападение
                    {

                        for (int j = 0; j < n; j++)
                        {
                            if (Field[2, j] == 0)
                            {
                                Field[2, j] = 1;
                            }
                        }
                        win = 1;
                        //paint();
                        line = 6;
                    }
                    else
                    {
                        if (((Field[0, 0] + Field[1, 0] + Field[2, 0]) == 2) && (Field[0, 0] == 1 || Field[1, 0] == 1 || Field[2, 0] == 1))   //1-2-3  -нападение
                        {

                            for (int i = 0; i < n; i++)
                            {
                                if (Field[i, 0] == 0)
                                {
                                    Field[i, 0] = 1;
                                }
                            }
                            win = 1;
                            //paint();
                            line = 1;
                        }
                        else
                        {
                            if (((Field[0, 1] + Field[1, 1] + Field[2, 1]) == 2) && (Field[0, 1] == 1 || Field[1, 1] == 1 || Field[2, 1] == 1))  //4-5-6  - нападение
                            {

                                for (int i = 0; i < n; i++)
                                {
                                    if (Field[i, 1] == 0)
                                    {
                                        Field[i, 1] = 1;
                                    }
                                }
                                win = 1;
                                //paint();
                                line = 2;
                            }
                            else
                            {
                                if (((Field[0, 2] + Field[1, 2] + Field[2, 2]) == 2) && (Field[0, 2] == 1 || Field[1, 2] == 1 || Field[2, 2] == 1))   //7-8-9  - нападение
                                {

                                    for (int i = 0; i < n; i++)
                                    {
                                        if (Field[i, 2] == 0)
                                        {
                                            Field[i, 2] = 1;
                                        }
                                    }
                                    win = 1;
                                    //paint();
                                    line = 3;
                                }
                                else
                                {
                                    if (((Field[0, 0] + Field[1, 1] + Field[2, 2]) == 2) && (Field[0, 0] == 1 || Field[1, 1] == 1 || Field[2, 2] == 1))   //1-5-9  - нападение
                                    {
                                        if (Field[0, 0] == 0)
                                            Field[0, 0] = 1;
                                        if (Field[1, 1] == 0)
                                            Field[1, 1] = 1;
                                        if (Field[2, 2] == 0)
                                            Field[2, 2] = 1;
                                        win = 1;
                                        //paint();
                                        line = 7;

                                    }
                                    else
                                    {
                                        if (((Field[2, 0] + Field[1, 1] + Field[0, 2]) == 2) && (Field[2, 0] == 1 || Field[1, 1] == 1 || Field[0, 2] == 1))   //3-5-7  - нападение
                                        {
                                            if (Field[2, 0] == 0)
                                                Field[2, 0] = 1;
                                            if (Field[1, 1] == 0)
                                                Field[1, 1] = 1;
                                            if (Field[0, 2] == 0)
                                                Field[0, 2] = 1;
                                            win = 1;
                                            //paint();
                                            line = 8;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void diagonal()   //противоположный ход
        {
            if (xlast == 0 && ylast == 0)  //если 0,0
            {
                if (Field[2, 2] == 0)
                {
                    Field[2, 2] = 1;
                    Turn = false;
                    //paint();
                }
                else
                {
                    random();
                }
            }
            else
            {
                if (xlast == 2 && ylast == 0)   //2.0
                {
                    if (Field[0, 2] == 0)
                    {
                        Field[0, 2] = 1;
                        Turn = false;
                       // paint();
                    }
                    else
                    {
                        random();
                    }
                }
                else
                {
                    if (xlast == 0 && ylast == 2)   //0.2
                    {
                        if (Field[2, 0] == 0)
                        {
                            Field[2, 0] = 1;
                            Turn = false;
                           // paint();
                        }
                        else
                        {
                            random();
                        }
                    }
                    else
                    {
                        if (xlast == 2 && ylast == 2)   //2.2
                        {
                            if (Field[0, 0] == 0)
                            {
                                Field[0, 0] = 1;
                                Turn = false;
                                //paint();
                            }
                            else
                            {
                                random();
                            }
                        }
                        else
                        {
                            if (xlast == 0 && ylast == 1)   //0.1
                            {
                                if (Field[2, 0] == 0)
                                {
                                    Field[2, 0] = 1;
                                    Turn = false;
                                   // paint();
                                }
                                else
                                {
                                    if (Field[2, 2] == 0)
                                    {
                                        Field[2, 2] = 1;
                                        Turn = false;
                                        //paint();
                                    }
                                    else
                                    {
                                        random();
                                    }
                                }
                            }
                            else
                            {
                                if (xlast == 1 && ylast == 0)   //1.0
                                {
                                    if (Field[0, 2] == 0)
                                    {
                                        Field[0, 2] = 1;
                                        Turn = false;
                                       // paint();
                                    }
                                    else
                                    {
                                        if (Field[2, 2] == 0)
                                        {
                                            Field[2, 2] = 1;
                                            Turn = false;
                                            //paint();
                                        }
                                        else
                                        {
                                            random();
                                        }
                                    }
                                }
                                else
                                {
                                    if (xlast == 2 && ylast == 1)   //2.1
                                    {
                                        if (Field[0, 0] == 0)
                                        {
                                            Field[0, 0] = 1;
                                            Turn = false;
                                           // paint();
                                        }
                                        else
                                        {
                                            if (Field[0, 2] == 0)
                                            {
                                                Field[0, 2] = 1;
                                                Turn = false;
                                               // paint();
                                            }
                                            else
                                            {
                                                random();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (xlast == 1 && ylast == 2)   //1.2
                                        {
                                            if (Field[0, 0] == 0)
                                            {
                                                Field[0, 0] = 1;
                                                Turn = false;
                                                //paint();
                                            }
                                            else
                                            {
                                                if (Field[2, 0] == 0)
                                                {
                                                    Field[2, 0] = 1;
                                                    Turn = false;
                                                   // paint();
                                                }
                                                else
                                                {
                                                    random();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void nobody()
        {
            bool nich = true;   //если true - то ничья
            for (int i = 0; i < n; i++)   //если находим 0, то получим false, то есть не ничья, можно еще ходить
            {
                for (int j = 0; j < 3; j++)
                {
                    if (nich)
                    {
                        if (Field[i, j] == 0)
                        {
                            nich = false;
                        }
                    }
                }
            }
            if (nich)
            {
                //messebox
                win = 3;

            }
        }

        private void angle()
        {
            if (Field[0, 0] == 0)
            {
                Field[0, 0] = 1;
                Turn = false;
                //paint();
            }
            else
            {
                if (Field[2, 0] == 0)
                {
                    Field[2, 0] = 1;
                    Turn = false;
                   // paint();
                }
                else
                {
                    if (Field[0, 2] == 0)
                    {
                        Field[0, 2] = 1;
                        Turn = false;
                       // paint();
                    }
                    else
                    {
                        if (Field[2, 2] == 0)
                        {
                            Field[2, 2] = 1;
                            Turn = false;
                            //paint();
                        }
                        else
                        {
                            attack();
                        }
                    }
                }
            }
        }

        private void attack()
        {
            if ((Field[0, 0] + Field[0, 1] + Field[0, 2]) == 1)  //1-4-7  - нападение
            {
                for (int j = 0; j < n; j++)
                {
                    if (Field[0, j] == 0)
                    {
                        Field[0, j] = 1;
                    }
                }
               // paint();
            }
            else
            {
                if ((Field[1, 0] + Field[1, 1] + Field[1, 2]) == 1)   //2-5-8  - нападение
                {

                    for (int j = 0; j < n; j++)
                    {
                        if (Field[1, j] == 0)
                        {
                            Field[1, j] = 1;
                        }
                    }
                    //paint();
                }
                else
                {
                    if ((Field[2, 0] + Field[2, 1] + Field[2, 2]) == 1)   //3-6-9  - нападение
                    {

                        for (int j = 0; j < n; j++)
                        {
                            if (Field[2, j] == 0)
                            {
                                Field[2, j] = 1;
                            }
                        }
                        //paint();
                    }
                    else
                    {
                        if ((Field[0, 0] + Field[1, 0] + Field[2, 0]) == 1)   //1-2-3  -нападение
                        {

                            for (int i = 0; i < n; i++)
                            {
                                if (Field[i, 0] == 0)
                                {
                                    Field[i, 0] = 1;
                                }
                            }
                            //paint();
                        }
                        else
                        {
                            if ((Field[0, 1] + Field[1, 1] + Field[2, 1]) == 1)  //4-5-6  - нападение
                            {

                                for (int i = 0; i < n; i++)
                                {
                                    if (Field[i, 1] == 0)
                                    {
                                        Field[i, 1] = 1;
                                    }
                                }
                                //paint();
                            }
                            else
                            {
                                if ((Field[0, 2] + Field[1, 2] + Field[2, 2]) == 1)   //7-8-9  - нападение
                                {

                                    for (int i = 0; i < n; i++)
                                    {
                                        if (Field[i, 2] == 0)
                                        {
                                            Field[i, 2] = 1;
                                        }
                                    }
                                   // paint();
                                }
                                else
                                {
                                    if ((Field[0, 0] + Field[1, 1] + Field[2, 2]) == 1)   //1-5-9  - нападение
                                    {
                                        if (Field[0, 0] == 0)
                                        {
                                            Field[0, 0] = 1;
                                        }
                                        else
                                        {
                                            if (Field[1, 1] == 0)
                                            {
                                                Field[1, 1] = 1;
                                            }
                                            else
                                            {
                                                if (Field[2, 2] == 0)
                                                    Field[2, 2] = 1;
                                            }
                                        }
                                       // paint();
                                    }
                                    else
                                    {
                                        if ((Field[2, 0] + Field[1, 1] + Field[0, 2]) == 1)   //3-5-7  - нападение
                                        {
                                            if (Field[2, 0] == 0)
                                            {
                                                Field[2, 0] = 1;
                                            }
                                            else
                                            {
                                                if (Field[1, 1] == 0)
                                                {
                                                    Field[1, 1] = 1;
                                                }
                                                else
                                                {
                                                    if (Field[0, 2] == 0)
                                                    {
                                                        Field[0, 2] = 1;
                                                    }
                                                }
                                            }
                                            //paint();
                                        }
                                        else
                                        {
                                            random();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }  //нападение 
        public void hod()
        {
            if (Turn)
            {
                nobody();    //есть ли свободное поле
                winning();    //1 правило
                if (win == 0)
                {
                    defend();  //2 правило
                    if (Turn)   //если 1,2 правила невыполнены, то есть до сих пор ход компа, он должен сделать либо противоположный
                    {                              // либо любой ход
                        if (pc == 1)    //если первый сходил комп, значит по тактике нужно ходить точно противоположно ходу юзера
                        {
                            diagonal();//ход противоположный
                        }
                        else  //комп ходит вторым
                        {
                            if (xfir == 1 && yfir == 1)   //ходят в центр - ходим в углы
                            {
                                angle();
                            }
                            else   //если ходят не в центр
                            {
                                if (pervhod)
                                {
                                    hod1();   //ходим в центр
                                    pervhod = false;
                                }
                                else
                                {
                                    angle();
                                }
                            }
                        }
                    }    //конец противоположного хода
                }
                nobody();


            }
            // else winner();
        }   // ход компьютера, когда он ходит первый

        public bool check_player()
        {

            if ((Field[0, 0] + Field[0, 1] + Field[0, 2]) == 6)   //1-4-7  - защита
            {
                win = 2;
                line = 4;
                return true;
                //45612378
            }
            else
            {
                if ((Field[1, 0] + Field[1, 1] + Field[1, 2]) == 6)   //2-5-8  - защита
                {
                    win = 2;
                    line = 5;
                    return true;
                }
                else
                {
                    if ((Field[2, 0] + Field[2, 1] + Field[2, 2]) == 6)   //3-6-9  - защита
                    {
                        win = 2;
                        line = 6;
                        return true;
                    }
                    else
                    {
                        if ((Field[0, 0] + Field[1, 0] + Field[2, 0]) == 6)   //1-2-3  - защита
                        {
                            win = 2;
                            line = 1;
                            return true;
                        }
                        else
                        {
                            if ((Field[0, 1] + Field[1, 1] + Field[2, 1]) == 6)   //4-5-6  - защита
                            {
                                win = 2;
                                line = 2;
                                return true;
                            }
                            else
                            {
                                if ((Field[0, 2] + Field[1, 2] + Field[2, 2]) == 6)   //7-8-9  - защита
                                {
                                    win = 2;
                                    line = 3;
                                    return true;
                                }
                                else
                                {
                                    if ((Field[0, 0] + Field[1, 1] + Field[2, 2]) == 6)   //1-5-9  - защита
                                    {
                                        win = 2;
                                        line = 7;
                                        return true;
                                    }
                                    else
                                    {
                                        if ((Field[2, 0] + Field[1, 1] + Field[0, 2]) == 6)   //3-5-7  - защита
                                        {
                                            win = 2;
                                            line = 8;
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //if (win == 2) winner();
            return false;
        }
    }
}

