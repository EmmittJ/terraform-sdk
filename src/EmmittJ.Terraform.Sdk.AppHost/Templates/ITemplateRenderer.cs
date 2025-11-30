namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Renders templates with data to produce output strings.
/// </summary>
public interface ITemplateRenderer
{
    /// <summary>
    /// Renders a template file with the provided data.
    /// </summary>
    /// <param name="templateName">The name of the template file to render.</param>
    /// <param name="data">The data to use when rendering the template.</param>
    /// <returns>The rendered template output.</returns>
    string Render(string templateName, object data);

    /// <summary>
    /// Renders template content directly with the provided data.
    /// </summary>
    /// <param name="templateContent">The template content to render.</param>
    /// <param name="data">The data to use when rendering the template.</param>
    /// <returns>The rendered template output.</returns>
    string RenderContent(string templateContent, object data);
}
