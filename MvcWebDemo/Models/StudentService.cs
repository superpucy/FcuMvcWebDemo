using MvcWebDemo.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebDemo.Models
{
    public class StudentService
    {
        /// <summary>
        /// 新增學生資料
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public bool CreateStudent(StudentViewModel viewModel)
        {
            /// 1.檢查輸入資料是否符合存檔條件
            /// 2.存檔
            
            if (!IsDaySectionStudent(viewModel))
            {
                return false;
            }

            //存檔

            return true;
        }

        /// <summary>
        /// 檢查輸入學生身份是否為大日學士生
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public bool IsDaySectionStudent(StudentViewModel viewModel)
        {
            if (viewModel.ID.StartsWith("D")) {
                return true;
            }
            viewModel.MESSAGE = "請輸入D開頭的學號";
            return false;
        }
    }
}