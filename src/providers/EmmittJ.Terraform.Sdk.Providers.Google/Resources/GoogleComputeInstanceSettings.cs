using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in GoogleComputeInstanceSettings.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceSettingsMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// A metadata key/value items map. The total size of all keys and values must be less than 512KB
    /// </summary>
    public TerraformMap<string>? Items
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "items").ResolveNodes(ctx));
        set => SetArgument("items", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInstanceSettings.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceSettingsTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_instance_settings Terraform resource.
/// Manages a google_compute_instance_settings resource.
/// </summary>
public partial class GoogleComputeInstanceSettings(string name) : TerraformResource("google_compute_instance_settings", name)
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public TerraformList<GoogleComputeInstanceSettingsMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceSettingsMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInstanceSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInstanceSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
