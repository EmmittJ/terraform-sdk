using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> Api { get; set; }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformPropertyName("environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Apigee organization ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    [TerraformPropertyName("override")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Override { get; set; }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformPropertyName("revision")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Revision { get; set; }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    [TerraformPropertyName("sequenced_rollout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SequencedRollout { get; set; }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Basepaths associated with the deployed proxy.
    /// </summary>
    [TerraformPropertyName("basepaths")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Basepaths => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "basepaths");

    /// <summary>
    /// RFC3339 timestamp when deployment started.
    /// </summary>
    [TerraformPropertyName("deploy_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeployStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deploy_start_time");

    /// <summary>
    /// Deployment state reported by Apigee.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
