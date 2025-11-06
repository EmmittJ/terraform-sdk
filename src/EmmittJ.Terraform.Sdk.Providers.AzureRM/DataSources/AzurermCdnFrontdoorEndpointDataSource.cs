using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_endpoint.
/// </summary>
public class AzurermCdnFrontdoorEndpointDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorEndpointDataSource(string name) : base("azurerm_cdn_frontdoor_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("enabled");
        this.DeclareOutput("host_name");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public string? ProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_name")?.Value;
        set => this.WithProperty("profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformExpression HostName => this["host_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
