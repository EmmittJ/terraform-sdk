using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeSharedflow.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSharedflowTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_sharedflow Terraform resource.
/// Manages a google_apigee_sharedflow resource.
/// </summary>
public partial class GoogleApigeeSharedflow(string name) : TerraformResource("google_apigee_sharedflow", name)
{
    /// <summary>
    /// Path to the config zip bundle
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigBundle is required")]
    public required TerraformValue<string> ConfigBundle
    {
        get => GetRequiredArgument<TerraformValue<string>>("config_bundle");
        set => SetArgument("config_bundle", value);
    }

    /// <summary>
    /// A hash of local config bundle in string, user needs to use a Terraform Hash function of their choice. A change in hash will trigger an update.
    /// </summary>
    public TerraformValue<string>? DetectMd5hash
    {
        get => GetArgument<TerraformValue<string>>("detect_md5hash");
        set => SetArgument("detect_md5hash", value);
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
    /// The ID of the shared flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The id of the most recently created revision for this shared flow.
    /// </summary>
    public TerraformValue<string> LatestRevisionId
        => CreateReference("latest_revision_id");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded config bundle.
    /// </summary>
    public TerraformValue<string> Md5hash
        => CreateReference("md5hash");

    /// <summary>
    /// Metadata describing the shared flow.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetaData
        => CreateReference("meta_data");

    /// <summary>
    /// A list of revisions of this shared flow.
    /// </summary>
    public TerraformList<string> Revision
        => CreateReference("revision");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeSharedflowTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeSharedflowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
