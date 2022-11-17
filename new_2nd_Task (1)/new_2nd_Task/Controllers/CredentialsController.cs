using Credentials_Module.EFCore;
using Microsoft.AspNetCore.Mvc;
using new_2nd_Task.Model;
using final_code.Model;

namespace Credentials_Module.Controllers
{

    [ApiController]
    public class CredentialsController : ControllerBase
    {
        private readonly DbHelper _db;
        public CredentialsController(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);
        }

       

        //GET: api/<CredentialsController>
         [HttpGet]
         [Route("users/{userId}/GetCredentials")]
         public IActionResult GetuserCredentials(int userId)
         {
             try
             {
                 IEnumerable<CredInfoModel> data = (IEnumerable<CredInfoModel>)_db.GetuserCred(userId);
                 return Ok(data);
             }
             catch (Exception ex)
             {
                 return BadRequest(ex);
             }
         }



        // POST api/<CredentialsController>
        [HttpPost]
        [Route("users/{UserID}/Credentials")]
        public IActionResult Post([FromBody] CredInfoModel credInfoModel)
        {
            try
            {
                _db.Credentials(credInfoModel);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }



        // DELETE api/<CredentialsController>/5
        [HttpDelete]
        [Route("api/[controller]/deleteCred/{UserId}")]
        public IActionResult Delete(int UserId)
        {
            try
            {
                _db.deleteCredInfo(UserId);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("users/{UserID}/shared/credentials")]
        public IActionResult GetUsercred1(int UserId)
        {
            try
            {
                IEnumerable<UsertableModel> data = (IEnumerable<UsertableModel>)_db.GetUsercred1(UserId);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

       

        // POST api/<CredentialsController>
        [HttpPost]
        [Route("users/{UserID}/shared/Usercredentials/{CredentialID}")]
        public IActionResult Post([FromBody] UsertableModel UsertableModel)
        {
            try
            {
                _db.UserCredentials(UsertableModel);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
        
       

    }

}
