using ImagerLib.Modules.Resizer;
using ImagerLib.Modules.Converter;
using ImageResizer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImagerLib;

namespace ImageResizer.Controllers
{
    public class ImageController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Image imageModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string extension = Path.GetExtension(imageModel.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"),fileName);
            imageModel.ImageFile.SaveAs(fileName);
            using (DbModelsss db = new DbModelsss())
            {
                db.Images.Add(imageModel);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }

            return View(imageModel);
        }

        public ActionResult Resize(int id)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }

            return View(imageModel);
        }

        public ActionResult ResizeOptions(int id)
        {
            Image imageModel = new Image();


            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }
            
            string fileName = Path.GetFileName(imageModel.ImagePath);

            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            
            System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(fileName);
            

            return View(imageModel);
        }
        
        public ActionResult Resizing(Image model)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == 0).FirstOrDefault();
            }


            string fileName = Path.GetFileName(imageModel.ImagePath);
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            string destName = Path.GetFileName(imageModel.ImagePath);
            destName = Path.Combine(Server.MapPath("~/Image/Resized/"), destName);

            Imager imager = new Imager();


            try
            { 
            imager.Resize(fileName, destName,ResizeType.KeepAspect,model.Width,model.Height);
            }

            catch(Exception ex)
            {
                return View("Error", ex);
            }
            return RedirectToAction("View/0");
        }

        public ActionResult Crop(int id)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }

            string fileName = Path.GetFileName(imageModel.ImagePath);

            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(fileName);
            
            return View(imageModel);
        }

        public ActionResult Cropping(Image model)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == 0).FirstOrDefault();
            }

            string fileName = Path.GetFileName(imageModel.ImagePath);
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            string destName = Path.GetFileName(imageModel.ImagePath);
            destName = Path.Combine(Server.MapPath("~/Image/Cropped/"), destName);

            Imager imager = new Imager();


            try
            {
                imager.Resize(fileName, destName, ResizeType.Crop, model.Width, model.Height, model.X, model.Y);
            }

            catch (Exception ex)
            {
                return View("Error", ex);
            }

            return RedirectToAction("View/0");
        }


        public ActionResult Skew(int id)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }

            string fileName = Path.GetFileName(imageModel.ImagePath);

            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(fileName);
            
            return View(imageModel);
        }

        public ActionResult Skewing(Image model)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == 0).FirstOrDefault();
            }

            string fileName = Path.GetFileName(imageModel.ImagePath);
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            string destName = Path.GetFileName(imageModel.ImagePath);
            destName = Path.Combine(Server.MapPath("~/Image/Skewed/"), destName);

            Imager imager = new Imager();
            try
            {
                imager.Resize(fileName, destName, ResizeType.Skew, model.Width, model.Height);
            }

            catch (Exception ex)
            {
                return View("Error", ex);
            }


            return RedirectToAction("View/0");

        }

        

        public ActionResult Convert(int id)
        {
            Image imageModel = new Image();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }

            return View(imageModel);
        }

        public ActionResult ToGif(int id)
        {
            Image imageModel = new Image();
            Imager imager = new Imager();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }
            string fileName = Path.GetFileName(imageModel.ImagePath);
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            string destName = Path.GetFileNameWithoutExtension(imageModel.ImagePath);
            destName = Path.Combine(Server.MapPath("~/Image/ToGif/"), destName );
            destName += ".gif";
            
            try
            {
                imager.Convert(fileName, destName, ConvertType.Gif);
            }

            catch (Exception ex)
            {
                return View("Error", ex);
            }



            return RedirectToAction("View/0");
        }

        public ActionResult ToPng(int id)
        {
            Image imageModel = new Image();
            Imager imager = new Imager();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }
            string fileName = Path.GetFileName(imageModel.ImagePath);
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            string destName = Path.GetFileNameWithoutExtension(imageModel.ImagePath);
            destName = Path.Combine(Server.MapPath("~/Image/ToPng/"), destName);
            destName += ".png";
            
            try
            {
                imager.Convert(fileName, destName, ConvertType.Png);
            }

            catch (Exception ex)
            {
                return View("Error", ex);
            }


            return RedirectToAction("View/0");

        }


        public ActionResult ToJpg(int id)
        {
            Image imageModel = new Image();
            Imager imager = new Imager();

            using (DbModelsss db = new DbModelsss())
            {
                imageModel = db.Images.Where(x => x.ImageId == id).FirstOrDefault();
            }
            string fileName = Path.GetFileName(imageModel.ImagePath);
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

            string destName = Path.GetFileNameWithoutExtension(imageModel.ImagePath);
            destName = Path.Combine(Server.MapPath("~/Image/ToJpg/"), destName);
            destName += ".jpg";


            

            try
            {
                imager.Convert(fileName, destName, ConvertType.Jpg);
            }

            catch (Exception ex)
            {
                return View("Error", ex);
            }


            return RedirectToAction("View/0");
        }

    }
}