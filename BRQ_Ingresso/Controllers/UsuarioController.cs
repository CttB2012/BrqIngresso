using BRQ_Ingresso.Context;
using BRQ_Ingresso.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BRQ_Ingresso.Controllers;

[Route("/challengebrq/v1/usuarios")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsuarioController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Usuario>> GetUsuarios() 
    { 
        var usuarios = _context.Usuarios.ToList();
        if(usuarios is null)
        {
            return NotFound();
        }
        return usuarios;
    }

    [HttpGet("{id}", Name ="NovoUsuario")]
    public ActionResult<Usuario> Get(Guid id) 
    {
        var usuario = _context.Usuarios.FirstOrDefault(p => p.IdUsuario == id);
        if(usuario is null)
        {
            return NotFound();
        }
        return usuario;
    }

    [HttpPost]
    public ActionResult Post(Usuario usuario)
    {
        if(usuario is null)
        {
            return BadRequest();
        }

        _context.Usuarios.Add(usuario);
        _context.SaveChanges();

        return new CreatedAtRouteResult("NovoUsuario", 
            new {id = usuario.IdUsuario}, usuario);
    }
    [HttpPut("{id}")]
    public ActionResult Put(Guid id, Usuario usuario)
    {
        if (id!= usuario.IdUsuario)
        {
            return BadRequest();
        }
        _context.Entry(usuario).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(usuario);
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(p => p.IdUsuario == id);

        if(usuario is null)
        {
            return NotFound();
        }
        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();

        return NoContent();
    }

}
