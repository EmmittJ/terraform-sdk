using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApphubServiceProjectAttachmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apphub_service_project_attachment resource.
/// </summary>
public partial class GoogleApphubServiceProjectAttachment : TerraformResource
{
    public GoogleApphubServiceProjectAttachment(string name) : base("google_apphub_service_project_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// &amp;quot;Immutable. Service project name in the format: \&amp;quot;projects/abc\&amp;quot;
    /// or \&amp;quot;projects/123\&amp;quot;. As input, project name with either project id or number
    /// are accepted. As output, this field will contain project number.&amp;quot;
    /// </summary>
    [TerraformProperty("service_project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceProject { get; set; }

    /// <summary>
    /// Required. The service project attachment identifier must contain the project_id of the service project specified in the service_project_attachment.service_project field. Hint: &amp;quot;projects/{project_id}&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProjectAttachmentId is required")]
    [TerraformProperty("service_project_attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceProjectAttachmentId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApphubServiceProjectAttachmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// &amp;quot;Identifier. The resource name of a ServiceProjectAttachment. Format:\&amp;quot;projects/{host-project-id}/locations/global/serviceProjectAttachments/{service-project-id}.\&amp;quot;&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// ServiceProjectAttachment state.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. A globally unique identifier (in UUID4 format) for the &#39;ServiceProjectAttachment&#39;.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

}
