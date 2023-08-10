using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicGUI3104
{
    public partial class Form1 : Form
    {
        List<Music> musicList = new List<Music>()
        {
            new Music() {Name="오랜날 오랜밤", Genre="가요", PlayCnt=200000, Singer="AKMU"},
            new Music() {Name="Dangerously", Genre="팝송", PlayCnt=300000, Singer="찰리푸스"},
            new Music() {Name="TomBoy", Genre="댄스", PlayCnt=10000, Singer="(여자)아이들"},
            new Music() {Name="퀸카", Genre="댄스", PlayCnt=10400, Singer="(여자)아이들"},
            new Music() {Name="Tomboy", Genre="가요", PlayCnt=1000, Singer="혁오"},
            new Music() {Name="위잉위잉", Genre="인디", PlayCnt=999, Singer="혁오"},
            new Music() {Name="Hype boy", Genre="댄스", PlayCnt=100000, Singer="뉴진스"},
            new Music() {Name="초코레이디", Genre="가요", PlayCnt=600, Singer="AKMU"},
            new Music() {Name="Hang me up to dry", Genre="팝송", PlayCnt=400, Singer="콜드 워 키즈"},
            new Music() {Name="I AM", Genre="댄스", PlayCnt=40000, Singer="IVE"},
            new Music() {Name="Sports", Genre="팝송", PlayCnt=3000, Singer="Beach Bunny"},
            new Music() {Name="idontwannabeyouanymore", Genre="팝송", PlayCnt=300, Singer="Billi"},
            new Music() {Name="부동의 첫사랑", Genre="가요", PlayCnt=950, Singer="10cm"},
            new Music() {Name="낙하", Genre="가요", PlayCnt=9000, Singer="AKMU"},
            new Music() {Name="째깍째깍째깍", Genre="가요", PlayCnt=900, Singer="AKMU"},
            new Music() {Name="Spicy", Genre="댄스", PlayCnt=900, Singer="aespa"},
            new Music() {Name="Call me maybe", Genre="팝송", PlayCnt=900, Singer="칼리 레이 젭슨"},
            new Music() {Name="전쟁터", Genre="가요", PlayCnt=300, Singer="AKMU"},
            new Music() {Name="mad at disney", Genre="팝송", PlayCnt=9000, Singer="샐럼 일리스"},
            new Music() {Name="물 만난 물고기", Genre="가요", PlayCnt=90000, Singer="AKMU"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = musicList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from Item in musicList
                                            where Item.Singer == "AKMU"
                                            select Item;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from Item in musicList
                                            where Item.Genre == "팝송"
                                            select Item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from Item in musicList
                                            where Item.PlayCnt >= 1000
                                            select Item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from Item in musicList
                                            orderby Item.PlayCnt descending
                                            select Item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = musicList;
        }
    }
}
