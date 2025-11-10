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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("access");
        SetOutput("description");
        SetOutput("destination_address_prefix");
        SetOutput("destination_address_prefixes");
        SetOutput("destination_application_security_group_ids");
        SetOutput("destination_port_range");
        SetOutput("destination_port_ranges");
        SetOutput("direction");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network_security_group_name");
        SetOutput("priority");
        SetOutput("protocol");
        SetOutput("resource_group_name");
        SetOutput("source_address_prefix");
        SetOutput("source_address_prefixes");
        SetOutput("source_application_security_group_ids");
        SetOutput("source_port_range");
        SetOutput("source_port_ranges");
    }

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformProperty<string> Access
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access");
        set => SetProperty("access", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string> DestinationAddressPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_address_prefix");
        set => SetProperty("destination_address_prefix", value);
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DestinationAddressPrefixes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("destination_address_prefixes");
        set => SetProperty("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DestinationApplicationSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("destination_application_security_group_ids");
        set => SetProperty("destination_application_security_group_ids", value);
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    public TerraformProperty<string> DestinationPortRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_port_range");
        set => SetProperty("destination_port_range", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DestinationPortRanges
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("destination_port_ranges");
        set => SetProperty("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformProperty<string> Direction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("direction");
        set => SetProperty("direction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    public required TerraformProperty<string> NetworkSecurityGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_security_group_name");
        set => SetProperty("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string> SourceAddressPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_address_prefix");
        set => SetProperty("source_address_prefix", value);
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SourceAddressPrefixes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("source_address_prefixes");
        set => SetProperty("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SourceApplicationSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("source_application_security_group_ids");
        set => SetProperty("source_application_security_group_ids", value);
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    public TerraformProperty<string> SourcePortRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_port_range");
        set => SetProperty("source_port_range", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SourcePortRanges
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("source_port_ranges");
        set => SetProperty("source_port_ranges", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkSecurityRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
