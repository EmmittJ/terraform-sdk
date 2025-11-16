using Stubble.Core;
using Stubble.Core.Builders;

namespace EmmittJ.Terraform.Sdk.AppHost.Templates;

/// <summary>
/// Base class for Mustache template rendering with caching and optional partial support.
/// </summary>
public abstract class BaseTemplate
{
    private static StubbleVisitorRenderer? _rendererWithPartials;
    private static StubbleVisitorRenderer? _rendererWithoutPartials;
    private static Dictionary<string, string>? _partials;
    private static string? _templateDirectory;

    private readonly string _templatePath;
    private string? _templateCache;
    private readonly bool _usePartials;

    /// <summary>
    /// Initializes a new instance of the template.
    /// </summary>
    /// <param name="templatePath">The full path to the template file.</param>
    /// <param name="usePartials">Whether to load and support partial templates (_*.mustache).</param>
    protected BaseTemplate(string templatePath, bool usePartials = false)
    {
        _templatePath = templatePath;
        _usePartials = usePartials;
    }

    /// <summary>
    /// Gets the Stubble renderer, loading partials if needed.
    /// </summary>
    protected StubbleVisitorRenderer GetRenderer()
    {
        if (_usePartials)
        {
            if (_rendererWithPartials == null)
            {
                var templateDirectory = Path.GetDirectoryName(_templatePath)
                    ?? throw new InvalidOperationException("Template path has no directory");

                // Load all partial templates if not already loaded or directory changed
                if (_partials == null || _templateDirectory != templateDirectory)
                {
                    _templateDirectory = templateDirectory;
                    _partials = new Dictionary<string, string>();

                    foreach (var partialFile in Directory.GetFiles(templateDirectory, "_*.mustache"))
                    {
                        var partialName = Path.GetFileNameWithoutExtension(partialFile);
                        _partials[partialName] = File.ReadAllText(partialFile);
                    }
                }

                _rendererWithPartials = new StubbleBuilder()
                    .Configure(settings =>
                    {
                        settings.SetPartialTemplateLoader(new Stubble.Core.Loaders.DictionaryLoader(_partials));
                    })
                    .Build();
            }
            return _rendererWithPartials;
        }
        else
        {
            _rendererWithoutPartials ??= new StubbleBuilder().Build();
            return _rendererWithoutPartials;
        }
    }

    /// <summary>
    /// Loads and caches the template content.
    /// </summary>
    protected string LoadTemplate()
    {
        _templateCache ??= File.ReadAllText(_templatePath);
        return _templateCache;
    }

    /// <summary>
    /// Renders the template with the provided data.
    /// </summary>
    /// <param name="data">The data object to render.</param>
    /// <returns>The rendered template string.</returns>
    public virtual string Render(object data)
    {
        var template = LoadTemplate();
        var renderer = GetRenderer();
        return renderer.Render(template, data);
    }
}
