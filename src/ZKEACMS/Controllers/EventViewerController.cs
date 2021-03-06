﻿using Easy.Mvc.Authorize;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using ZKEACMS.Common.Service;

namespace ZKEACMS.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ManageEventViewer)]
    public class EventViewerController : Controller
    {
        private readonly IEventViewerService _eventViewerService;
        public EventViewerController(IEventViewerService eventViewerService)
        {
            _eventViewerService = eventViewerService;
        }
        public IActionResult Index()
        {
            return View(_eventViewerService.Get());
        }
        public IActionResult Delete(string fileName)
        {
            _eventViewerService.Delete(fileName);
            return Json(true);
        }
    }
}
