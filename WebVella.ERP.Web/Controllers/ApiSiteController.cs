﻿// Test API Controller, will be later substitute by the real data API controller

using Microsoft.AspNet.Mvc;
using WebVella.ERP.Web.Models;
using System;
using Newtonsoft.Json;
using System.Threading;
using System.Collections.Generic;

namespace WebVella.ERP.Web.Controllers
{
    public class ApiSiteController : Controller
    {
		// GET: api/site/meta
		[AcceptVerbs(new[] { "GET" }, Route = "api/root/meta")]
		public IActionResult SiteMeta()
        {
			//TODO - Test data
			var response = new ResponseObj();
			response.Success = true;
			var siteMeta = new SiteMeta();
			var area = new Area();
			var areaSection = new AreaSection();
			var entity = new Entity();

			//Area 1
			area = new Area();
			area.Id = Guid.NewGuid();
			area.Name = "logistics";
			area.Label = "Logistics";
			area.Weight = 1;
			area.Color = "orange";
            area.IconName = "truck";

            //Area1 SectionNull
            areaSection = new AreaSection();
			areaSection.Id = Guid.Empty;
			areaSection.Name = "null";
			areaSection.Label = "Null";
			areaSection.Weight = 1;
			//// Entity 1
			entity = new Entity();
			entity.Id = Guid.NewGuid();
			entity.Name = "order";
			entity.IsSystem = false;
			entity.Label = "Order";
			entity.LabelPlural = "Orders";
			entity.IconName = "shopping-cart";
			entity.Weight = 0;
			areaSection.Entities.Add(entity);
			//// Add Section to Area
			area.Sections.Add(areaSection);

			//Area1 Section 1
			areaSection = new AreaSection();
			areaSection.Id = Guid.Empty;
			areaSection.Name = "section1";
			areaSection.Label = "Area Section 1";
			areaSection.Weight = 1;
			//// Entity 2
			entity = new Entity();
			entity.Id = Guid.NewGuid();
			entity.Name = "entity2";
			entity.IsSystem = false;
			entity.Label = "entity 2";
			entity.LabelPlural = "entity 2s";
			entity.IconName = "files-o";
			entity.Weight = 1;
			areaSection.Entities.Add(entity);
			//// Entity 3
			entity = new Entity();
			entity.Id = Guid.NewGuid();
			entity.Name = "entity3";
			entity.IsSystem = false;
			entity.Label = "entity 3";
			entity.LabelPlural = "entity 3s";
			entity.IconName = "users";
			entity.Weight = 2;
			areaSection.Entities.Add(entity);
			//// Add Section to Area
			area.Sections.Add(areaSection);

			//Area1 Section2
			areaSection = new AreaSection();
			areaSection.Id = Guid.Empty;
			areaSection.Name = "section2";
			areaSection.Label = "Area Section 2";
			areaSection.Weight = 2;
			//// Entity 4
			entity = new Entity();
			entity.Id = Guid.NewGuid();
			entity.Name = "entity4";
			entity.IsSystem = false;
			entity.Label = "entity 4";
			entity.LabelPlural = "entity 4s";
			entity.IconName = "cog";
			entity.Weight = 1;
			areaSection.Entities.Add(entity);
			//// Entity 5
			entity = new Entity();
			entity.Id = Guid.NewGuid();
			entity.Name = "entity5";
			entity.IsSystem = false;
			entity.Label = "entity 5";
			entity.LabelPlural = "entity 5s";
			entity.IconName = "line-chart";
			entity.Weight = 2;
			areaSection.Entities.Add(entity);
			//// Add Section to Area
			area.Sections.Add(areaSection);

			////Add Area to SiteMeta
			siteMeta.Areas.Add(area);

			//Area 2
			area = new Area();
			area.Id = Guid.NewGuid();
			area.Name = "shop";
			area.Label = "Shop";
			area.Weight = 2;
			area.Color = "indigo";
            area.IconName = "shopping-cart";

            //Area2 Section 1
            areaSection = new AreaSection();
            areaSection.Id = Guid.Empty;
            areaSection.Name = "section1";
            areaSection.Label = "Area Section 1";
            areaSection.Weight = 1;
            //// Entity 1
            entity = new Entity();
            entity.Id = Guid.NewGuid();
            entity.Name = "entity1";
            entity.IsSystem = false;
            entity.Label = "entity 1";
            entity.LabelPlural = "entity 2s";
            entity.IconName = "files-o";
            entity.Weight = 1;
            areaSection.Entities.Add(entity);

            area.Sections.Add(areaSection);

            ////Add Area to SiteMeta
            siteMeta.Areas.Add(area);

			//Area 3
			area = new Area();
			area.Id = Guid.NewGuid();
			area.Name = "finance";
			area.Label = "Finance";
			area.Weight = 3;
			area.Color = "green";
            area.IconName = "money";

            //Area3 Section 1
            areaSection = new AreaSection();
            areaSection.Id = Guid.Empty;
            areaSection.Name = "section1";
            areaSection.Label = "Area Section 1";
            areaSection.Weight = 1;
            //// Entity 1
            entity = new Entity();
            entity.Id = Guid.NewGuid();
            entity.Name = "entity1";
            entity.IsSystem = false;
            entity.Label = "entity 1";
            entity.LabelPlural = "entity 2s";
            entity.IconName = "files-o";
            entity.Weight = 1;
            areaSection.Entities.Add(entity);

            area.Sections.Add(areaSection);

            ////Add Area to SiteMeta
            siteMeta.Areas.Add(area);

			//Area 4
			area = new Area();
			area.Id = Guid.NewGuid();
			area.Name = "integration";
			area.Label = "Integration";
			area.Weight = 4;
			area.Color = "cyan";
            area.IconName = "cloud";

            //Area2 Section 1
            areaSection = new AreaSection();
            areaSection.Id = Guid.Empty;
            areaSection.Name = "section1";
            areaSection.Label = "Area Section 1";
            areaSection.Weight = 1;
            //// Entity 1
            entity = new Entity();
            entity.Id = Guid.NewGuid();
            entity.Name = "entity1";
            entity.IsSystem = false;
            entity.Label = "entity 1";
            entity.LabelPlural = "entity 2s";
            entity.IconName = "files-o";
            entity.Weight = 1;
            areaSection.Entities.Add(entity);

            area.Sections.Add(areaSection);

            ////Add Area to SiteMeta
            siteMeta.Areas.Add(area);

			//Area 5
			area = new Area();
			area.Id = Guid.NewGuid();
			area.Name = "customer-loyalty";
			area.Label = "Loyalty";
			area.Weight = 5;
			area.Color = "purple";
            area.IconName = "trophy";

            //Area2 Section 1
            areaSection = new AreaSection();
            areaSection.Id = Guid.Empty;
            areaSection.Name = "section1";
            areaSection.Label = "Area Section 1";
            areaSection.Weight = 1;
            //// Entity 1
            entity = new Entity();
            entity.Id = Guid.NewGuid();
            entity.Name = "entity1";
            entity.IsSystem = false;
            entity.Label = "entity 1";
            entity.LabelPlural = "entity 2s";
            entity.IconName = "files-o";
            entity.Weight = 1;
            areaSection.Entities.Add(entity);

            area.Sections.Add(areaSection);

            ////Add Area to SiteMeta
            siteMeta.Areas.Add(area);


            ////Area 6
            //area = new Area();
            //area.Id = Guid.NewGuid();
            //area.Name = "administration";
            //area.Label = "Administration";
            //area.Weight = 99;
            //area.Color = "red";
            //area.IconName = "gear";

            ////Area2 Section 1
            //areaSection = new AreaSection();
            //areaSection.Id = Guid.Empty;
            //areaSection.Name = "templates";
            //areaSection.Label = "Templates";
            //areaSection.Weight = 1;
            ////// Entity 1
            //entity = new Entity();
            //entity.Id = Guid.NewGuid();
            //entity.Name = "entity";
            //entity.IsSystem = false;
            //entity.Label = "entity";
            //entity.LabelPlural = "Entities";
            //entity.IconName = "gear";
            //entity.Weight = 1;
            //areaSection.Entities.Add(entity);

            //area.Sections.Add(areaSection);

            //////Add Area to SiteMeta
            //siteMeta.Areas.Add(area);


            Thread.Sleep(350);
            response.Object = siteMeta;
			return Json(response);
        }

        // GET: api/site/meta
        [AcceptVerbs(new[] { "GET" }, Route = "api/entities/areas")]
        public IActionResult Areas()
        {
            //TODO - Test data
            var response = new ResponseObj();
            response.Success = true;
            var areas = new List<Area>();
            var area = new Area();
            var areaSection = new AreaSection();
            var entity = new Entity();

            //Area 1
            area = new Area();
            area.Id = Guid.NewGuid();
            area.Name = "logistics";
            area.Label = "Logistics";
            area.Weight = 1;
            area.Color = "orange";
            area.IconName = "truck";
            areas.Add(area);


            //Area 2
            area = new Area();
            area.Id = Guid.NewGuid();
            area.Name = "shop";
            area.Label = "Shop";
            area.Weight = 2;
            area.Color = "indigo";
            area.IconName = "shopping-cart";
            areas.Add(area);

            //Area 3
            area = new Area();
            area.Id = Guid.NewGuid();
            area.Name = "finance";
            area.Label = "Finance";
            area.Weight = 3;
            area.Color = "green";
            area.IconName = "money";
            areas.Add(area);

            //Area 4
            area = new Area();
            area.Id = Guid.NewGuid();
            area.Name = "integration";
            area.Label = "Integration";
            area.Weight = 4;
            area.Color = "cyan";
            area.IconName = "cloud";
            areas.Add(area);

            //Area 5
            area = new Area();
            area.Id = Guid.NewGuid();
            area.Name = "customer-loyalty";
            area.Label = "Loyalty";
            area.Weight = 5;
            area.Color = "purple";
            area.IconName = "trophy";
            areas.Add(area);


            //Area 6
            //area = new Area();
            //area.Id = Guid.NewGuid();
            //area.Name = "administration";
            //area.Label = "Administration";
            //area.Weight = 99;
            //area.Color = "red";
            //area.IconName = "gear";
            //areas.Add(area);


            Thread.Sleep(500);
            response.Object = areas;
            return Json(response);
        }


        // GET: api/site/meta
        [AcceptVerbs(new[] { "GET" }, Route = "api/root/get-ui-template/{name}")]
        public IActionResult GetUiTemplate(string name)
        {
            //TODO - Test data
            var response = new ResponseObj();
            response.Success = true;
            var html = "";

            switch (name)
            {
                case "layout-0":
                    html = "<div ui-view></div>";
                    break;
                case "layout-1":
                    html = "<div id='wrapper'><div id='content'><div id='page-content' ui-view='contentView'></div></div></div>";
                    break;
                case "layout-2":
                    html = "<div id='wrapper'><div id='sidebar' class='hidden-xs' ui-view='sidebarView'></div><div id='content'><div id='page-content' ui-view='contentView'></div></div></div>";
                    break;
                default:
                    html = "<div id='wrapper'><div id='content'><div id='page-content' ui-view='contentView'></div></div></div>";
                    break;
            }

            return Content(html, "text/xml");
        }
    }
}
