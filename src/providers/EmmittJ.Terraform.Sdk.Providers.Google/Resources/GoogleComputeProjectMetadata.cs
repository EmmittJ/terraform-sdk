using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeProjectMetadata.
/// Nesting mode: single
/// </summary>
public class GoogleComputeProjectMetadataTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_project_metadata Terraform resource.
/// Manages a google_compute_project_metadata resource.
/// </summary>
public partial class GoogleComputeProjectMetadata(string name) : TerraformResource("google_compute_project_metadata", name)
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
    /// A series of key value pairs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeProjectMetadataTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeProjectMetadataTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
