using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_private_dns_zone_virtual_network_link.
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSource(string name) : base("azurerm_private_dns_zone_virtual_network_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("registration_enabled");
        this.DeclareOutput("resolution_policy");
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_network_id");
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
    /// The private_dns_zone_name attribute.
    /// </summary>
    public string? PrivateDnsZoneName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_dns_zone_name")?.Value;
        set => this.WithProperty("private_dns_zone_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The registration_enabled attribute.
    /// </summary>
    public TerraformExpression RegistrationEnabled => this["registration_enabled"];

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public TerraformExpression ResolutionPolicy => this["resolution_policy"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

}
