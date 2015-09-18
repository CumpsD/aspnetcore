// <auto-generated />
namespace Microsoft.AspNet.Razor.Runtime
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Razor.Runtime.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Invalid tag helper directive look up text '{0}'. The correct look up text format is: "typeName, assemblyName".
        /// </summary>
        internal static string TagHelperDescriptorResolver_InvalidTagHelperLookupText
        {
            get { return GetString("TagHelperDescriptorResolver_InvalidTagHelperLookupText"); }
        }

        /// <summary>
        /// Invalid tag helper directive look up text '{0}'. The correct look up text format is: "typeName, assemblyName".
        /// </summary>
        internal static string FormatTagHelperDescriptorResolver_InvalidTagHelperLookupText(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorResolver_InvalidTagHelperLookupText"), p0);
        }

        /// <summary>
        /// Cannot resolve TagHelper containing assembly '{0}'. Error: {1}
        /// </summary>
        internal static string TagHelperTypeResolver_CannotResolveTagHelperAssembly
        {
            get { return GetString("TagHelperTypeResolver_CannotResolveTagHelperAssembly"); }
        }

        /// <summary>
        /// Cannot resolve TagHelper containing assembly '{0}'. Error: {1}
        /// </summary>
        internal static string FormatTagHelperTypeResolver_CannotResolveTagHelperAssembly(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperTypeResolver_CannotResolveTagHelperAssembly"), p0, p1);
        }

        /// <summary>
        /// Tag helper directive assembly name cannot be null or empty.
        /// </summary>
        internal static string TagHelperTypeResolver_TagHelperAssemblyNameCannotBeEmptyOrNull
        {
            get { return GetString("TagHelperTypeResolver_TagHelperAssemblyNameCannotBeEmptyOrNull"); }
        }

        /// <summary>
        /// Tag helper directive assembly name cannot be null or empty.
        /// </summary>
        internal static string FormatTagHelperTypeResolver_TagHelperAssemblyNameCannotBeEmptyOrNull()
        {
            return GetString("TagHelperTypeResolver_TagHelperAssemblyNameCannotBeEmptyOrNull");
        }

        /// <summary>
        /// Must call '{2}.{1}' before calling '{2}.{0}'.
        /// </summary>
        internal static string ScopeManager_EndCannotBeCalledWithoutACallToBegin
        {
            get { return GetString("ScopeManager_EndCannotBeCalledWithoutACallToBegin"); }
        }

        /// <summary>
        /// Must call '{2}.{1}' before calling '{2}.{0}'.
        /// </summary>
        internal static string FormatScopeManager_EndCannotBeCalledWithoutACallToBegin(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ScopeManager_EndCannotBeCalledWithoutACallToBegin"), p0, p1, p2);
        }

        /// <summary>
        /// {0} name cannot be null or whitespace.
        /// </summary>
        internal static string HtmlTargetElementAttribute_NameCannotBeNullOrWhitespace
        {
            get { return GetString("HtmlTargetElementAttribute_NameCannotBeNullOrWhitespace"); }
        }

        /// <summary>
        /// {0} name cannot be null or whitespace.
        /// </summary>
        internal static string FormatHtmlTargetElementAttribute_NameCannotBeNullOrWhitespace(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("HtmlTargetElementAttribute_NameCannotBeNullOrWhitespace"), p0);
        }

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
        {
            return GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// Encountered an unexpected error when attempting to resolve tag helper directive '{0}' with value '{1}'. Error: {2}
        /// </summary>
        internal static string TagHelperDescriptorResolver_EncounteredUnexpectedError
        {
            get { return GetString("TagHelperDescriptorResolver_EncounteredUnexpectedError"); }
        }

        /// <summary>
        /// Encountered an unexpected error when attempting to resolve tag helper directive '{0}' with value '{1}'. Error: {2}
        /// </summary>
        internal static string FormatTagHelperDescriptorResolver_EncounteredUnexpectedError(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorResolver_EncounteredUnexpectedError"), p0, p1, p2);
        }

        /// <summary>
        /// Tag helpers cannot target {0} name '{1}' because it contains a '{2}' character.
        /// </summary>
        internal static string HtmlTargetElementAttribute_InvalidName
        {
            get { return GetString("HtmlTargetElementAttribute_InvalidName"); }
        }

        /// <summary>
        /// Tag helpers cannot target {0} name '{1}' because it contains a '{2}' character.
        /// </summary>
        internal static string FormatHtmlTargetElementAttribute_InvalidName(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("HtmlTargetElementAttribute_InvalidName"), p0, p1, p2);
        }

        /// <summary>
        /// Invalid tag helper directive '{0}'. Cannot have multiple '{0}' directives on a page.
        /// </summary>
        internal static string TagHelperDescriptorResolver_InvalidTagHelperDirective
        {
            get { return GetString("TagHelperDescriptorResolver_InvalidTagHelperDirective"); }
        }

        /// <summary>
        /// Invalid tag helper directive '{0}'. Cannot have multiple '{0}' directives on a page.
        /// </summary>
        internal static string FormatTagHelperDescriptorResolver_InvalidTagHelperDirective(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorResolver_InvalidTagHelperDirective"), p0);
        }

        /// <summary>
        /// Invalid tag helper directive '{0}' value. '{1}' is not allowed in prefix '{2}'.
        /// </summary>
        internal static string TagHelperDescriptorResolver_InvalidTagHelperPrefixValue
        {
            get { return GetString("TagHelperDescriptorResolver_InvalidTagHelperPrefixValue"); }
        }

        /// <summary>
        /// Invalid tag helper directive '{0}' value. '{1}' is not allowed in prefix '{2}'.
        /// </summary>
        internal static string FormatTagHelperDescriptorResolver_InvalidTagHelperPrefixValue(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorResolver_InvalidTagHelperPrefixValue"), p0, p1, p2);
        }

        /// <summary>
        /// Attribute
        /// </summary>
        internal static string TagHelperDescriptorFactory_Attribute
        {
            get { return GetString("TagHelperDescriptorFactory_Attribute"); }
        }

        /// <summary>
        /// Attribute
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_Attribute()
        {
            return GetString("TagHelperDescriptorFactory_Attribute");
        }

        /// <summary>
        /// name
        /// </summary>
        internal static string TagHelperDescriptorFactory_Name
        {
            get { return GetString("TagHelperDescriptorFactory_Name"); }
        }

        /// <summary>
        /// name
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_Name()
        {
            return GetString("TagHelperDescriptorFactory_Name");
        }

        /// <summary>
        /// prefix
        /// </summary>
        internal static string TagHelperDescriptorFactory_Prefix
        {
            get { return GetString("TagHelperDescriptorFactory_Prefix"); }
        }

        /// <summary>
        /// prefix
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_Prefix()
        {
            return GetString("TagHelperDescriptorFactory_Prefix");
        }

        /// <summary>
        /// Tag
        /// </summary>
        internal static string TagHelperDescriptorFactory_Tag
        {
            get { return GetString("TagHelperDescriptorFactory_Tag"); }
        }

        /// <summary>
        /// Tag
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_Tag()
        {
            return GetString("TagHelperDescriptorFactory_Tag");
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. An '{2}' must not be associated with a property with no public setter unless its type implements '{3}'.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributeNameAttribute
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributeNameAttribute"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. An '{2}' must not be associated with a property with no public setter unless its type implements '{3}'.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributeNameAttribute(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributeNameAttribute"), p0, p1, p2, p3);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with {2} '{3}' because {2} contains a '{4}' character.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixCharacter
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixCharacter"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with {2} '{3}' because {2} contains a '{4}' character.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributeNameOrPrefixCharacter(object p0, object p1, object p2, object p3, object p4)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixCharacter"), p0, p1, p2, p3, p4);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with {2} '{3}' because {2} starts with '{4}'.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixStart
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixStart"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with {2} '{3}' because {2} starts with '{4}'.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributeNameOrPrefixStart(object p0, object p1, object p2, object p3, object p4)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixStart"), p0, p1, p2, p3, p4);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with a whitespace {2}.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixWhitespace
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixWhitespace"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with a whitespace {2}.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributeNameOrPrefixWhitespace(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributeNameOrPrefixWhitespace"), p0, p1, p2);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with a null or empty name.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributeNameNullOrEmpty
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributeNameNullOrEmpty"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. Tag helpers cannot bind to HTML attributes with a null or empty name.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributeNameNullOrEmpty(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributeNameNullOrEmpty"), p0, p1);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. '{2}.{3}' must be null or empty if property has no public setter.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributeNameNotNullOrEmpty
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributeNameNotNullOrEmpty"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. '{2}.{3}' must be null or empty if property has no public setter.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributeNameNotNullOrEmpty(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributeNameNotNullOrEmpty"), p0, p1, p2, p3);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. '{2}.{3}' must not be null if property has no public setter and its type implements '{4}'.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributePrefixNull
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributePrefixNull"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. '{2}.{3}' must not be null if property has no public setter and its type implements '{4}'.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributePrefixNull(object p0, object p1, object p2, object p3, object p4)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributePrefixNull"), p0, p1, p2, p3, p4);
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. '{2}.{3}' must be null unless property type implements '{4}'.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidAttributePrefixNotNull
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidAttributePrefixNotNull"); }
        }

        /// <summary>
        /// Invalid tag helper bound property '{0}.{1}'. '{2}.{3}' must be null unless property type implements '{4}'.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidAttributePrefixNotNull(object p0, object p1, object p2, object p3, object p4)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidAttributePrefixNotNull"), p0, p1, p2, p3, p4);
        }

        /// <summary>
        /// Cannot add a '{0}' with a null '{1}'.
        /// </summary>
        internal static string TagHelperAttributeList_CannotAddWithNullName
        {
            get { return GetString("TagHelperAttributeList_CannotAddWithNullName"); }
        }

        /// <summary>
        /// Cannot add a '{0}' with a null '{1}'.
        /// </summary>
        internal static string FormatTagHelperAttributeList_CannotAddWithNullName(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperAttributeList_CannotAddWithNullName"), p0, p1);
        }

        /// <summary>
        /// Cannot add a {0} with inconsistent names. The {1} property '{2}' must match the location '{3}'.
        /// </summary>
        internal static string TagHelperAttributeList_CannotAddAttribute
        {
            get { return GetString("TagHelperAttributeList_CannotAddAttribute"); }
        }

        /// <summary>
        /// Cannot add a {0} with inconsistent names. The {1} property '{2}' must match the location '{3}'.
        /// </summary>
        internal static string FormatTagHelperAttributeList_CannotAddAttribute(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperAttributeList_CannotAddAttribute"), p0, p1, p2, p3);
        }

        /// <summary>
        /// Invalid '{0}' tag name '{1}' for tag helper '{2}'. Tag helpers cannot restrict child elements that contain a '{3}' character.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidRestrictChildrenAttributeName
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidRestrictChildrenAttributeName"); }
        }

        /// <summary>
        /// Invalid '{0}' tag name '{1}' for tag helper '{2}'. Tag helpers cannot restrict child elements that contain a '{3}' character.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidRestrictChildrenAttributeName(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidRestrictChildrenAttributeName"), p0, p1, p2, p3);
        }

        /// <summary>
        /// Invalid '{0}' tag name for tag helper '{1}'. Name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelperDescriptorFactory_InvalidRestrictChildrenAttributeNameNullWhitespace
        {
            get { return GetString("TagHelperDescriptorFactory_InvalidRestrictChildrenAttributeNameNullWhitespace"); }
        }

        /// <summary>
        /// Invalid '{0}' tag name for tag helper '{1}'. Name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelperDescriptorFactory_InvalidRestrictChildrenAttributeNameNullWhitespace(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TagHelperDescriptorFactory_InvalidRestrictChildrenAttributeNameNullWhitespace"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
