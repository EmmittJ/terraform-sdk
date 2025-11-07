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
    public TerraformLiteralProperty<string>? Access
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access");
        set => this.WithProperty("access", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationAddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_address_prefix");
        set => this.WithProperty("destination_address_prefix", value);
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DestinationAddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_address_prefixes");
        set => this.WithProperty("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DestinationApplicationSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_application_security_group_ids");
        set => this.WithProperty("destination_application_security_group_ids", value);
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationPortRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_port_range");
        set => this.WithProperty("destination_port_range", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DestinationPortRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_port_ranges");
        set => this.WithProperty("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Direction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direction");
        set => this.WithProperty("direction", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkSecurityGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_security_group_name");
        set => this.WithProperty("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceAddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_address_prefix");
        set => this.WithProperty("source_address_prefix", value);
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SourceAddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_address_prefixes");
        set => this.WithProperty("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SourceApplicationSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_application_security_group_ids");
        set => this.WithProperty("source_application_security_group_ids", value);
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourcePortRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_port_range");
        set => this.WithProperty("source_port_range", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SourcePortRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_port_ranges");
        set => this.WithProperty("source_port_ranges", value);
    }

}
