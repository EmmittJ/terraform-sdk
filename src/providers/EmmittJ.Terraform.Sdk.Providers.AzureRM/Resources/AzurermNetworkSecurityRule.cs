using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkSecurityRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformProperty<string> Access
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access");
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
    public HashSet<TerraformProperty<string>>? DestinationAddressPrefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destination_address_prefixes");
        set => this.WithProperty("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DestinationApplicationSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destination_application_security_group_ids");
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
    public HashSet<TerraformProperty<string>>? DestinationPortRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destination_port_ranges");
        set => this.WithProperty("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformProperty<string> Direction
    {
        get => GetRequiredProperty<TerraformProperty<string>>("direction");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    public required TerraformProperty<string> NetworkSecurityGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network_security_group_name");
        set => this.WithProperty("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
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
    public HashSet<TerraformProperty<string>>? SourceAddressPrefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_address_prefixes");
        set => this.WithProperty("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SourceApplicationSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_application_security_group_ids");
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
    public HashSet<TerraformProperty<string>>? SourcePortRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_port_ranges");
        set => this.WithProperty("source_port_ranges", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkSecurityRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkSecurityRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
