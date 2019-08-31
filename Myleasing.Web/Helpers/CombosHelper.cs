﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Myleasing.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myleasing.Web.Helpers
{
    public class CombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboPropertyType()
        {
            var List = _dataContext.PropertyTypes.Select(pt => new SelectListItem
            {
                Text  = pt.Name,
                Value = $"{ pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            List.Insert(0, new SelectListItem
            {
                Text="(Select a property type...)",
                Value="0"
            });
            return List;

        }
    }
}
