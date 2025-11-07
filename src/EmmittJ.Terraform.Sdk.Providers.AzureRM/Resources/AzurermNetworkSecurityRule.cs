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
    public TerraformProperty<string>? Access
    {
        get => GetProperty<TerraformProperty<string>>("access");
        set => this.WithProperty("access", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("destination_address_prefix");
        set => this.WithProperty("destination_address_prefix", value);
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DestinationAddressPrefixes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("destination_address_prefixes");
        set => this.WithProperty("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DestinationApplicationSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("destination_application_security_group_ids");
        set => this.WithProperty("destination_application_security_group_ids", value);
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationPortRange
    {
        get => GetProperty<TerraformProperty<string>>("destination_port_range");
        set => this.WithProperty("destination_port_range", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DestinationPortRanges
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("destination_port_ranges");
        set => this.WithProperty("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    public TerraformProperty<string>? Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => this.WithProperty("direction", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupName
    {
        get => GetProperty<TerraformProperty<string>>("network_security_group_name");
        set => this.WithProperty("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The source_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("source_address_prefix");
        set => this.WithProperty("source_address_prefix", value);
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SourceAddressPrefixes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("source_address_prefixes");
        set => this.WithProperty("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SourceApplicationSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("source_application_security_group_ids");
        set => this.WithProperty("source_application_security_group_ids", value);
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    public TerraformProperty<string>? SourcePortRange
    {
        get => GetProperty<TerraformProperty<string>>("source_port_range");
        set => this.WithProperty("source_port_range", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SourcePortRanges
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("source_port_ranges");
        set => this.WithProperty("source_port_ranges", value);
    }

}
