using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkSecurityRule.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkSecurityRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_network_security_rule Terraform resource.
/// Manages a azurerm_network_security_rule resource.
/// </summary>
public partial class AzurermNetworkSecurityRule(string name) : TerraformResource("azurerm_network_security_rule", name)
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformValue<string> Access
    {
        get => GetRequiredArgument<TerraformValue<string>>("access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DestinationAddressPrefix
    {
        get => GetArgument<TerraformValue<string>>("destination_address_prefix");
        set => SetArgument("destination_address_prefix", value);
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? DestinationAddressPrefixes
    {
        get => GetArgument<TerraformSet<string>>("destination_address_prefixes");
        set => SetArgument("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? DestinationApplicationSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("destination_application_security_group_ids");
        set => SetArgument("destination_application_security_group_ids", value);
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    public TerraformValue<string>? DestinationPortRange
    {
        get => GetArgument<TerraformValue<string>>("destination_port_range");
        set => SetArgument("destination_port_range", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public TerraformSet<string>? DestinationPortRanges
    {
        get => GetArgument<TerraformSet<string>>("destination_port_ranges");
        set => SetArgument("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => GetRequiredArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    public required TerraformValue<string> NetworkSecurityGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_security_group_name");
        set => SetArgument("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? SourceAddressPrefix
    {
        get => GetArgument<TerraformValue<string>>("source_address_prefix");
        set => SetArgument("source_address_prefix", value);
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? SourceAddressPrefixes
    {
        get => GetArgument<TerraformSet<string>>("source_address_prefixes");
        set => SetArgument("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SourceApplicationSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("source_application_security_group_ids");
        set => SetArgument("source_application_security_group_ids", value);
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    public TerraformValue<string>? SourcePortRange
    {
        get => GetArgument<TerraformValue<string>>("source_port_range");
        set => SetArgument("source_port_range", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public TerraformSet<string>? SourcePortRanges
    {
        get => GetArgument<TerraformSet<string>>("source_port_ranges");
        set => SetArgument("source_port_ranges", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkSecurityRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkSecurityRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
