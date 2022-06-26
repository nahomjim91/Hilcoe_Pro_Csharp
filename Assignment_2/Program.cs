using System;
using System.Linq;

namespace Assignment_2
{
	public static class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello there! ");
			int cho, noStudent;
			string s;
			do{
				Console.Write("enter the number of Student: ");
				noStudent = Console.Read();
			}while(noStudent<1);
			Student  students = new Student();
			char again;
			do{
			Console.WriteLine("\n0.Add data\n1.Edit data\n2.View data");
			Console.Write("Your choice: ");
			cho = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(cho);
			switch(cho){
				case 0: students.addStudent();
				break;
				case 1: //Console.WriteLine("sorry for now editting not working!");
						students.editData();
					break;
				case 2:
						Console.WriteLine("hu");
					break;
				default :Console.WriteLine("worng choice: ");
					break;		
			}
			
				Console.Write("do you want to continue (y/n): ");
				s = Console.ReadLine();
				Console.Clear();
			}while(s!="n");
			
		}
	}
	
	class Student{
		private string Fname,Lname;
		private byte age;
		private char section, gender;
		private char[] grade= new char[4];
		/*
			0.c#,1.asm,2.DB,3.Maths
		*/
		public Student(){}
		public void setGrade(char [] a){
			for(int i=0;i<4;i++){
				this.grade[i]=a[i];
			}
		}
		public char[] getGrade(){ return this.grade;}
		void setFname(string a){this.Fname=a;}
		public string getFname(){	return this.Fname;}
		void setLname(string a){this.Lname=a;}
		public string  getLname(){	return this.Lname;}
		public void setsection(char a){this.section=a;}
		public char getSection(){	return this.section;}
		public void setAge(byte a){this.age=a;}
		public byte getAge(){	return this.age;}
		public void setgender(char a){this.gender=a;}
		public char getGender(){	return this.gender;}
		public void display(){
			Console.WriteLine("First name: "+this.Fname+"Last name: "+this.Lname+"Section: "+this.section);
			Console.WriteLine("0.C#: "+grade[0]+"\n1.Asm: "+grade[1]+"\n2.DB: "+grade[2]+"\n3.Maths: "+grade[3]);
						
		}
		public void editData(){
			Console.WriteLine("1.First name\n2.Last name\n3.Age\n4.Section\n5.Grade");
			Console.Write("you choice: ");
			int cho = Convert.ToInt32(Console.ReadLine());
			string s;
			do{
				if(cho<0||cho>6)
				Console.Write("wrong choice \nEnter again: ");
			}while(cho<0||cho>6);
			switch(cho){
				case 1: Console.WriteLine(getFname()+": ");
						Console.Write("enter: ");
						  Fname = Console.ReadLine();
					break;
				case 2: Console.WriteLine(getLname());
						Console.Write("enter: ");
						  Lname = Console.ReadLine();
					break;
				case 3:Console.WriteLine(getAge());
					    Console.Write("enter: ");
						  age = Convert.ToByte(Console.ReadLine());
					break;
				case 4:Console.WriteLine(getSection());
					   Console.Write("enter: ");
						  s = Console.ReadLine();
						  section = s[0];
					break;
				case 5: Console.WriteLine("0.C#: "+grade[0]+"\n1.Asm: "+grade[1]+"\n2.DB: "+grade[2]+"\n3.Maths: "+grade[3]);
						s = Console.ReadLine();
						this.section = s[0];
						Console.WriteLine("enter the grade based this: \n 0.C#\n1.Asm\n2.DB\n3.Maths");
						for(int i=0;i<4;i++){
							Console.Write("enter: ");
							s = Console.ReadLine();
							this.grade[i] = s[0];
						} 
					break;
				
				default :Console.WriteLine(" "); 
					break;
				
			}
		}
		public void addStudent(){
			Console.Write("\nFirst name: ");
			this.Fname = Console.ReadLine();
			Console.Write("Last name: ");
			this.Lname = Console.ReadLine();
			string s;
			try{	
			do{
			Console.Write("age: ");
			this.age = Convert.ToByte( Console.ReadLine());
			if(this.age>1)
				Console.Write("\n");
			else
				Console.WriteLine("age can't be less than 1! ");
			}while(this.age<1);
			}catch(Exception e){
				//e.Message;
				Console.WriteLine("wrong");
			}
			Console.Write("Section: ");
			s = Console.ReadLine();
			this.section = s[0];
			Console.WriteLine("enter the grade based this: \n 0.C#\n1.Asm\n2.DB\n3.Maths");
			for(int i=0;i<4;i++){
				Console.Write("enter: ");
				s = Console.ReadLine();
				this.grade[i] = s[0];
			}
		}
	}	
	
}





