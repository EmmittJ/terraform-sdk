using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvgroupAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvgroupAttachmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_apigee_envgroup_attachment Terraform resource.
/// Manages a google_apigee_envgroup_attachment resource.
/// </summary>
public partial class GoogleApigeeEnvgroupAttachment(string name) : TerraformResource("google_apigee_envgroup_attachment", name)
{
    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/envgroups/{{envgroup_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvgroupId is required")]
    public required TerraformValue<string> EnvgroupId
    {
        get => new TerraformReference<string>(this, "envgroup_id");
        set => SetArgument("envgroup_id", value);
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
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
    /// The name of the newly created  attachment (output parameter).
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvgroupAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvgroupAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
