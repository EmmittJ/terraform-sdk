using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubHostProjectRegistrationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apihub_host_project_registration resource.
/// </summary>
public class GoogleApihubHostProjectRegistration : TerraformResource
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
    [TerraformPropertyName("gcp_project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GcpProject { get; set; }

    /// <summary>
    /// Required. The ID to use for the Host Project Registration, which will become the
    /// final component of the host project registration&#39;s resource name. The ID
    /// must be the same as the Google cloud project specified in the
    /// host_project_registration.gcp_project field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProjectRegistrationId is required")]
    [TerraformPropertyName("host_project_registration_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostProjectRegistrationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApihubHostProjectRegistrationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time at which the host project registration was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Identifier. The name of the host project registration.
    /// Format:
    /// &amp;quot;projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
