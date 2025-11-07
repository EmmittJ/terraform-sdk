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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
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
