using System;


namespace Study
{
    class MainApp
    {

        static void Main(string[] args)
        {
            while (true)
          { 
              a2 :
          //소속을 입력받는곳 
          Console.WriteLine("당신의 군대소속은 어디입니까?(육군/공군/해군/공익)");
          string belong= Console.ReadLine();
          
          //군대소속에 대한 별명말하기
          
          switch (belong)

          {
              
              case "육군":
                  Console.WriteLine("당신은 땅개입니다!");
                  break;
              case "해군" :
                  Console.WriteLine("당신은 물개입니다!");
                  break;
              case "공군" :
                  Console.WriteLine("당신은 참새입니다!");
                  break;
              case "공익" :
                  Console.WriteLine("당신은 부럽습니다!");
                  break;
              case "상근" :
                  Console.WriteLine("당신은 역겹습니다!");
                  break;
            //선택지에 없는 말은 다시 물어보기
              default :
                  Console.WriteLine("목록에 있는 소속을 말해주세요!");
                  goto a2;   
          }  
          //반복질문만들기
            a1 :
              Console.WriteLine("계속하시겠습니까?(예/아니요) : ");
              string answer = Console.ReadLine();
              //선택지에 따라 종료유무 묻기
              if (answer =="예")
              continue;
             

              else if(answer =="아니요")
              break;
              //선택지에 없으면 다시 물어보기
              else 
              Console.WriteLine("유효한 대답이 아닙니다, 다시 대답해주십시요");
              goto  a1;
              

             
          }        
          

            
             
                
                        
            
        } 

            
    }

 }
    

