using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace sootingGame_test
{

    //미사일 클래스
    public class MISSILE
    {
        public int x;
        public int y;
        public bool fire;
    }

    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;
        public int playerY;
        public MISSILE[] playerMissile = new MISSILE[20];

        public Player() //생성자
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) //미사일 초기화
            {
                playerMissile[i] = new MISSILE();
                playerMissile[i].x = 0;
                playerMissile[i].y = 0;
                playerMissile[i].fire = false;
            }
        }


        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이어를 그려준다
            PlayerDraw();
        }

        public void KeyControl()
        {
            int pressKey;   //정수형 변수선언 키 값 받음

            if (Console.KeyAvailable)    //키가 눌렸을 때 true
            {
                pressKey = _getch();    //아스키 값 왼쪽 오른쪽

                switch (pressKey)
                {
                    case 72:    //위쪽방향 아스키코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 80:    //아래방향 아스키코드
                        playerY++;
                        if (playerY < 21)
                            playerY = 21;
                        break;
                    case 75:    //왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:    //오른쪽 화살표키
                        playerX++;
                        if (playerX < 75)
                            playerX = 75;
                        break;
                    case 32:
                        //스페이스바, 미사일 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사기능
                            if (playerMissile[i].fire == false)
                            {
                                playerMissile[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5
                                playerMissile[i].x = playerX + 5;
                                playerMissile[i].y = playerY;
                                //한발씩 발사
                                break;
                            }
                        }
                        break;

                }
            }
        }

        //미사일 그리기
        public void MissileDraw()
        {
            string missile = "->";  //미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 유효한 상태
                if (playerMissile[i].fire == true)
                {
                    //좌표설정 -> 중간 위치를 위해 보정 x-1
                    Console.SetCursorPosition(playerMissile[i].x - 1, playerMissile[i].y);
                    //미사일 출력
                    Console.Write(missile);

                    playerMissile[i].x++;   //미사일 오른쪽으로 날리기
                    if (playerMissile[i].x > 78)
                    {
                        playerMissile[i].fire = false;  //미사일 false 재준비 상태
                    }
                }
            }

        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔 좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }

        }

        class Program
        {



            static void Main(string[] args)
            {
                Console.CursorVisible = false;
                Console.SetWindowSize(80, 25);
                Console.SetBufferSize(80, 25);

                //플레이어 생성
                Player player = new Player();

                //적생성

                //유니티처럼 속도 프레임속도
                int dwTime = Environment.TickCount; // 1/1000초가 흐른다

                while (true)
                {
                    //0.05초 지연
                    if (dwTime + 50 < Environment.TickCount)
                    {
                        //현재시간 세팅
                        dwTime = Environment.TickCount;
                        Console.Clear();

                        //플레이어
                        player.GameMain();

                        //미사일
                        player.MissileDraw();

                    }

                }

            }
        }
    }
}
