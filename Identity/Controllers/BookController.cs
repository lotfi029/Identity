//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Models.Core;
//using Models.Core.DTO.Book;
//using Models.Core.Models;

//namespace Identity.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BookController : ControllerBase
//    {
//        private readonly IUnitOFWork repo;

//        public BookController(IUnitOFWork Repo)
//        {
//            repo = Repo;
//        }
//        [HttpPost("/PostBook")]
//        public IActionResult PostBook(BookDTO bookDTO)
//        {
//            try
//            {
//                if (ModelState.IsValid)
//                {
//                    // Mapping 
//                    Book bookModel = new()
//                    {
//                        BookName = bookDTO.BookName,
//                        AuthorId = bookDTO.AuthorId,
//                        PublichDate = bookDTO.PublichDate
//                    };
//                    repo.Book.Add(bookModel);
//                    repo.Save();
//                    return Ok(bookModel);
//                } else
//                {
//                    return BadRequest();
//                }
//            } catch (Exception ex) { return BadRequest(ex); }
            
//        }
//    }
//}
