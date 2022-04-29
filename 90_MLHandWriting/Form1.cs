using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _90_MLHandWriting.MLModel;

namespace _90_MLHandWriting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Bitmap sourceImage = pb_img.Image as Bitmap;
            int width = 20;   //사이즈 200 * 200 으로 고정함. 
            int height = 20; 
            Size resize = new Size(width, height);
            Bitmap resizeImage = new Bitmap(sourceImage, resize);
            pb_small.Image = resizeImage;
            float[] fvalues = new float[400];
            for(int i =0;i<20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (IsBlack(resizeImage.GetPixel(j, i)))
                    {
                        fvalues[i * 20 + j] = 0f;
                    }
                    else
                    {
                        fvalues[i * 20 + j] = 1f;
                    }
                }
            }

            ResetPictureBox();
            var input = Convert(fvalues);
            ModelOutput result = MLModel.Predict(input);
            lb_no.Text = result.PredictedLabel.ToString();
            
        }

        ModelInput Convert(float[] fvalue)
        {
            int c = 0;
            return new ModelInput()
            {
                Col0 = fvalue[c++],
                Col1 = fvalue[c++],
                Col2 = fvalue[c++],
                Col3 = fvalue[c++],
                Col4 = fvalue[c++],
                Col5 = fvalue[c++],
                Col6 = fvalue[c++],
                Col7 = fvalue[c++],
                Col8 = fvalue[c++],
                Col9 = fvalue[c++],
                Col10 = fvalue[c++],
                Col11 = fvalue[c++],
                Col12 = fvalue[c++],
                Col13 = fvalue[c++],
                Col14 = fvalue[c++],
                Col15 = fvalue[c++],
                Col16 = fvalue[c++],
                Col17 = fvalue[c++],
                Col18 = fvalue[c++],
                Col19 = fvalue[c++],
                Col20 = fvalue[c++],
                Col21 = fvalue[c++],
                Col22 = fvalue[c++],
                Col23 = fvalue[c++],
                Col24 = fvalue[c++],
                Col25 = fvalue[c++],
                Col26 = fvalue[c++],
                Col27 = fvalue[c++],
                Col28 = fvalue[c++],
                Col29 = fvalue[c++],
                Col30 = fvalue[c++],
                Col31 = fvalue[c++],
                Col32 = fvalue[c++],
                Col33 = fvalue[c++],
                Col34 = fvalue[c++],
                Col35 = fvalue[c++],
                Col36 = fvalue[c++],
                Col37 = fvalue[c++],
                Col38 = fvalue[c++],
                Col39 = fvalue[c++],
                Col40 = fvalue[c++],
                Col41 = fvalue[c++],
                Col42 = fvalue[c++],
                Col43 = fvalue[c++],
                Col44 = fvalue[c++],
                Col45 = fvalue[c++],
                Col46 = fvalue[c++],
                Col47 = fvalue[c++],
                Col48 = fvalue[c++],
                Col49 = fvalue[c++],
                Col50 = fvalue[c++],
                Col51 = fvalue[c++],
                Col52 = fvalue[c++],
                Col53 = fvalue[c++],
                Col54 = fvalue[c++],
                Col55 = fvalue[c++],
                Col56 = fvalue[c++],
                Col57 = fvalue[c++],
                Col58 = fvalue[c++],
                Col59 = fvalue[c++],
                Col60 = fvalue[c++],
                Col61 = fvalue[c++],
                Col62 = fvalue[c++],
                Col63 = fvalue[c++],
                Col64 = fvalue[c++],
                Col65 = fvalue[c++],
                Col66 = fvalue[c++],
                Col67 = fvalue[c++],
                Col68 = fvalue[c++],
                Col69 = fvalue[c++],
                Col70 = fvalue[c++],
                Col71 = fvalue[c++],
                Col72 = fvalue[c++],
                Col73 = fvalue[c++],
                Col74 = fvalue[c++],
                Col75 = fvalue[c++],
                Col76 = fvalue[c++],
                Col77 = fvalue[c++],
                Col78 = fvalue[c++],
                Col79 = fvalue[c++],
                Col80 = fvalue[c++],
                Col81 = fvalue[c++],
                Col82 = fvalue[c++],
                Col83 = fvalue[c++],
                Col84 = fvalue[c++],
                Col85 = fvalue[c++],
                Col86 = fvalue[c++],
                Col87 = fvalue[c++],
                Col88 = fvalue[c++],
                Col89 = fvalue[c++],
                Col90 = fvalue[c++],
                Col91 = fvalue[c++],
                Col92 = fvalue[c++],
                Col93 = fvalue[c++],
                Col94 = fvalue[c++],
                Col95 = fvalue[c++],
                Col96 = fvalue[c++],
                Col97 = fvalue[c++],
                Col98 = fvalue[c++],
                Col99 = fvalue[c++],
                Col100 = fvalue[c++],
                Col101 = fvalue[c++],
                Col102 = fvalue[c++],
                Col103 = fvalue[c++],
                Col104 = fvalue[c++],
                Col105 = fvalue[c++],
                Col106 = fvalue[c++],
                Col107 = fvalue[c++],
                Col108 = fvalue[c++],
                Col109 = fvalue[c++],
                Col110 = fvalue[c++],
                Col111 = fvalue[c++],
                Col112 = fvalue[c++],
                Col113 = fvalue[c++],
                Col114 = fvalue[c++],
                Col115 = fvalue[c++],
                Col116 = fvalue[c++],
                Col117 = fvalue[c++],
                Col118 = fvalue[c++],
                Col119 = fvalue[c++],
                Col120 = fvalue[c++],
                Col121 = fvalue[c++],
                Col122 = fvalue[c++],
                Col123 = fvalue[c++],
                Col124 = fvalue[c++],
                Col125 = fvalue[c++],
                Col126 = fvalue[c++],
                Col127 = fvalue[c++],
                Col128 = fvalue[c++],
                Col129 = fvalue[c++],
                Col130 = fvalue[c++],
                Col131 = fvalue[c++],
                Col132 = fvalue[c++],
                Col133 = fvalue[c++],
                Col134 = fvalue[c++],
                Col135 = fvalue[c++],
                Col136 = fvalue[c++],
                Col137 = fvalue[c++],
                Col138 = fvalue[c++],
                Col139 = fvalue[c++],
                Col140 = fvalue[c++],
                Col141 = fvalue[c++],
                Col142 = fvalue[c++],
                Col143 = fvalue[c++],
                Col144 = fvalue[c++],
                Col145 = fvalue[c++],
                Col146 = fvalue[c++],
                Col147 = fvalue[c++],
                Col148 = fvalue[c++],
                Col149 = fvalue[c++],
                Col150 = fvalue[c++],
                Col151 = fvalue[c++],
                Col152 = fvalue[c++],
                Col153 = fvalue[c++],
                Col154 = fvalue[c++],
                Col155 = fvalue[c++],
                Col156 = fvalue[c++],
                Col157 = fvalue[c++],
                Col158 = fvalue[c++],
                Col159 = fvalue[c++],
                Col160 = fvalue[c++],
                Col161 = fvalue[c++],
                Col162 = fvalue[c++],
                Col163 = fvalue[c++],
                Col164 = fvalue[c++],
                Col165 = fvalue[c++],
                Col166 = fvalue[c++],
                Col167 = fvalue[c++],
                Col168 = fvalue[c++],
                Col169 = fvalue[c++],
                Col170 = fvalue[c++],
                Col171 = fvalue[c++],
                Col172 = fvalue[c++],
                Col173 = fvalue[c++],
                Col174 = fvalue[c++],
                Col175 = fvalue[c++],
                Col176 = fvalue[c++],
                Col177 = fvalue[c++],
                Col178 = fvalue[c++],
                Col179 = fvalue[c++],
                Col180 = fvalue[c++],
                Col181 = fvalue[c++],
                Col182 = fvalue[c++],
                Col183 = fvalue[c++],
                Col184 = fvalue[c++],
                Col185 = fvalue[c++],
                Col186 = fvalue[c++],
                Col187 = fvalue[c++],
                Col188 = fvalue[c++],
                Col189 = fvalue[c++],
                Col190 = fvalue[c++],
                Col191 = fvalue[c++],
                Col192 = fvalue[c++],
                Col193 = fvalue[c++],
                Col194 = fvalue[c++],
                Col195 = fvalue[c++],
                Col196 = fvalue[c++],
                Col197 = fvalue[c++],
                Col198 = fvalue[c++],
                Col199 = fvalue[c++],
                Col200 = fvalue[c++],
                Col201 = fvalue[c++],
                Col202 = fvalue[c++],
                Col203 = fvalue[c++],
                Col204 = fvalue[c++],
                Col205 = fvalue[c++],
                Col206 = fvalue[c++],
                Col207 = fvalue[c++],
                Col208 = fvalue[c++],
                Col209 = fvalue[c++],
                Col210 = fvalue[c++],
                Col211 = fvalue[c++],
                Col212 = fvalue[c++],
                Col213 = fvalue[c++],
                Col214 = fvalue[c++],
                Col215 = fvalue[c++],
                Col216 = fvalue[c++],
                Col217 = fvalue[c++],
                Col218 = fvalue[c++],
                Col219 = fvalue[c++],
                Col220 = fvalue[c++],
                Col221 = fvalue[c++],
                Col222 = fvalue[c++],
                Col223 = fvalue[c++],
                Col224 = fvalue[c++],
                Col225 = fvalue[c++],
                Col226 = fvalue[c++],
                Col227 = fvalue[c++],
                Col228 = fvalue[c++],
                Col229 = fvalue[c++],
                Col230 = fvalue[c++],
                Col231 = fvalue[c++],
                Col232 = fvalue[c++],
                Col233 = fvalue[c++],
                Col234 = fvalue[c++],
                Col235 = fvalue[c++],
                Col236 = fvalue[c++],
                Col237 = fvalue[c++],
                Col238 = fvalue[c++],
                Col239 = fvalue[c++],
                Col240 = fvalue[c++],
                Col241 = fvalue[c++],
                Col242 = fvalue[c++],
                Col243 = fvalue[c++],
                Col244 = fvalue[c++],
                Col245 = fvalue[c++],
                Col246 = fvalue[c++],
                Col247 = fvalue[c++],
                Col248 = fvalue[c++],
                Col249 = fvalue[c++],
                Col250 = fvalue[c++],
                Col251 = fvalue[c++],
                Col252 = fvalue[c++],
                Col253 = fvalue[c++],
                Col254 = fvalue[c++],
                Col255 = fvalue[c++],
                Col256 = fvalue[c++],
                Col257 = fvalue[c++],
                Col258 = fvalue[c++],
                Col259 = fvalue[c++],
                Col260 = fvalue[c++],
                Col261 = fvalue[c++],
                Col262 = fvalue[c++],
                Col263 = fvalue[c++],
                Col264 = fvalue[c++],
                Col265 = fvalue[c++],
                Col266 = fvalue[c++],
                Col267 = fvalue[c++],
                Col268 = fvalue[c++],
                Col269 = fvalue[c++],
                Col270 = fvalue[c++],
                Col271 = fvalue[c++],
                Col272 = fvalue[c++],
                Col273 = fvalue[c++],
                Col274 = fvalue[c++],
                Col275 = fvalue[c++],
                Col276 = fvalue[c++],
                Col277 = fvalue[c++],
                Col278 = fvalue[c++],
                Col279 = fvalue[c++],
                Col280 = fvalue[c++],
                Col281 = fvalue[c++],
                Col282 = fvalue[c++],
                Col283 = fvalue[c++],
                Col284 = fvalue[c++],
                Col285 = fvalue[c++],
                Col286 = fvalue[c++],
                Col287 = fvalue[c++],
                Col288 = fvalue[c++],
                Col289 = fvalue[c++],
                Col290 = fvalue[c++],
                Col291 = fvalue[c++],
                Col292 = fvalue[c++],
                Col293 = fvalue[c++],
                Col294 = fvalue[c++],
                Col295 = fvalue[c++],
                Col296 = fvalue[c++],
                Col297 = fvalue[c++],
                Col298 = fvalue[c++],
                Col299 = fvalue[c++],
                Col300 = fvalue[c++],
                Col301 = fvalue[c++],
                Col302 = fvalue[c++],
                Col303 = fvalue[c++],
                Col304 = fvalue[c++],
                Col305 = fvalue[c++],
                Col306 = fvalue[c++],
                Col307 = fvalue[c++],
                Col308 = fvalue[c++],
                Col309 = fvalue[c++],
                Col310 = fvalue[c++],
                Col311 = fvalue[c++],
                Col312 = fvalue[c++],
                Col313 = fvalue[c++],
                Col314 = fvalue[c++],
                Col315 = fvalue[c++],
                Col316 = fvalue[c++],
                Col317 = fvalue[c++],
                Col318 = fvalue[c++],
                Col319 = fvalue[c++],
                Col320 = fvalue[c++],
                Col321 = fvalue[c++],
                Col322 = fvalue[c++],
                Col323 = fvalue[c++],
                Col324 = fvalue[c++],
                Col325 = fvalue[c++],
                Col326 = fvalue[c++],
                Col327 = fvalue[c++],
                Col328 = fvalue[c++],
                Col329 = fvalue[c++],
                Col330 = fvalue[c++],
                Col331 = fvalue[c++],
                Col332 = fvalue[c++],
                Col333 = fvalue[c++],
                Col334 = fvalue[c++],
                Col335 = fvalue[c++],
                Col336 = fvalue[c++],
                Col337 = fvalue[c++],
                Col338 = fvalue[c++],
                Col339 = fvalue[c++],
                Col340 = fvalue[c++],
                Col341 = fvalue[c++],
                Col342 = fvalue[c++],
                Col343 = fvalue[c++],
                Col344 = fvalue[c++],
                Col345 = fvalue[c++],
                Col346 = fvalue[c++],
                Col347 = fvalue[c++],
                Col348 = fvalue[c++],
                Col349 = fvalue[c++],
                Col350 = fvalue[c++],
                Col351 = fvalue[c++],
                Col352 = fvalue[c++],
                Col353 = fvalue[c++],
                Col354 = fvalue[c++],
                Col355 = fvalue[c++],
                Col356 = fvalue[c++],
                Col357 = fvalue[c++],
                Col358 = fvalue[c++],
                Col359 = fvalue[c++],
                Col360 = fvalue[c++],
                Col361 = fvalue[c++],
                Col362 = fvalue[c++],
                Col363 = fvalue[c++],
                Col364 = fvalue[c++],
                Col365 = fvalue[c++],
                Col366 = fvalue[c++],
                Col367 = fvalue[c++],
                Col368 = fvalue[c++],
                Col369 = fvalue[c++],
                Col370 = fvalue[c++],
                Col371 = fvalue[c++],
                Col372 = fvalue[c++],
                Col373 = fvalue[c++],
                Col374 = fvalue[c++],
                Col375 = fvalue[c++],
                Col376 = fvalue[c++],
                Col377 = fvalue[c++],
                Col378 = fvalue[c++],
                Col379 = fvalue[c++],
                Col380 = fvalue[c++],
                Col381 = fvalue[c++],
                Col382 = fvalue[c++],
                Col383 = fvalue[c++],
                Col384 = fvalue[c++],
                Col385 = fvalue[c++],
                Col386 = fvalue[c++],
                Col387 = fvalue[c++],
                Col388 = fvalue[c++],
                Col389 = fvalue[c++],
                Col390 = fvalue[c++],
                Col391 = fvalue[c++],
                Col392 = fvalue[c++],
                Col393 = fvalue[c++],
                Col394 = fvalue[c++],
                Col395 = fvalue[c++],
                Col396 = fvalue[c++],
                Col397 = fvalue[c++],
                Col398 = fvalue[c++],
                Col399 = fvalue[c++],
            };
        }

        private bool IsBlack(Color color)
        {
            return ((color.R + color.G + color.B) / 3 > 127);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetPictureBox();
        }

        private void ResetPictureBox()
        {
            Bitmap bitmap = new Bitmap(200, 200);
            Graphics gr = Graphics.FromImage(bitmap);
            gr.FillRectangle(Brushes.White, 0, 0, 200, 200);
            pb_img.Image = bitmap;
            
        }


        Point pt = new Point(0, 0);
        bool check;
        private void pb_img_MouseDown(object sender, MouseEventArgs e)
        {
            check = true;
            pt = e.Location;
        }

        private void pb_img_MouseMove(object sender, MouseEventArgs e)
        {
            if (check)
            {
                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 10);
                Graphics gr = Graphics.FromImage(pb_img.Image);
                gr.DrawLine(blackPen, pt, e.Location);
                pt = e.Location;
                pb_img.Invalidate();
            }

        }

        private void pb_img_MouseUp(object sender, MouseEventArgs e)
        {            
            check = false;
        }
    }
}
