using LaiDacDuc_241230710.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaiDacDuc_241230710.Views.VietComponents
{
    public class LaiDacDucMenuViewComponent : ViewComponent
    {
        private readonly QlnhaSachContext _db;

        public LaiDacDucMenuViewComponent(QlnhaSachContext db) => _db = db;
        public IViewComponentResult Invoke()
        {
            var theloai = _db.TheLoais.ToList();
            return View(theloai);
        }

        
    }
}
