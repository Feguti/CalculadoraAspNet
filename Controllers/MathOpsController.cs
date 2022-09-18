using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CalculadoraAspNet.Models;

namespace CalculadoraAspNet.Controllers;

public class MathOpsController : Controller
{
    private readonly ILogger<MathOpsController> _logger;

    public MathOpsController(ILogger<MathOpsController> logger)
     {
        _logger = logger;
    }

    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult ResultadoSoma([FromForm] double numero1, [FromForm] double numero2 ){
        
        ViewData["numero1"] = numero1;
        ViewData["numero2"] = numero2;
        ViewData["resultado"] = numero1 + numero2;

        return View();
    }

    public IActionResult ResultadoSubtracao([FromForm] double numero1, [FromForm] double numero2 ){
        
        ViewData["numero1"] = numero1;
        ViewData["numero2"] = numero2;
        ViewData["resultado"] = numero1 - numero2;

        return View();
    }

    public IActionResult ResultadoMultiplicacao([FromForm] double numero1, [FromForm] double numero2 ){
        
        ViewData["numero1"] = numero1;
        ViewData["numero2"] = numero2;
        ViewData["resultado"] = numero1 * numero2;

        return View();
    }

    public IActionResult ResultadoDivisao([FromForm] double numero1, [FromForm] double numero2 ){
        
        ViewData["numero1"] = numero1;
        ViewData["numero2"] = numero2;
        ViewData["resultado"] = numero1 / numero2;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}