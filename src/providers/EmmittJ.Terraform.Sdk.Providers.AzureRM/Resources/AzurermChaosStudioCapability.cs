using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_chaos_studio_capability resource.
/// </summary>
public class AzurermChaosStudioCapability : TerraformResource
{
    public AzurermChaosStudioCapability(string name) : base("azurerm_chaos_studio_capability", name)
    {
    }

    /// <summary>
    /// The capability_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityType is required")]
    [TerraformArgument("capability_type")]
    public required TerraformValue<string> CapabilityType
    {
        get => new TerraformReference<string>(this, "capability_type");
        set => SetArgument("capability_type", value);
    }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetId is required")]
    [TerraformArgument("chaos_studio_target_id")]
    public required TerraformValue<string> ChaosStudioTargetId
    {
        get => new TerraformReference<string>(this, "chaos_studio_target_id");
        set => SetArgument("chaos_studio_target_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermChaosStudioCapabilityTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The urn attribute.
    /// </summary>
    [TerraformArgument("urn")]
    public TerraformValue<string> Urn
    {
        get => new TerraformReference<string>(this, "urn");
    }

}
