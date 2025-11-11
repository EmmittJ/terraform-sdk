using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecurityposturePostureDeploymentTimeoutsBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_securityposture_posture_deployment resource.
/// </summary>
public class GoogleSecurityposturePostureDeployment : TerraformResource
{
    public GoogleSecurityposturePostureDeployment(string name) : base("google_securityposture_posture_deployment", name)
    {
    }

    /// <summary>
    /// Description of the posture deployment.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the resource, eg. global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// ID of the posture deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureDeploymentId is required")]
    [TerraformPropertyName("posture_deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PostureDeploymentId { get; set; }

    /// <summary>
    /// Relative name of the posture which needs to be deployed. It should be in the format:
    ///   organizations/{organization_id}/locations/{location}/postures/{posture_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureId is required")]
    [TerraformPropertyName("posture_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PostureId { get; set; }

    /// <summary>
    /// Revision_id the posture which needs to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureRevisionId is required")]
    [TerraformPropertyName("posture_revision_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PostureRevisionId { get; set; }

    /// <summary>
    /// The resource on which the posture should be deployed. This can be in one of the following formats:
    /// projects/{project_number},
    /// folders/{folder_number},
    /// organizations/{organization_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResource is required")]
    [TerraformPropertyName("target_resource")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetResource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSecurityposturePostureDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the posture deployment was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture to be deployed.
    /// </summary>
    [TerraformPropertyName("desired_posture_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DesiredPostureId => new TerraformReference(this, "desired_posture_id");

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture revision_id to be deployed.
    /// </summary>
    [TerraformPropertyName("desired_posture_revision_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DesiredPostureRevisionId => new TerraformReference(this, "desired_posture_revision_id");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// This is a output only optional field which will be filled in case where
    /// PostureDeployment enters a failure state like UPDATE_FAILED or
    /// CREATE_FAILED or DELETE_FAILED. It will have the failure message for posture deployment&#39;s
    /// CREATE/UPDATE/DELETE methods.
    /// </summary>
    [TerraformPropertyName("failure_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FailureMessage => new TerraformReference(this, "failure_message");

    /// <summary>
    /// Name of the posture deployment instance.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// If set, there are currently changes in flight to the posture deployment.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// State of the posture deployment. A posture deployment can be in the following terminal states:
    /// ACTIVE, CREATE_FAILED, UPDATE_FAILED, DELETE_FAILED.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Time the posture deployment was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
