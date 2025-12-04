using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleResourceManagerCapability.
/// Nesting mode: single
/// </summary>
public class GoogleResourceManagerCapabilityTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_resource_manager_capability Terraform resource.
/// Manages a google_resource_manager_capability resource.
/// </summary>
public partial class GoogleResourceManagerCapability(string name) : TerraformResource("google_resource_manager_capability", name)
{
    /// <summary>
    /// Capability name that should be updated on the folder.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityName is required")]
    public required TerraformValue<string> CapabilityName
    {
        get => GetRequiredArgument<TerraformValue<string>>("capability_name");
        set => SetArgument("capability_name", value);
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
    /// Folder on which Capability needs to be updated in the format folders/folder_id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Capability Value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<bool> Value
    {
        get => GetRequiredArgument<TerraformValue<bool>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleResourceManagerCapabilityTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleResourceManagerCapabilityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
