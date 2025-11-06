using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_private_dns_resolver_inbound_endpoint.
/// </summary>
public class AzurermPrivateDnsResolverInboundEndpointDataSource : TerraformDataSource
{
    public AzurermPrivateDnsResolverInboundEndpointDataSource(string name) : base("azurerm_private_dns_resolver_inbound_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ip_configurations");
        this.DeclareOutput("location");
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
    /// The private_dns_resolver_id attribute.
    /// </summary>
    public string? PrivateDnsResolverId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_dns_resolver_id")?.Value;
        set => this.WithProperty("private_dns_resolver_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_configurations attribute.
    /// </summary>
    public TerraformExpression IpConfigurations => this["ip_configurations"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
