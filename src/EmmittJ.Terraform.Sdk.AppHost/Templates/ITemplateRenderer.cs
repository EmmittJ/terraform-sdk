namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Renders templates with data to produce output strings.
/// </summary>
public interface ITemplateRenderer
{
    /// <summary>
    /// Renders a template with the provided data.
    /// </summary>
    string Render(string templateName, object data);
}
