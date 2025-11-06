using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_security_rule resource.
/// </summary>
public class AzurermNetworkSecurityRule : TerraformResource
{
    public AzurermNetworkSecurityRule(string name) : base("azurerm_network_security_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access attribute.
    /// </summary>
    public string? Access
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access")?.Value;
        set => this.WithProperty("access", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    public string? DestinationAddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_address_prefix")?.Value;
        set => this.WithProperty("destination_address_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    public HashSet<string>? DestinationAddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_address_prefixes")?.Value;
        set => this.WithProperty("destination_address_prefixes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? DestinationApplicationSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_application_security_group_ids")?.Value;
        set => this.WithProperty("destination_application_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    public string? DestinationPortRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_port_range")?.Value;
        set => this.WithProperty("destination_port_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public HashSet<string>? DestinationPortRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_port_ranges")?.Value;
        set => this.WithProperty("destination_port_ranges", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public string? Direction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direction")?.Value;
        set => this.WithProperty("direction", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_security_group_name attribute.
    /// </summary>
    public string? NetworkSecurityGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_security_group_name")?.Value;
        set => this.WithProperty("network_security_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The source_address_prefix attribute.
    /// </summary>
    public string? SourceAddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_address_prefix")?.Value;
        set => this.WithProperty("source_address_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    public HashSet<string>? SourceAddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_address_prefixes")?.Value;
        set => this.WithProperty("source_address_prefixes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SourceApplicationSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_application_security_group_ids")?.Value;
        set => this.WithProperty("source_application_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    public string? SourcePortRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_port_range")?.Value;
        set => this.WithProperty("source_port_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public HashSet<string>? SourcePortRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_port_ranges")?.Value;
        set => this.WithProperty("source_port_ranges", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
