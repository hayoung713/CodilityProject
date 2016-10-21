using System;
using System.Web.Mvc;

namespace CodilityProject.Controllers
{
    [RoutePrefix("api")]
    public class ApiController : CommonController
    {
        [Route("L1T1"), HttpPost]
        public JsonResult L1T1()
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = Convert.ToInt32(Request.Form["number"]);
            int longestBinaryGap = 0;

            // N을 2진수 문자열로 변환
            string repStr = Convert.ToString(N, 2);

            /* 기본적인 방법
            string[] repArr = repStr.Select(r => r.ToString()).ToArray();

            int tempLongestBinary = 0;

            // 1에 해당하는 자리수를 gap array 에 저장
            for (int i = 0; i < repArr.Length; i++)
            {
                if (repArr[i].Equals("1"))
                {

                    // 첫 1이 아니며, 이전 1과 연속되지 않으며, 
                    if (tempLongestBinary != 0 && tempLongestBinary != i && (i - tempLongestBinary) > longestBinaryGap)
                    {
                        // 이전 1과 현재 i 와의 갭이 가장 큰 갭이 된다.
                        longestBinaryGap = i - tempLongestBinary;
                    }

                    tempLongestBinary = i + 1;
                }
            }*/

            // Split 으로 1 씩 자르는 방법
            string[] repArr = repStr.Split('1');
            for (int i = 0; i < repArr.Length - 1; i++)
            {
                if (repArr[i].Length > longestBinaryGap)
                    longestBinaryGap = repArr[i].Length;
            }

            return Json(new { inputNumber = N, binaryNumber = repStr, binaryGap = longestBinaryGap });
        }


        [Route("L2T1"), HttpPost]
        public JsonResult L2T1()
        {
            int[] A = { 5, 1, 5, 8, 1 };
            int oddInteger = 0;

            Array.Sort(A);

            for (int i = 0; i < A.Length; i = i + 2)
            {
                if (i == A.Length - 1 || A[i] != A[i + 1])
                {
                    oddInteger = A[i];
                    break;
                }
            }

            return Json(new { oddInteger = oddInteger });
        }


        [Route("L2T2"), HttpPost]
        public JsonResult L2T2()
        {
            int[] A = { 3, 5 };
            int K = 3;
            
            int aLength = A.Length;
            int[] shiftArr = new int[aLength];

            if (aLength > 1 && K > 0 && K % aLength > 0)
            {
                int shiftNum = aLength <= K ? K % aLength : K;

                for (int i = 0; i < aLength; i++)
                    shiftArr[i] = (i < shiftNum ? A[aLength - shiftNum + i] : A[i - shiftNum]);

            }
            else
            {
                shiftArr = A;
            }

            return Json(new { shiftArr = shiftArr });
        }
    }
}