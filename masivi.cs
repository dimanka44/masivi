/*
 * Created by SharpDevelop.
 * User: Dimana
 * Date: 1/14/2023
 * Time: 6:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proektche
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{
		Student newStud = new Student();
		Student[] clasOf = new Student[27];
		
		public MainForm()
		{
			InitializeComponent();
			
			for (int i =1; i<= 26; i++)
			{
				clasOf[i] = new Student();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			int i = int.Parse(textBox2.Text);
			if(i>=1 && i<=26)
			{
				comboBox1.Text=clasOf[i].clas;
				textBox2.Text=clasOf[i].num.ToString();
				textBox3.Text=clasOf[i].name;
				textBox4.Text=clasOf[i].BEL.ToString();
				textBox5.Text=clasOf[i].Math.ToString();
				textBox6.Text=clasOf[i].Angliiski.ToString();
				textBox7.Text=clasOf[i].Ispanski.ToString();
				textBox8.Text=clasOf[i].Informatika.ToString();
				textBox9.Text=clasOf[i].Geografiq.ToString();
				textBox10.Text=clasOf[i].Biologiq.ToString();
				textBox11.Text=clasOf[i].Fizika.ToString();
			}
			else
			{
				MessageBox.Show("Грешка! Въведете номер 1 до 26");
			}
		
		}

		void Button2Click(object sender, EventArgs e)
		{
			int i =int.Parse(textBox2.Text);
			
			if (i >= 1 && i<= 26)
			{
				Student newSt = new Student();
				newSt.clas = comboBox1.Text; clasOf[i].clas = newSt.clas;
				newSt.num = int.Parse(textBox2.Text); clasOf[i].num = newSt.num;
				newSt.name = textBox3.Text; clasOf[i].name = newSt.name;
				newSt.BEL = double.Parse(textBox4.Text); clasOf[i].BEL = newSt.BEL;
				newSt.Math = double.Parse(textBox5.Text); clasOf[i].Math = newSt.Math;
				newSt.Angliiski = double.Parse(textBox6.Text); clasOf[i].Angliiski = newSt.Angliiski;
				newSt.Ispanski = double.Parse(textBox7.Text); clasOf[i].Ispanski = newSt.Ispanski;
				newSt.Informatika = double.Parse(textBox8.Text); clasOf[i].Informatika = newSt.Informatika;
				newSt.Geografiq = double.Parse(textBox9.Text); clasOf[i].Geografiq = newSt.Geografiq;
				newSt.Biologiq = double.Parse(textBox10.Text); clasOf[i].Biologiq = newSt.Biologiq;
				newSt.Fizika = double.Parse(textBox11.Text); clasOf[i].Fizika = newSt.Fizika;
				
			}
			else
			{
				MessageBox.Show("Грешка! Въведете номер 1 до 26");
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			
		}

		
		class Student
{
			public string clas;
			public int num;
			public string name;
			
			private double bel;
			private double math;
			private double angl;
			private double isp;
			private double informatika;
			private double geo;
			private double bio;
			private double fiz;
							
		    public double BEL
			{
				get { return bel; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.bel = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по БЕЛ!");
					}
				}		
		    }
		    public double Math
			{
				get { return math; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.math = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по Математика!");
					}
				}		
		    }  
		    public double Angliiski
			{
				get { return angl; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.angl = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по Английски!");
					}
				}		
		    }
		    public double Ispanski
			{
				get { return isp; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.isp = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по Испански!");
					}
				}		
		    }
		    public double Informatika
		    {
				get { return informatika; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.informatika = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по Информатика!");
					}
				}		
		    }	
		    public double Geografiq
		    	{
				get { return geo; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.geo = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по География!");
					}
				}		
		    }
		    public double Biologiq
		    	{
				get { return bio; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.bio = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по Биология!");
					}
				}		
		    }
		    public double Fizika
		    	{
				get { return fiz; }
				set
				{
					if (value >=2 && value <= 6)
					{
						this.fiz = value;
					}
					else
					{
						MessageBox.Show("Невалидна оценка по Физика!");
					}
				}		
		    }
		      
		    public double calcAvarage()
		       {
		    	return( this.BEL + this.Math + this.Angliiski + this.Ispanski + this.Informatika + this.Geografiq + this.Biologiq + this.Fizika) / 8;
		       }
		     
}
		void Button4Click(object sender, EventArgs e)
		{
			int number = int.Parse(textBox2.Text);
			Student st = clasOf[number];
			
			label10.Text= (st.calcAvarage()).ToString("#.##");
			
			double n = double.Parse(label10.Text);
			if (n>=2 && n<=2.49)
			{
				MessageBox.Show("Много слабо.");
			}
			else if (n>=2.50 && n<=3.49)
			{
				MessageBox.Show("Поне не е 2.");
			}
			else if (n>=3.50 && n<=4.49)
			{
				MessageBox.Show("Добре си, златната среда.");
			}
			else if (n>=4.50 && n<=5.49)
			{
				MessageBox.Show("Винаги може повече...");
			}
			else if (n>=5.50)
			{
				MessageBox.Show("Евала, най-добрият!");
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			comboBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
			
			textBox4.Text="0";
			textBox5.Text="0";
			textBox6.Text="0";
			textBox7.Text="0";
			textBox8.Text="0";
			textBox9.Text="0";
			textBox10.Text="0";
			textBox11.Text="0";
			label10.Text="0";
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label10Click(object sender, EventArgs e)
		{
			
		}
		void Label15Click(object sender, EventArgs e)
		{
			
		}
		
	}
	
}


		