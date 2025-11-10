using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for include_all_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityMonitoringConditionTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_security_monitoring_condition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeSecurityMonitoringCondition : TerraformResource
{
    public GoogleApigeeSecurityMonitoringCondition(string name) : base("google_apigee_security_monitoring_condition", name)
    {
    }

    /// <summary>
    /// Resource ID of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionId is required")]
    [TerraformPropertyName("condition_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConditionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The Apigee Organization associated with the Apigee Security Monitoring Condition,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    [TerraformPropertyName("profile")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Profile { get; set; }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// Block for include_all_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeAllResources block(s) allowed")]
    [TerraformPropertyName("include_all_resources")]
    public TerraformList<TerraformBlock<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>>? IncludeAllResources { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeSecurityMonitoringConditionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Name of the security monitoring condition resource,
    /// in the format &#39;organizations/{{org_name}}/securityMonitoringConditions/{{condition_id}}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Total number of deployed resources within scope.
    /// </summary>
    [TerraformPropertyName("total_deployed_resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalDeployedResources => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_deployed_resources");

    /// <summary>
    /// Total number of monitored resources within this condition.
    /// </summary>
    [TerraformPropertyName("total_monitored_resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalMonitoredResources => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_monitored_resources");

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
