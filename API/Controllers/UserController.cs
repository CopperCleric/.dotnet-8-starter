using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentation.Responses;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers(int pageNumber = 1, int pageSize = 5)
    {
        var result = await _userService.GetUsersPaginatedAsync(pageNumber, pageSize);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null)
            return NotFound(ApiResponse<string>.FailResponse("User not found"));

        return Ok(ApiResponse<User>.SuccessResponse(user));
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser([FromBody] User user)
    {
        var createdUser = await _userService.RegisterUserAsync(user);
        return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, ApiResponse<User>.SuccessResponse(createdUser, "User created"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(Guid id, [FromBody] User user)
    {
        if (id != user.Id)
            return BadRequest(ApiResponse<string>.FailResponse("User ID mismatch"));

        await _userService.UpdateUserAsync(user);
        return Ok(ApiResponse<string>.SuccessResponse("User updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        await _userService.DeleteUserAsync(id);
        return Ok(ApiResponse<string>.SuccessResponse("User deleted"));
    }
}

