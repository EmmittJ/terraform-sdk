using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIamProjectsPolicyBindingConditionBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [TerraformProperty("expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Expression { get; set; }

    /// <summary>
    /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Title { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIamProjectsPolicyBindingTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. Immutable. Full Resource Name of the principal set used for principal access boundary policy bindings.
    /// Examples for each one of the following supported principal set types:
    /// * Project:
    ///   * &#39;//cloudresourcemanager.googleapis.com/projects/PROJECT_NUMBER&#39;
    ///   * &#39;//cloudresourcemanager.googleapis.com/projects/PROJECT_ID&#39;
    /// * Workload Identity Pool: &#39;//iam.googleapis.com/projects/PROJECT_NUMBER/locations/LOCATION/workloadIdentityPools/WORKLOAD_POOL_ID&#39;
    /// It must be parent by the policy binding&#39;s parent (the project).
    /// </summary>
    [TerraformProperty("principal_set")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrincipalSet { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIamProjectsPolicyBindingTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_iam_projects_policy_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIamProjectsPolicyBinding : TerraformResource
{
    public GoogleIamProjectsPolicyBinding(string name) : base("google_iam_projects_policy_binding", name)
    {
    }

    /// <summary>
    /// Optional. User defined annotations. See https://google.aip.dev/148#annotations for more details such as format and size limitations
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Optional. The description of the policy binding. Must be less than or equal to 63 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the Policy Binding
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Required. Immutable. The resource name of the policy to be bound. The binding parent and policy must belong to the same Organization (or Project).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    [TerraformProperty("policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// The Policy Binding ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyBindingId is required")]
    [TerraformProperty("policy_binding_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyBindingId { get; set; }

    /// <summary>
    /// Immutable. The kind of the policy to attach in this binding. This
    /// field must be one of the following:  - Left empty (will be automatically set
    /// to the policy kind) - The input policy kind   Possible values:  POLICY_KIND_UNSPECIFIED PRINCIPAL_ACCESS_BOUNDARY ACCESS
    /// </summary>
    [TerraformProperty("policy_kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyKind { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformProperty("condition")]
    public partial TerraformList<TerraformBlock<GoogleIamProjectsPolicyBindingConditionBlock>>? Condition { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformProperty("target")]
    public partial TerraformList<TerraformBlock<GoogleIamProjectsPolicyBindingTargetBlock>>? Target { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleIamProjectsPolicyBindingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The time when the policy binding was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// Optional. The etag for the policy binding. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The name of the policy binding in the format &#39;{binding_parent/locations/{location}/policyBindings/{policy_binding_id}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The globally unique ID of the policy to be bound.
    /// </summary>
    [TerraformProperty("policy_uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyUid { get; }

    /// <summary>
    /// Output only. The globally unique ID of the policy binding. Assigned when the policy binding is created.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The time when the policy binding was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
