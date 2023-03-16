namespace Consecionaria;

class program
{
        static void Main(string[] args){

                Menu menu = new Menu();
                bool mostrarMenu =true;
                while(mostrarMenu){
                        mostrarMenu=menu.ShowMenu();
                }

        }
}

     

