using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            }

            return Json(new { inputNumber = N, binaryNumber = repStr, binaryGap = longestBinaryGap }, JsonRequestBehavior.AllowGet);
        }
    }
}