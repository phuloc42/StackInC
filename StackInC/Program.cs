using System;
using System.Collections;

namespace StackInC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack myStack = new Stack(); // khởi tạo stack rỗng
            Stack myStack2 = new Stack(5); // khởi tạo stack và chỉ định sức chứa ban đầu là 5

            //khởi tạo một mảng bất kỳ:
            ArrayList myArr = new ArrayList();
            myArr.Add(5);
            myArr.Add(3);
            myArr.Add(4);
            //khởi tạo 1 stack sao chép hết các giá trị từ myArr vào stack
            Stack myStack3 = new Stack(myArr);



            //tạo 1 stack rỗng:
            Stack myStack4 = new Stack();
            //Thêm vài phần tử
            myStack4.Push("Loc");
            myStack4.Push("Thanh");
            myStack4.Push("Nguyen");

            // Thử sử dụng các phương thức của Stack.
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", myStack4.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Stack thì ta sẽ dùng Peek.
            Console.WriteLine(" Phan tu dau cua Stack la: {0}", myStack4.Peek());

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack.
            Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", myStack4.Count);

            // Thực hiện xoá các phần tử ra khỏi Stack.
            Console.WriteLine(" Popping...");
            int Length = myStack4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + myStack4.Pop());
            }
            Console.WriteLine();

            // Kiểm tra lại số phần tử của Stack sau khi Pop
            Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", myStack4.Count);
        }
    }
}
