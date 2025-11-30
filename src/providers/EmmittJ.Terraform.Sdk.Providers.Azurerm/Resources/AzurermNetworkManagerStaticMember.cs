using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerStaticMember.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerStaticMemberTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_manager_static_member Terraform resource.
/// Manages a azurerm_network_manager_static_member resource.
/// </summary>
public partial class AzurermNetworkManagerStaticMember(string name) : TerraformResource("azurerm_network_manager_static_member", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    public required TerraformValue<string> NetworkGroupId
    {
        get => new TerraformReference<string>(this, "network_group_id");
        set => SetArgument("network_group_id", value);
    }

    /// <summary>
    /// The target_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVirtualNetworkId is required")]
    public required TerraformValue<string> TargetVirtualNetworkId
    {
        get => new TerraformReference<string>(this, "target_virtual_network_id");
        set => SetArgument("target_virtual_network_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerStaticMemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerStaticMemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
