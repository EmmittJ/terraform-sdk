using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkInterfaceNatRuleAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceNatRuleAssociationTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_network_interface_nat_rule_association Terraform resource.
/// Manages a azurerm_network_interface_nat_rule_association resource.
/// </summary>
public partial class AzurermNetworkInterfaceNatRuleAssociation(string name) : TerraformResource("azurerm_network_interface_nat_rule_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurationName is required")]
    public required TerraformValue<string> IpConfigurationName
    {
        get => new TerraformReference<string>(this, "ip_configuration_name");
        set => SetArgument("ip_configuration_name", value);
    }

    /// <summary>
    /// The nat_rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatRuleId is required")]
    public required TerraformValue<string> NatRuleId
    {
        get => new TerraformReference<string>(this, "nat_rule_id");
        set => SetArgument("nat_rule_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkInterfaceNatRuleAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkInterfaceNatRuleAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
