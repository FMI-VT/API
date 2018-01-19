using ImageProjectWebAPI.BindModels;
using Swashbuckle.Swagger.Annotations;
using System.Web.Http;
using ImageProcess.Exceptions;

namespace ImageProjectWebAPI.Controllers
{
    public class ConverterController : ApiController
    {
        /// <summary>
        /// Convert new image
        /// </summary>
        /// <param name="model">Contains the image information</param>
        /// <response code="201">The image was converted successfully. URL to info is in the Location header</response>
        /// <response code="400">The image data is invalid or missing</response>

        ///<remarks>
        /// Example input :
        ///{
        ///"srcPath": "D:/test/test.gif",
        ///"destPath": "D:/test/test.png",
        ///"type":"png"
        ///}
        ///</remarks>

        [Route("api/convert")]
        [HttpPost]
        [SwaggerResponse(200, Type = typeof(ConvertBindModel))]
        public IHttpActionResult Post(ConvertBindModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model can not be null. Please fill up the model data.");
                }

                ImageProcess.Converter.Convert convert = new ImageProcess.Converter.Convert(model.srcPath, model.destPath, model.type);
                convert.Execute();
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
                return BadRequest("There is not enough memory to continue the execution of a program");
            }
            catch (MySystemException)
            {
                return BadRequest("There is a problem with source path or destionation path.");
            }
        }
    }
}
