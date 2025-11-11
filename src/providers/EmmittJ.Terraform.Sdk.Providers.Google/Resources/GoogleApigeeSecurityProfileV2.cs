using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for profile_assessment_configs in .
/// Nesting mode: set
/// </summary>
public partial class GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// The assessment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Assessment is required")]
    [TerraformProperty("assessment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Assessment { get; set; }

    /// <summary>
    /// The weight of the assessment. Possible values: [&amp;quot;MINOR&amp;quot;, &amp;quot;MODERATE&amp;quot;, &amp;quot;MAJOR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    [TerraformProperty("weight")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Weight { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeSecurityProfileV2TimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_security_profile_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeSecurityProfileV2 : TerraformResource
{
    public GoogleApigeeSecurityProfileV2(string name) : base("google_apigee_security_profile_v2", name)
    {
    }

    /// <summary>
    /// Description of the security profile.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee Security Profile V2,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Resource ID of the security profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    [TerraformProperty("profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileId { get; set; }

    /// <summary>
    /// Block for profile_assessment_configs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileAssessmentConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProfileAssessmentConfigs block(s) required")]
    [TerraformProperty("profile_assessment_configs")]
    public partial TerraformSet<TerraformBlock<GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock>>? ProfileAssessmentConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleApigeeSecurityProfileV2TimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Name of the security profile v2 resource,
    /// in the format &#39;organizations/{{org_name}}/securityProfilesV2/{{profile_id}}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
