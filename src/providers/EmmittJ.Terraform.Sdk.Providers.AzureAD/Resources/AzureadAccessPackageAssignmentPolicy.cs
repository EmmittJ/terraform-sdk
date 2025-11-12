using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for approval_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock() : TerraformBlock("approval_settings")
{
    /// <summary>
    /// Whether an approval is required
    /// </summary>
    [TerraformProperty("approval_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApprovalRequired { get; set; }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    [TerraformProperty("approval_required_for_extension")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApprovalRequiredForExtension { get; set; }

    /// <summary>
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    [TerraformProperty("requestor_justification_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequestorJustificationRequired { get; set; }

}

/// <summary>
/// Block type for assignment_review_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock() : TerraformBlock("assignment_review_settings")
{
    /// <summary>
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&#39; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    [TerraformProperty("access_recommendation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AccessRecommendationEnabled { get; set; }

    /// <summary>
    /// What actions the system takes if reviewers don&#39;t respond in time
    /// </summary>
    [TerraformProperty("access_review_timeout_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessReviewTimeoutBehavior { get; set; }

    /// <summary>
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    [TerraformProperty("approver_justification_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// How many days each occurrence of the access review series will run
    /// </summary>
    [TerraformProperty("duration_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DurationInDays { get; set; }

    /// <summary>
    /// Whether to enable assignment review
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// This will determine how often the access review campaign runs
    /// </summary>
    [TerraformProperty("review_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReviewFrequency { get; set; }

    /// <summary>
    /// Self review or specific reviewers
    /// </summary>
    [TerraformProperty("review_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReviewType { get; set; }

    /// <summary>
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    [TerraformProperty("starting_on")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartingOn { get; set; }

}

/// <summary>
/// Block type for question in .
/// Nesting mode: list
/// </summary>
public partial class AzureadAccessPackageAssignmentPolicyQuestionBlock() : TerraformBlock("question")
{
    /// <summary>
    /// Whether this question is required
    /// </summary>
    [TerraformProperty("required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Required { get; set; }

    /// <summary>
    /// The sequence number of this question
    /// </summary>
    [TerraformProperty("sequence")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Sequence { get; set; }

}

/// <summary>
/// Block type for requestor_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock() : TerraformBlock("requestor_settings")
{
    /// <summary>
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    [TerraformProperty("requests_accepted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequestsAccepted { get; set; }

    /// <summary>
    /// Specify the scopes of the requestors
    /// </summary>
    [TerraformProperty("scope_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScopeType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAccessPackageAssignmentPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_access_package_assignment_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadAccessPackageAssignmentPolicy : TerraformResource
{
    public AzureadAccessPackageAssignmentPolicy(string name) : base("azuread_access_package_assignment_policy", name)
    {
    }

    /// <summary>
    /// The ID of the access package that will contain the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    [TerraformProperty("access_package_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessPackageId { get; set; }

    /// <summary>
    /// The description of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    [TerraformProperty("duration_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DurationInDays { get; set; }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationDate { get; set; }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    [TerraformProperty("extension_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExtensionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for approval_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalSettings block(s) allowed")]
    [TerraformProperty("approval_settings")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock> ApprovalSettings { get; set; } = new();

    /// <summary>
    /// Block for assignment_review_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignmentReviewSettings block(s) allowed")]
    [TerraformProperty("assignment_review_settings")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock> AssignmentReviewSettings { get; set; } = new();

    /// <summary>
    /// Block for question.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("question")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlock> Question { get; set; } = new();

    /// <summary>
    /// Block for requestor_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestorSettings block(s) allowed")]
    [TerraformProperty("requestor_settings")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock> RequestorSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadAccessPackageAssignmentPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
