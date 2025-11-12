using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_apigee_environment_api_revision_deployment resource.
/// </summary>
public partial class GoogleApigeeEnvironmentApiRevisionDeployment : TerraformResource
{
    public GoogleApigeeEnvironmentApiRevisionDeployment(string name) : base("google_apigee_environment_api_revision_deployment", name)
    {
    }

    /// <summary>
    /// Apigee API proxy name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Api is required")]
    [TerraformProperty("api")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Api { get; set; }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformProperty("environment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Apigee organization ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    [TerraformProperty("override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Override { get; set; }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformProperty("revision")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Revision { get; set; }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    [TerraformProperty("sequenced_rollout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SequencedRollout { get; set; }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Basepaths associated with the deployed proxy.
    /// </summary>
    [TerraformProperty("basepaths")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Basepaths { get; }

    /// <summary>
    /// RFC3339 timestamp when deployment started.
    /// </summary>
    [TerraformProperty("deploy_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeployStartTime { get; }

    /// <summary>
    /// Deployment state reported by Apigee.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
