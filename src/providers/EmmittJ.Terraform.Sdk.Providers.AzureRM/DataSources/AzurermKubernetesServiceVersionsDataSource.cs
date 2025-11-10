using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("default_version");
        this.WithOutput("latest_version");
        this.WithOutput("versions");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePreview
    {
        get => GetProperty<TerraformProperty<bool>>("include_preview");
        set => this.WithProperty("include_preview", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? VersionPrefix
    {
        get => GetProperty<TerraformProperty<string>>("version_prefix");
        set => this.WithProperty("version_prefix", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
