﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.DynamicModules.Builder.Model;

namespace Telerik.Sitefinity.Frontend.DynamicContent.WidgetTemplates.Fields.Impl
{
    /// <summary>
    /// This class represents field generation strategy for address dynamic fields.
    /// </summary>
    public class AddressField : Field
    {
        /// <inheritdoc/>
        public override bool GetCondition(DynamicModuleField field)
        {
            var condition = base.GetCondition(field)
                && field.FieldType == FieldType.Address;

            return condition;
        }

        /// <inheritdoc/>
        protected override string GetTemplatePath(DynamicModuleField field)
        {
            return AddressField.TemplatePath;
        }

        private const string TemplatePath = "~/Frontend-Assembly/Telerik.Sitefinity.Frontend.DynamicContent/WidgetTemplates/Fields/Templates/AddressField.cshtml";
    }
}
