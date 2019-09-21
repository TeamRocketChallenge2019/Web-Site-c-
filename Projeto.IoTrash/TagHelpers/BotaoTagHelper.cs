﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.IoTrash.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public String Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("value", Texto);
            output.Attributes.SetAttribute("class", "btn btn-primary");
        }
    }
}