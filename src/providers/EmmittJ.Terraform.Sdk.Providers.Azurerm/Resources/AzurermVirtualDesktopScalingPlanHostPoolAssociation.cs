using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualDesktopScalingPlanHostPoolAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopScalingPlanHostPoolAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_desktop_scaling_plan_host_pool_association Terraform resource.
/// Manages a azurerm_virtual_desktop_scaling_plan_host_pool_association resource.
/// </summary>
public partial class AzurermVirtualDesktopScalingPlanHostPoolAssociation(string name) : TerraformResource("azurerm_virtual_desktop_scaling_plan_host_pool_association", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The host_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostPoolId is required")]
    public required TerraformValue<string> HostPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_pool_id");
        set => SetArgument("host_pool_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The scaling_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingPlanId is required")]
    public required TerraformValue<string> ScalingPlanId
    {
        get => GetRequiredArgument<TerraformValue<string>>("scaling_plan_id");
        set => SetArgument("scaling_plan_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopScalingPlanHostPoolAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopScalingPlanHostPoolAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
