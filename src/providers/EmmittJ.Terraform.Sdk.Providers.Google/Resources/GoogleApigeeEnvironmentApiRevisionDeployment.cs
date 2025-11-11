using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apigee_environment_api_revision_deployment resource.
/// </summary>
public class GoogleApigeeEnvironmentApiRevisionDeployment : TerraformResource
{
    public GoogleApigeeEnvironmentApiRevisionDeployment(string name) : base("google_apigee_environment_api_revision_deployment", name)
    {
    }

    /// <summary>
    /// Apigee API proxy name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Api is required")]
    [TerraformPropertyName("api")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Api { get; set; }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformPropertyName("environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Apigee organization ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    [TerraformPropertyName("override")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Override { get; set; }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformPropertyName("revision")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Revision { get; set; }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    [TerraformPropertyName("sequenced_rollout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SequencedRollout { get; set; }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Basepaths associated with the deployed proxy.
    /// </summary>
    [TerraformPropertyName("basepaths")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Basepaths => new TerraformReference(this, "basepaths");

    /// <summary>
    /// RFC3339 timestamp when deployment started.
    /// </summary>
    [TerraformPropertyName("deploy_start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeployStartTime => new TerraformReference(this, "deploy_start_time");

    /// <summary>
    /// Deployment state reported by Apigee.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
