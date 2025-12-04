using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermChaosStudioTarget.
/// Nesting mode: single
/// </summary>
public class AzurermChaosStudioTargetTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_chaos_studio_target Terraform resource.
/// Manages a azurerm_chaos_studio_target resource.
/// </summary>
public partial class AzurermChaosStudioTarget(string name) : TerraformResource("azurerm_chaos_studio_target", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => GetArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetType is required")]
    public required TerraformValue<string> TargetType
    {
        get => GetArgument<TerraformValue<string>>("target_type");
        set => SetArgument("target_type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermChaosStudioTargetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermChaosStudioTargetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
