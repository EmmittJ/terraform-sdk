using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_endpoint resource.
/// </summary>
public class AzurermPrivateEndpoint : TerraformResource
{
    public AzurermPrivateEndpoint(string name) : base("azurerm_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_dns_configs");
        this.DeclareOutput("network_interface");
        this.DeclareOutput("private_dns_zone_configs");
    }

    /// <summary>
    /// The custom_network_interface_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomNetworkInterfaceName
    {
        get => GetProperty<TerraformProperty<string>>("custom_network_interface_name");
        set => this.WithProperty("custom_network_interface_name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The custom_dns_configs attribute.
    /// </summary>
    public TerraformExpression CustomDnsConfigs => this["custom_dns_configs"];

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformExpression NetworkInterface => this["network_interface"];

    /// <summary>
    /// The private_dns_zone_configs attribute.
    /// </summary>
    public TerraformExpression PrivateDnsZoneConfigs => this["private_dns_zone_configs"];

}
