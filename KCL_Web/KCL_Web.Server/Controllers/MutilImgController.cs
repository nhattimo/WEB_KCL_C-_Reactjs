using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/MutilImg")]
public class MutilImgController : ControllerBase
{
    private readonly string _uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload");


    [HttpPost]
    public async Task<IActionResult> UploadImages(List<IFormFile> files)
    {
        var uploadedFiles = new List<string>();
        foreach (var file in files)
        {
            if (file.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(_uploadFolder, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                uploadedFiles.Add(fileName);
            }
        }
        return Ok(new { FileNames = uploadedFiles });
    }

    [HttpGet]
    public IActionResult GetImages()
    {
        var files = Directory.GetFiles(_uploadFolder)
            .Select(file => Path.GetFileName(file))
            .ToList();
        return Ok(new { Images = files });
    }


    [HttpDelete("delete/{fileName}")]
    public IActionResult DeleteImage(string fileName)
    {
        var filePath = Path.Combine(_uploadFolder, fileName);
        if (System.IO.File.Exists(filePath))
        {
            System.IO.File.Delete(filePath);
            return Ok(new { Message = $"File {fileName} deleted successfully." });
        }
        return NotFound(new { Message = $"File {fileName} not found." });
    }



    [HttpPut("update/{oldFileName}")]
    public async Task<IActionResult> UpdateImage(string oldFileName, IFormFile newFile)
    {
        var oldFilePath = Path.Combine(_uploadFolder, oldFileName);
        if (!System.IO.File.Exists(oldFilePath))
        {
            return NotFound(new { Message = $"File {oldFileName} not found." });
        }

        if (newFile == null || newFile.Length == 0)
        {
            return BadRequest(new { Message = "No file uploaded." });
        }

        // Delete old file
        System.IO.File.Delete(oldFilePath);

        // Save new file
        var newFileName = Guid.NewGuid().ToString() + Path.GetExtension(newFile.FileName);
        var newFilePath = Path.Combine(_uploadFolder, newFileName);
        using (var stream = new FileStream(newFilePath, FileMode.Create))
        {
            await newFile.CopyToAsync(stream);
        }

        return Ok(new { OldFileName = oldFileName, NewFileName = newFileName, Message = "File updated successfully." });
    }
}