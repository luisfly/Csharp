using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FineUIMvc.EmptyProject.Controllers
{
    public class TestController : BaseController
    {
        // GET: Test
        public ActionResult MyTest()
        {
            return View();
        }

        // GET: another view
        public ActionResult AnotherTest()
        {
            return View();
        }

        // 9.9 测试按钮事件控制
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult pressing()
        {
            Alert.Show("你好 FineUI！", MessageBoxIcon.Warning);

            return UIHelper.Result();
        }

        public ActionResult bootstraptest()
        {
            return View();
        }

        public ActionResult bootstrapTheme()
        {
            return View();
        }
    }
}