using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for approval_settings in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock
{
    /// <summary>
    /// Whether an approval is required
    /// </summary>
    [TerraformPropertyName("approval_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApprovalRequired { get; set; }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    [TerraformPropertyName("approval_required_for_extension")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApprovalRequiredForExtension { get; set; }

    /// <summary>
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    [TerraformPropertyName("requestor_justification_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestorJustificationRequired { get; set; }

}

/// <summary>
/// Block type for assignment_review_settings in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock
{
    /// <summary>
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&#39; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    [TerraformPropertyName("access_recommendation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AccessRecommendationEnabled { get; set; }

    /// <summary>
    /// What actions the system takes if reviewers don&#39;t respond in time
    /// </summary>
    [TerraformPropertyName("access_review_timeout_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessReviewTimeoutBehavior { get; set; }

    /// <summary>
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    [TerraformPropertyName("approver_justification_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// How many days each occurrence of the access review series will run
    /// </summary>
    [TerraformPropertyName("duration_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DurationInDays { get; set; }

    /// <summary>
    /// Whether to enable assignment review
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// This will determine how often the access review campaign runs
    /// </summary>
    [TerraformPropertyName("review_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReviewFrequency { get; set; }

    /// <summary>
    /// Self review or specific reviewers
    /// </summary>
    [TerraformPropertyName("review_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReviewType { get; set; }

    /// <summary>
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    [TerraformPropertyName("starting_on")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartingOn { get; set; }

}

/// <summary>
/// Block type for question in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlock
{
    /// <summary>
    /// Whether this question is required
    /// </summary>
    [TerraformPropertyName("required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Required { get; set; }

    /// <summary>
    /// The sequence number of this question
    /// </summary>
    [TerraformPropertyName("sequence")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Sequence { get; set; }

}

/// <summary>
/// Block type for requestor_settings in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock
{
    /// <summary>
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    [TerraformPropertyName("requests_accepted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestsAccepted { get; set; }

    /// <summary>
    /// Specify the scopes of the requestors
    /// </summary>
    [TerraformPropertyName("scope_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScopeType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageAssignmentPolicyTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_access_package_assignment_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadAccessPackageAssignmentPolicy : TerraformResource
{
    public AzureadAccessPackageAssignmentPolicy(string name) : base("azuread_access_package_assignment_policy", name)
    {
    }

    /// <summary>
    /// The ID of the access package that will contain the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    [TerraformPropertyName("access_package_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessPackageId { get; set; }

    /// <summary>
    /// The description of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    [TerraformPropertyName("duration_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DurationInDays { get; set; }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpirationDate { get; set; }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    [TerraformPropertyName("extension_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExtensionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for approval_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalSettings block(s) allowed")]
    [TerraformPropertyName("approval_settings")]
    public TerraformList<TerraformBlock<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock>>? ApprovalSettings { get; set; }

    /// <summary>
    /// Block for assignment_review_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignmentReviewSettings block(s) allowed")]
    [TerraformPropertyName("assignment_review_settings")]
    public TerraformList<TerraformBlock<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock>>? AssignmentReviewSettings { get; set; }

    /// <summary>
    /// Block for question.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("question")]
    public TerraformList<TerraformBlock<AzureadAccessPackageAssignmentPolicyQuestionBlock>>? Question { get; set; }

    /// <summary>
    /// Block for requestor_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestorSettings block(s) allowed")]
    [TerraformPropertyName("requestor_settings")]
    public TerraformList<TerraformBlock<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock>>? RequestorSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageAssignmentPolicyTimeoutsBlock>? Timeouts { get; set; }

}
