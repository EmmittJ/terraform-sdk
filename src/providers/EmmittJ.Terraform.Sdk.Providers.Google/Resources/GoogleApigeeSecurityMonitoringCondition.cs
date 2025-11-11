using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for include_all_resources in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeSecurityMonitoringConditionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_security_monitoring_condition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeSecurityMonitoringCondition : TerraformResource
{
    public GoogleApigeeSecurityMonitoringCondition(string name) : base("google_apigee_security_monitoring_condition", name)
    {
    }

    /// <summary>
    /// Resource ID of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionId is required")]
    [TerraformProperty("condition_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConditionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee Security Monitoring Condition,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    [TerraformProperty("profile")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Profile { get; set; }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for include_all_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeAllResources block(s) allowed")]
    [TerraformProperty("include_all_resources")]
    public TerraformList<TerraformBlock<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>>? IncludeAllResources { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleApigeeSecurityMonitoringConditionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Name of the security monitoring condition resource,
    /// in the format &#39;organizations/{{org_name}}/securityMonitoringConditions/{{condition_id}}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Total number of deployed resources within scope.
    /// </summary>
    [TerraformProperty("total_deployed_resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalDeployedResources { get; }

    /// <summary>
    /// Total number of monitored resources within this condition.
    /// </summary>
    [TerraformProperty("total_monitored_resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalMonitoredResources { get; }

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
