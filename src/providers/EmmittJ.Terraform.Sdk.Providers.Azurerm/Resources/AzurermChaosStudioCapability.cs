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
        get => new TerraformReference<string>(this, "capability_type");
        set => SetArgument("capability_type", value);
    }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetId is required")]
    public required TerraformValue<string> ChaosStudioTargetId
    {
        get => new TerraformReference<string>(this, "chaos_studio_target_id");
        set => SetArgument("chaos_studio_target_id", value);
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
    /// The urn attribute.
    /// </summary>
    public TerraformValue<string> Urn
    {
        get => new TerraformReference<string>(this, "urn");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermChaosStudioCapabilityTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermChaosStudioCapabilityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
