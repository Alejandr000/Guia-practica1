﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class SiteMaster : MasterPage
    {




        public ArrayList numeros = new ArrayList();
       public static double numero1 = 0, numero2=0;
        public static char op;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            act("7");
            
           
            
        }
        public void act(String resul) {
           
            
         

                if (Label1.Text == "")
                {
                  
                    Label1.Text = resul.ToString();
                    
                
                }
                else
                {
                    Label1.Text =  Label1.Text + resul.ToString();
                   
                }

               

            

           

        }

       


        protected void Button2_Click(object sender, EventArgs e)
        {
 
            act("8");

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            
           
          
            
          
            act("+");
            op= '+';
            

           

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            act("9");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            act("4");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            act("5");

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            act("6");

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            act("1");

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            act("2");

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            act("3");

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            act("0");

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Label1.Text = " ";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
          


            act("-");
            op = '-';
         

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
          


            act("x");
            op = 'x';
           

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
          
             


            act("÷");
            op = '÷';
           
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            act(".");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {

            if (Label1.Text.Contains(op))
            {
                double rsl = 0;


                var operacion = Label1.Text.Split(op).Select(double.Parse).ToList();

                foreach (var calc in operacion)
                {
                    

                    switch (op)
                    {


                        case '+':
                            rsl = rsl+calc;
                            Label1.Text = "";
                            Label1.Text = Convert.ToString(rsl);

                            break;
                        case '-':
                              
                            break;
                        case 'x':
                            
                           rsl= rsl * calc;

                          
                            Label1.Text = Convert.ToString(rsl);
                            break;
                        case '÷':
                            rsl = (rsl/calc);
                            Label1.Text = "";
                            Label1.Text = rsl.ToString();
                            break;
                        default:
                            Label1.Text = "Error";
                            break;

                    }
                  
                }
               
            }
           
           
         
        }
    }
}