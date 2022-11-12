using System.Runtime.Intrinsics.Arm;
using tortik;
css1 tort = new css1();
css2 Dop = new css2();
int pos = 0;
while (true)
{
    Console.Clear();
    pos = tort.menu();
    switch (pos)
    {
        case 0:
            {
                Console.Clear();
                tort.menuForma();
            }
            break;
        case 1:
            {

                Console.Clear();
                tort.menuRazmer();
            }
            break;
        case 2:
            {
                Console.Clear();
                tort.menuVkus();
            }
            break;
        case 3:
            {
                Console.Clear();
                tort.menuKolichestvo();
            }
            break;
        case 4:
            {
                Console.Clear();
                tort.menuGlazur();
            }
            break;
        case 5:
            {
                Console.Clear();
                tort.menuDekor();
            }
            break;
        case 6:
            {
                Console.Clear();
                tort.exit();
            }
            break;
    }
}
