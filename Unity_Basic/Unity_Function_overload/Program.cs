﻿using System;

using System.Collections.Generic;

using System.Text;



namespace UnityLesson_CSharp_Operator

{

    class OperatorFunctions

    {

        //산술 연산  

        //================================================================ 

        //더하기 

        static public int Sum(int a, int b)

        {

            return a + b;

        }

        //빼기 

        static public int Sub(int a, int b)

        {

            return a - b;

        }

        //나누기 

        static public int Div(int a, int b)

        {

            return a / b;

        }

        //곱하기 

        static public int Mul(int a, int b)

        {

            return a * b;

        }



        //나머지 

        static public int Mod(int a, int b)

        {

            return a % b;

        }



        //증감 연산 

        //========================================================= 

        static public int Increase(int a)

        {

            return a++;

        }

        static public int Decrease(int a)

        {

            return a--;

        }



        //관계 연산 

        //========================================================== 

        static public bool IsSame(int a, int b)

        {

            return a == b;

            /*bool isSame = false; 

            if (a == b) 

                isSame = true; 

            return isSame;*/

        }

        static public bool IsDifferent(int a, int b)

        {

            return a != b;

            /*bool isDifferent = false; 

            if (a != b) 

                isDifferent = true; 

            return isDifferent;*/

        }

        static public bool IsBigger(int a, int b)

        {

            return a > b;

            /*bool isBigger = false; 

            if (a > b) 

                isBigger = true; 

            return isBigger;*/

        }

        static public bool IsSmaller(int a, int b)

        {

            return a < b;

            /*bool isSmaller = false; 

            if (a < b) 

                isSmaller = true; 

            return isSmaller;*/

        }

        static public bool IsBiggerOrSame(int a, int b)

        {

            return a >= b;

            /*bool isBiggerOrSame = false; 

            if (a >= b) 

                isBiggerOrSame = true; 

            return isBiggerOrSame;*/

        }

        static public bool IsSmallerOrSame(int a, int b)

        {

            return a <= b;

            /*bool isSmallerOrSame = false; 

            if (a <= b) 

                isSmallerOrSame = true; 

            return isSmallerOrSame;*/

        }


      
        static public int PlusBToA(int a, int b)

        {

            a += b;

            return a;

        }

        static public float PlusBToA(float a, float b)  // 오버로딩
        {

            {

                a += b;

                return a;

            }
        }

        static public int MinusBToA(int a, int b)

        {

            a -= b;

            return a;

        }

        static public int MultiplyBToA(int a, int b)

        {

            a *= b;

            return a;

        }

        static public int DivideBToA(int a, int b)

        {

            a /= b;

            return a;

        }

        static public int ModBToA(int a, int b)

        {

            a %= b;

            return a;

        }





        // 논리 연산 

        // 양측의 피연산자들을 비교하여 연산 수행 

        //======================================================================= 

        static public bool LogicOR(bool a, bool b)

        {

            return a | b;

        }

        static public bool LogicAND(bool a, bool b)

        {

            return a & b;

        }

        static public bool LogicXOR(bool a, bool b)

        {

            return a ^ b;

        }

        static public bool LogicNOT(bool a)

        {

            return !a;

        }



        static public bool ConditionalLogicOR(bool a, bool b)

        {

            return a || b;


        }

        static public bool ConditionalLogicAND(bool a, bool b)

        {

            return a && b;

            // a 가 false 일 경우, b 의 값에 상관없이 결과가 false 이므로, b 를 평가하지않고 false 를 리턴. 

        }



        // 비트 연산 

        //======================================================== 

        static public int BitLogicOR(int a, int b)

        {

            return a | b;

        }

        static public int BitLogicAND(int a, int b)

        {

            return a & b;

        }

        static public int BitLogicXOR(int a, int b)

        {

            return a ^ b;

        }

        static public int BitShiftLeft(int a, int howManyBitYouWantToShift)

        {

            return a >> howManyBitYouWantToShift;

        }

        static public int BitShiftRight(int a, int howManyBitYouWantToShift)

        {

            return a >> howManyBitYouWantToShift;

        }

        static public int BitComplement(int a)

        {

            return ~a;

        }

    }

}