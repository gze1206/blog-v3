using blog.gze1206.net.Core;
using blog.gze1206.net.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.gze1206.net.Controllers;

[ActionFilter]
public class LayoutController : Controller
{
    public LayoutModel LayoutModel { get; set; }
}