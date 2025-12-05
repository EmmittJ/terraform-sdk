using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermChaosStudioCapability.
/// Nesting mode: single
/// </summary>
public class AzurermChaosStudioCapabilityTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_chaos_studio_capability Terraform resource.
/// Manages a azurerm_chaos_studio_capability resource.
/// </summary>
public partial class AzurermChaosStudioCapability(string name) : TerraformResource("azurerm_chaos_studio_capability", name)
{
    /// <summary>
    /// The capability_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityType is required")]
    public required TerraformValue<string> CapabilityType
    {
        get => GetRequiredArgument<TerraformValue<string>>("capability_type");
        set => SetArgument("capability_type", value);
    }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetId is required")]
    public required TerraformValue<string> ChaosStudioTargetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("chaos_studio_target_id");
        set => SetArgument("chaos_studio_target_id", value);
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
    /// The urn attribute.
    /// </summary>
    public TerraformValue<string> Urn
        => CreateReference("urn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermChaosStudioCapabilityTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermChaosStudioCapabilityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
