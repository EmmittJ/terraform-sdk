using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_azure_versions.
/// </summary>
public class GoogleContainerAzureVersionsDataSource : TerraformDataSource
{
    public GoogleContainerAzureVersionsDataSource(string name) : base("google_container_azure_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("supported_regions");
        this.DeclareOutput("valid_versions");
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public TerraformExpression SupportedRegions => this["supported_regions"];

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    public TerraformExpression ValidVersions => this["valid_versions"];

}
