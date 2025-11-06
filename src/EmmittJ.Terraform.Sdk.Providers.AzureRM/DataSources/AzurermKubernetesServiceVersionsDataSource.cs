using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_kubernetes_service_versions.
/// </summary>
public class AzurermKubernetesServiceVersionsDataSource : TerraformDataSource
{
    public AzurermKubernetesServiceVersionsDataSource(string name) : base("azurerm_kubernetes_service_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_version");
        this.DeclareOutput("latest_version");
        this.DeclareOutput("versions");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    public bool? IncludePreview
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_preview")?.Value;
        set => this.WithProperty("include_preview", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public string? VersionPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_prefix")?.Value;
        set => this.WithProperty("version_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformExpression DefaultVersion => this["default_version"];

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformExpression LatestVersion => this["latest_version"];

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformExpression Versions => this["versions"];

}
