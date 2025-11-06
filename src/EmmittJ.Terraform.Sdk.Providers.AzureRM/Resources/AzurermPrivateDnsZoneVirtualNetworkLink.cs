using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_dns_zone_virtual_network_link resource.
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLink : TerraformResource
{
    public AzurermPrivateDnsZoneVirtualNetworkLink(string name) : base("azurerm_private_dns_zone_virtual_network_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The registration_enabled attribute.
    /// </summary>
    public bool? RegistrationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registration_enabled")?.Value;
        set => this.WithProperty("registration_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public string? ResolutionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolution_policy")?.Value;
        set => this.WithProperty("resolution_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
