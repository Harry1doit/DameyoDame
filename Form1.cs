using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        static Bitmap canvas = new Bitmap(480, 320);
        Graphics gg = Graphics.FromImage(canvas);
        int PW, PH;
        Point Cpos; //カーソル座標
        int[] enX = new int[10]; //石の座標
        int[] enY = new int[10];
        Random rand = new Random();
        int RR; //石の半径
        Boolean hitFlg; //true:当たり
        int ecnt, ex, ey; //爆発用演出
        long msgcnt; //　メッセージカウンタ
        Boolean titleFlg; //true:タイトル表示
        long score;  //スコア
        Font myFont = new Font("Arial", 16);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMeteor.Hide();
            pPlayer.Hide();
            pTitle.Hide();
            pBG.Hide();
            pGameover.Hide();
            pExp.Hide();
            pMsg.Hide();

            initGame(); //初期処理
        }

        private void initGame()
        {
            PW = 41; //幅
            PH = 51; //高さ
            RR = 70 / 2; //石の半径
            for (int i = 0; i < 10; i++)
            {
                enX[i] = rand.Next(1, 450); //石の初期配置の座標
                enY[i] = rand.Next(1, 900) - 1000;
            }
            hitFlg = false; //false:はずれ
            ecnt = 40; //爆発の初めの処理で位置変更する
            msgcnt = 0; 
            titleFlg = true;     //true:タイトル表示中
            score = 0;

        }

        private void pBase_Click(object sender, EventArgs e)
        {
            if (titleFlg) //タイトルのみ表示中のみ
            { 
                if (msgcnt > 20)
                {
                    msgcnt = 0;
                    titleFlg = false; 
                }
                return; //タイトル表示中はこの先の処理をしない
            }

            if (msgcnt > 80)
            {
                initGame();
            }
        }

        //爆発演出
        private void playerExplosion()
        {
            ecnt += 4;
            if (ecnt > 40)
            {
                ecnt = 8;
                ex = Cpos.X + rand.Next(40); //爆発の位置を変更
                ey = 220 + rand.Next(50);
            }
            //爆発演出は下記で行う
            gg.DrawImage(pPlayer.Image, new Rectangle(0, 0, 480, 320));
            for (int i = 0; i < 10; i++)
            {
                gg.DrawImage(pMeteor.Image,
                    new Rectangle(enX[i], enY[i], RR * 2, RR * 2));
        }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X, 220, PW, PH));
            gg.DrawImage(pExp.Image, new Rectangle(ex-ecnt/2, ey-ecnt/2, ecnt, ecnt));
            msgcnt++;
            if (msgcnt > 60)
            {
                gg.DrawImage(pGameover.Image, new Rectangle(70, 80, 350, 60));
                if (msgcnt % 60 > 20)
                {
                    gg.DrawImage(pMsg.Image, new Rectangle(110, 190, 271, 26));
                }
            }
            gg.DrawString("SCORE: " + score.ToString(), myFont, Brushes.White, 30, 30);

            pBase.Image = canvas;
        }

        //タイトル表示
        private void dispTitle()
        {
            msgcnt++;
            //タイトル表示中の描写は、全てここで行う
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));
            gg.DrawImage(pTitle.Image, new Rectangle(70, 80, 350, 60));
            if (msgcnt % 60 > 20)
            {
                gg.DrawImage(pMsg.Image, new Rectangle(110, 190, 271, 26));
            }
            pBase.Image = canvas;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (titleFlg)
            {
                dispTitle();
                return; //タイトル表示中はこの先の処理をしない
            }

            if  (hitFlg )
            {
                playerExplosion();
                return; //自機と石が当たったら処理をとめる
            }

            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));

            //石の移動
            for (int i = 0; i < 10; i++)
            {
                enY[i] += 5;
                gg.DrawImage(pMeteor.Image,
                    new Rectangle(enX[i], enY[i], RR * 2,  RR * 2));
                if ( enY[i] > pBase.Height ) //画面外へ出たら上へ戻す
                {
                    enX[i] = rand.Next(1, 450);
                    enY[i] = rand.Next(1, 300) - 400;
                } 
            }
                
            Cpos = PointToClient(Cursor.Position);
            if ( Cpos.X < 0)
            {
                Cpos.X = 0;
            }
            if ( Cpos.X > Width - PW)
            {
                Cpos.X = Width - PW;
            }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X, 220, PW, PH));

            score++;
            gg.DrawString("SCORE: " + score.ToString(), myFont, Brushes.White, 30, 30);

            pBase.Image = canvas;
            hitCheck(); //当たり
        }

        //自機と石の当たり判定
        private void hitCheck()
        {
            int pcx = Cpos.X + (PW / 2); //自機の中心座標
            int pcy = 220 + (PH / 2);
            int ecx, ecy, dis; //自機と距離の計算座標

            for(int i =0; i <10; i++)
            {
                ecx = enX[i] + RR;
                ecy = enY[i] + RR;
                dis = (ecx - pcx) * (ecx - pcx) + (ecy - pcy) * (ecy - pcy);
                if (dis < RR * RR)
                {
                    hitFlg = true;
                    break; //forから抜ける

                }
            }
            
        }
    }
}
