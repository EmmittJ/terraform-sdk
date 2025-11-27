using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApphubServiceProjectAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleApphubServiceProjectAttachmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_apphub_service_project_attachment Terraform resource.
/// Manages a google_apphub_service_project_attachment resource.
/// </summary>
public partial class GoogleApphubServiceProjectAttachment(string name) : TerraformResource("google_apphub_service_project_attachment", name)
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
    /// &amp;quot;Immutable. Service project name in the format: \&amp;quot;projects/abc\&amp;quot;
    /// or \&amp;quot;projects/123\&amp;quot;. As input, project name with either project id or number
    /// are accepted. As output, this field will contain project number.&amp;quot;
    /// </summary>
    public TerraformValue<string>? ServiceProject
    {
        get => new TerraformReference<string>(this, "service_project");
        set => SetArgument("service_project", value);
    }

    /// <summary>
    /// Required. The service project attachment identifier must contain the project_id of the service project specified in the service_project_attachment.service_project field. Hint: &amp;quot;projects/{project_id}&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProjectAttachmentId is required")]
    public required TerraformValue<string> ServiceProjectAttachmentId
    {
        get => new TerraformReference<string>(this, "service_project_attachment_id");
        set => SetArgument("service_project_attachment_id", value);
    }

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// &amp;quot;Identifier. The resource name of a ServiceProjectAttachment. Format:\&amp;quot;projects/{host-project-id}/locations/global/serviceProjectAttachments/{service-project-id}.\&amp;quot;&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// ServiceProjectAttachment state.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Output only. A globally unique identifier (in UUID4 format) for the &#39;ServiceProjectAttachment&#39;.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApphubServiceProjectAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApphubServiceProjectAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
