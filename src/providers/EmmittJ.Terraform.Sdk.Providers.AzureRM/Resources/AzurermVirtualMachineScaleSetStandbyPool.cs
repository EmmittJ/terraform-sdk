using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for elasticity_profile in AzurermVirtualMachineScaleSetStandbyPool.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elasticity_profile";

    /// <summary>
    /// The max_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReadyCapacity is required")]
    public required TerraformValue<double> MaxReadyCapacity
    {
        get => new TerraformReference<double>(this, "max_ready_capacity");
        set => SetArgument("max_ready_capacity", value);
    }

    /// <summary>
    /// The min_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReadyCapacity is required")]
    public required TerraformValue<double> MinReadyCapacity
    {
        get => new TerraformReference<double>(this, "min_ready_capacity");
        set => SetArgument("min_ready_capacity", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualMachineScaleSetStandbyPool.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_machine_scale_set_standby_pool Terraform resource.
/// Manages a azurerm_virtual_machine_scale_set_standby_pool resource.
/// </summary>
public partial class AzurermVirtualMachineScaleSetStandbyPool(string name) : TerraformResource("azurerm_virtual_machine_scale_set_standby_pool", name)
{
    /// <summary>
    /// The attached_virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedVirtualMachineScaleSetId is required")]
    public required TerraformValue<string> AttachedVirtualMachineScaleSetId
    {
        get => new TerraformReference<string>(this, "attached_virtual_machine_scale_set_id");
        set => SetArgument("attached_virtual_machine_scale_set_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_machine_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineState is required")]
    public required TerraformValue<string> VirtualMachineState
    {
        get => new TerraformReference<string>(this, "virtual_machine_state");
        set => SetArgument("virtual_machine_state", value);
    }

    /// <summary>
    /// ElasticityProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticityProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ElasticityProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticityProfile block(s) allowed")]
    public required TerraformList<AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock> ElasticityProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock>>("elasticity_profile");
        set => SetArgument("elasticity_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
