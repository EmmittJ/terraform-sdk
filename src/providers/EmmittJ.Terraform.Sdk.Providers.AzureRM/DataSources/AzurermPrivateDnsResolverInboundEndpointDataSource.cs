using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsResolverInboundEndpointDataSourceTimeoutsBlock : TerraformBlock
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
        this.WithOutput("ip_configurations");
        this.WithOutput("location");
        this.WithOutput("tags");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_dns_resolver_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsResolverId is required")]
    public required TerraformProperty<string> PrivateDnsResolverId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_dns_resolver_id");
        set => this.WithProperty("private_dns_resolver_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsResolverInboundEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPrivateDnsResolverInboundEndpointDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
