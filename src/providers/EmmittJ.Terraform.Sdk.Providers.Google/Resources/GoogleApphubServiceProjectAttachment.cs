using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApphubServiceProjectAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_apphub_service_project_attachment resource.
/// </summary>
public class GoogleApphubServiceProjectAttachment : TerraformResource
{
    public GoogleApphubServiceProjectAttachment(string name) : base("google_apphub_service_project_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("state");
        SetOutput("uid");
        SetOutput("id");
        SetOutput("project");
        SetOutput("service_project");
        SetOutput("service_project_attachment_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// &amp;quot;Immutable. Service project name in the format: \&amp;quot;projects/abc\&amp;quot;
    /// or \&amp;quot;projects/123\&amp;quot;. As input, project name with either project id or number
    /// are accepted. As output, this field will contain project number.&amp;quot;
    /// </summary>
    public TerraformProperty<string> ServiceProject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_project");
        set => SetProperty("service_project", value);
    }

    /// <summary>
    /// Required. The service project attachment identifier must contain the project_id of the service project specified in the service_project_attachment.service_project field. Hint: &amp;quot;projects/{project_id}&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProjectAttachmentId is required")]
    public required TerraformProperty<string> ServiceProjectAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_project_attachment_id");
        set => SetProperty("service_project_attachment_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApphubServiceProjectAttachmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// &amp;quot;Identifier. The resource name of a ServiceProjectAttachment. Format:\&amp;quot;projects/{host-project-id}/locations/global/serviceProjectAttachments/{service-project-id}.\&amp;quot;&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// ServiceProjectAttachment state.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. A globally unique identifier (in UUID4 format) for the &#39;ServiceProjectAttachment&#39;.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
