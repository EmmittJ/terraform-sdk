using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApihubHostProjectRegistrationTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_apihub_host_project_registration resource.
/// </summary>
public partial class GoogleApihubHostProjectRegistration : TerraformResource
{
    public GoogleApihubHostProjectRegistration(string name) : base("google_apihub_host_project_registration", name)
    {
    }

    /// <summary>
    /// Required. Immutable. Google cloud project name in the format: &amp;quot;projects/abc&amp;quot; or &amp;quot;projects/123&amp;quot;.
    /// As input, project name with either project id or number are accepted.
    /// As output, this field will contain project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpProject is required")]
    [TerraformProperty("gcp_project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GcpProject { get; set; }

    /// <summary>
    /// Required. The ID to use for the Host Project Registration, which will become the
    /// final component of the host project registration&#39;s resource name. The ID
    /// must be the same as the Google cloud project specified in the
    /// host_project_registration.gcp_project field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProjectRegistrationId is required")]
    [TerraformProperty("host_project_registration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostProjectRegistrationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleApihubHostProjectRegistrationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The time at which the host project registration was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Identifier. The name of the host project registration.
    /// Format:
    /// &amp;quot;projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}&amp;quot;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
