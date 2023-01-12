int FactorialWithoutRecursion(int n)
            {
                int result = 1;
                for(int i = 2; i<= n; ++i)
                {
                    result *= i;
                }
                return result;
            }
int FactorialWithRecursion(int n)
            {
                if (n == 1)
                    return 1;
                return n * FactorialWithRecursion(n - 1);
            }

void FibonacciWithoutRecursion(int n)
            {
                int firstNum = 0;
                int secondNum = 1;
                int nextNum;
                Console.Write($"{firstNum}, {secondNum}");
                for(int i = 2; i < n; ++i)
                {
                    nextNum = firstNum + secondNum;
                    Console.Write($", {nextNum}");
                    firstNum = secondNum;
                    secondNum = nextNum;
                }
            }
void FibonacciWithRecursion(int firstNum, int secondNum, int counter, int n)
            {
                Console.Write($"{firstNum} ");
                if(counter < n)
                    FibonacciWithRecursion(secondNum, firstNum + secondNum, ++counter, n);
            }

int ArrayProblem1(int[] array)
            {
                int result = 1;
                for (int i = 0; i < array.Length; ++i)
                {
                    if (array[i] % 5 == 2)
                        result *= array[i];
                }
                return result;
            }
int ArrayProblem2(int[] array)
            {
                int result = 0;
                for (int i = 0; i < array.Length; ++i){
                    if ((array[i] + i) % 3 == 0)
                        result += array[i] * array[i];
                }
                return result;
            }
void ArrayProblem3(ref int[] array, int k)
            {
                array = array.Where(val => val >= k).ToArray();
                PrintArray(array);
            }

void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; ++i)
                {
                    Console.Write($"{array[i]} ");
                }
            }


void SortAscending(ref int[] array)
            {
                for (int i = 0; i < array.Length; ++i)
                {
                    for (int j = i +1; j < array.Length; ++j)
                    {
                        if (array[i] > array[j])
                            Swap(ref array[i], ref array[j]);
                    }
                }
                PrintArray(array);
            }
void Swap(ref int a, ref int b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }


int[] array = { 5, 4, 8, 7, 12, 17, 3};
int k = 6;

//FibonacciWithoutRecursion(9);
//FibonacciWithRecursion(0,1,1,9);

//Console.WriteLine(FactorialWithoutRecursion(5));
//Console.WriteLine(FactorialWithRecursion(5));

//Console.WriteLine(ArrayProblem1(array));
//Console.WriteLine(ArrayProblem2(array));
//ArrayProblem3(ref array, k);

//SortAscending(ref array);
