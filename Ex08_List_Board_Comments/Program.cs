using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_List_Board_Comments
{
    class Program
    {
        /*
         App ---- DataBase
            (CRUD)
        1.select
        2. insert
        3. update
        4. delete

        create table Board(boardid int ...)
        create table comments(commentid int ...)

        APP : select voardid, title, content from board;

        class Board {
            private int boardid;
        }

        case 1
            select boardid, title from board where boardid =2;
            
            Board board = new Board();
            board.Boardid = 데이터
        case 2
            select boardid, title from board 데이터 건수 150건
            Lsit<Board> boardlist =new ...
            boardlist.add(new Board());
            ...

            boardlist 안에 Board 객체 150개
         
         
         */
        static void Main(string[] args)
        {
        }
    }
}
