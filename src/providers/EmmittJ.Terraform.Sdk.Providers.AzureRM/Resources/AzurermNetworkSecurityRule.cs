using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DestinationAddressPrefix
    {
        get => new TerraformReference<string>(this, "destination_address_prefix");
        set => SetArgument("destination_address_prefix", value);
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? DestinationAddressPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_address_prefixes").ResolveNodes(ctx));
        set => SetArgument("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? DestinationApplicationSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("destination_application_security_group_ids", value);
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    public TerraformValue<string>? DestinationPortRange
    {
        get => new TerraformReference<string>(this, "destination_port_range");
        set => SetArgument("destination_port_range", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    public TerraformSet<string>? DestinationPortRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_port_ranges").ResolveNodes(ctx));
        set => SetArgument("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => new TerraformReference<string>(this, "direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    public required TerraformValue<string> NetworkSecurityGroupName
    {
        get => new TerraformReference<string>(this, "network_security_group_name");
        set => SetArgument("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? SourceAddressPrefix
    {
        get => new TerraformReference<string>(this, "source_address_prefix");
        set => SetArgument("source_address_prefix", value);
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? SourceAddressPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_address_prefixes").ResolveNodes(ctx));
        set => SetArgument("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SourceApplicationSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("source_application_security_group_ids", value);
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    public TerraformValue<string>? SourcePortRange
    {
        get => new TerraformReference<string>(this, "source_port_range");
        set => SetArgument("source_port_range", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public TerraformSet<string>? SourcePortRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_port_ranges").ResolveNodes(ctx));
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
