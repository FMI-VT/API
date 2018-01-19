using ImageProcess.Exceptions;
using ImageProjectWebAPI.BindModels;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImageProjectWebAPI.Controllers
{
    public class ResizerController : ApiController
    {
        /// <summary>
        /// Resize an image
        /// </summary>
        /// <param name="model">Contains the image information</param>
        /// <response code="201">The image was resized successfully. URL to info is in the Location header</response>
        /// <response code="400">The image data is invalid or missing</response>

        ///<remarks>
        /// Example input :
        ///{
        ///"srcPath": "D:/test/test.gif",
        ///"destPath": "D:/test/testCrop.gif",
        ///"type":"crop",
        ///"width":600,
        ///"height": 500,
        ///"x":15,
        ///"y":15
        ///}
        ///</remarks>

        [Route("api/resize")]
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(ResizeBindModel))]
        public IHttpActionResult Post(ResizeBindModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model can not be null. Please fill up the model data.");
                }

                if (model.height < 1)
                {
                    return BadRequest("Height is invalid. It must be bigger than 0.");
                }

                if (model.width < 1)
                {
                    return BadRequest("Width is invalid. It must be bigger than 0.");
                }

                ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(model.srcPath, model.destPath, model.type, model.width, model.height, model.x, model.y);
                resize.Execute();
                return Created(model.destPath, model);
            }

            catch (MyFileNotFoundException)
            {
                return BadRequest("File with path  " + model.srcPath + " not found.");
            }
            catch (SourceAndDestPathException)
            {
                return BadRequest("Source or Destination path is an empty string, null or contains invalid characters.");
            }
            catch (UnsupportedDestPathException)
            {
                return BadRequest("Destination path " + model.destPath + " is in an invalid format.");
            }
            catch (MyOutOfMemoryException)
            {
                if(model.type.ToLower() == "keepaspect")
                {
                    return BadRequest("There is not enough memory to continue the execution of a program. Please keep image's aspect! Try with diffrent width and/or height.");
                }
                return BadRequest("There is not enough memory to continue the execution of a program. Height " + model.height + " or width " + model.width + " is invalid. Please try smaller size.");
            }
            catch (MySystemException)
            {
                return BadRequest("There is a problem with source path or destionation path. Please save resized image with new name that is diffrent from source image's name!");
            }
        }
    }
}
