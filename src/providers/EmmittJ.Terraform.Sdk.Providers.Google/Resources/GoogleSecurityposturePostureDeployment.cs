using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecurityposturePostureDeploymentTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_securityposture_posture_deployment resource.
/// </summary>
public partial class GoogleSecurityposturePostureDeployment : TerraformResource
{
    public GoogleSecurityposturePostureDeployment(string name) : base("google_securityposture_posture_deployment", name)
    {
    }

    /// <summary>
    /// Description of the posture deployment.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource, eg. global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// ID of the posture deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureDeploymentId is required")]
    [TerraformProperty("posture_deployment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PostureDeploymentId { get; set; }

    /// <summary>
    /// Relative name of the posture which needs to be deployed. It should be in the format:
    ///   organizations/{organization_id}/locations/{location}/postures/{posture_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureId is required")]
    [TerraformProperty("posture_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PostureId { get; set; }

    /// <summary>
    /// Revision_id the posture which needs to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureRevisionId is required")]
    [TerraformProperty("posture_revision_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PostureRevisionId { get; set; }

    /// <summary>
    /// The resource on which the posture should be deployed. This can be in one of the following formats:
    /// projects/{project_number},
    /// folders/{folder_number},
    /// organizations/{organization_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResource is required")]
    [TerraformProperty("target_resource")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetResource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSecurityposturePostureDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the posture deployment was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture to be deployed.
    /// </summary>
    [TerraformProperty("desired_posture_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DesiredPostureId { get; }

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture revision_id to be deployed.
    /// </summary>
    [TerraformProperty("desired_posture_revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DesiredPostureRevisionId { get; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// This is a output only optional field which will be filled in case where
    /// PostureDeployment enters a failure state like UPDATE_FAILED or
    /// CREATE_FAILED or DELETE_FAILED. It will have the failure message for posture deployment&#39;s
    /// CREATE/UPDATE/DELETE methods.
    /// </summary>
    [TerraformProperty("failure_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FailureMessage { get; }

    /// <summary>
    /// Name of the posture deployment instance.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the posture deployment.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// State of the posture deployment. A posture deployment can be in the following terminal states:
    /// ACTIVE, CREATE_FAILED, UPDATE_FAILED, DELETE_FAILED.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// Time the posture deployment was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
