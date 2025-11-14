using Stubble.Core;
using Stubble.Core.Builders;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Mustache template renderer implementation.
/// </summary>
public class MustacheTemplateRenderer : ITemplateRenderer
{
    private readonly StubbleVisitorRenderer _renderer;
    private readonly TerraformCodeGenOptions _options;
    private readonly IFileSystem _fileSystem;

    public MustacheTemplateRenderer(TerraformCodeGenOptions options, IFileSystem fileSystem)
    {
        _options = options;
        _fileSystem = fileSystem;
        _renderer = new StubbleBuilder().Build();
    }

    /// <summary>
    /// Renders a template with the provided data.
    /// </summary>
    public string Render(string templateName, object data)
    {
        // Add .mustache extension if not present
        var templateFileName = templateName.EndsWith(".mustache")
            ? templateName
            : $"{templateName}.mustache";

        var templatePath = Path.Combine(_options.TemplatesDirectory, templateFileName);

        if (!_fileSystem.FileExists(templatePath))
        {
            throw new FileNotFoundException($"Template not found: {templatePath}", templatePath);
        }

        var template = _fileSystem.ReadAllTextAsync(templatePath).GetAwaiter().GetResult();
        return _renderer.Render(template, data);
    }
}
