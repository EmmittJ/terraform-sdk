using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for approval_settings in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Whether an approval is required
    /// </summary>
    public TerraformProperty<bool>? ApprovalRequired
    {
        get => GetProperty<TerraformProperty<bool>>("approval_required");
        set => WithProperty("approval_required", value);
    }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    public TerraformProperty<bool>? ApprovalRequiredForExtension
    {
        get => GetProperty<TerraformProperty<bool>>("approval_required_for_extension");
        set => WithProperty("approval_required_for_extension", value);
    }

    /// <summary>
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    public TerraformProperty<bool>? RequestorJustificationRequired
    {
        get => GetProperty<TerraformProperty<bool>>("requestor_justification_required");
        set => WithProperty("requestor_justification_required", value);
    }

}

/// <summary>
/// Block type for assignment_review_settings in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&#39; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    public TerraformProperty<bool>? AccessRecommendationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("access_recommendation_enabled");
        set => WithProperty("access_recommendation_enabled", value);
    }

    /// <summary>
    /// What actions the system takes if reviewers don&#39;t respond in time
    /// </summary>
    public TerraformProperty<string>? AccessReviewTimeoutBehavior
    {
        get => GetProperty<TerraformProperty<string>>("access_review_timeout_behavior");
        set => WithProperty("access_review_timeout_behavior", value);
    }

    /// <summary>
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    public TerraformProperty<bool>? ApproverJustificationRequired
    {
        get => GetProperty<TerraformProperty<bool>>("approver_justification_required");
        set => WithProperty("approver_justification_required", value);
    }

    /// <summary>
    /// How many days each occurrence of the access review series will run
    /// </summary>
    public TerraformProperty<double>? DurationInDays
    {
        get => GetProperty<TerraformProperty<double>>("duration_in_days");
        set => WithProperty("duration_in_days", value);
    }

    /// <summary>
    /// Whether to enable assignment review
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// This will determine how often the access review campaign runs
    /// </summary>
    public TerraformProperty<string>? ReviewFrequency
    {
        get => GetProperty<TerraformProperty<string>>("review_frequency");
        set => WithProperty("review_frequency", value);
    }

    /// <summary>
    /// Self review or specific reviewers
    /// </summary>
    public TerraformProperty<string>? ReviewType
    {
        get => GetProperty<TerraformProperty<string>>("review_type");
        set => WithProperty("review_type", value);
    }

    /// <summary>
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    public TerraformProperty<string>? StartingOn
    {
        get => GetProperty<TerraformProperty<string>>("starting_on");
        set => WithProperty("starting_on", value);
    }

}

/// <summary>
/// Block type for question in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlock : TerraformBlock
{
    /// <summary>
    /// Whether this question is required
    /// </summary>
    public TerraformProperty<bool>? Required
    {
        get => GetProperty<TerraformProperty<bool>>("required");
        set => WithProperty("required", value);
    }

    /// <summary>
    /// The sequence number of this question
    /// </summary>
    public TerraformProperty<double>? Sequence
    {
        get => GetProperty<TerraformProperty<double>>("sequence");
        set => WithProperty("sequence", value);
    }

}

/// <summary>
/// Block type for requestor_settings in .
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    public TerraformProperty<bool>? RequestsAccepted
    {
        get => GetProperty<TerraformProperty<bool>>("requests_accepted");
        set => WithProperty("requests_accepted", value);
    }

    /// <summary>
    /// Specify the scopes of the requestors
    /// </summary>
    public TerraformProperty<string>? ScopeType
    {
        get => GetProperty<TerraformProperty<string>>("scope_type");
        set => WithProperty("scope_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageAssignmentPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_access_package_assignment_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadAccessPackageAssignmentPolicy : TerraformResource
{
    public AzureadAccessPackageAssignmentPolicy(string name) : base("azuread_access_package_assignment_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The ID of the access package that will contain the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    public required TerraformProperty<string> AccessPackageId
    {
        get => GetProperty<TerraformProperty<string>>("access_package_id");
        set => this.WithProperty("access_package_id", value);
    }

    /// <summary>
    /// The description of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    public TerraformProperty<double>? DurationInDays
    {
        get => GetProperty<TerraformProperty<double>>("duration_in_days");
        set => this.WithProperty("duration_in_days", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
    }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    public TerraformProperty<bool>? ExtensionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("extension_enabled");
        set => this.WithProperty("extension_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for approval_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalSettings block(s) allowed")]
    public List<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock>? ApprovalSettings
    {
        get => GetProperty<List<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock>>("approval_settings");
        set => this.WithProperty("approval_settings", value);
    }

    /// <summary>
    /// Block for assignment_review_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignmentReviewSettings block(s) allowed")]
    public List<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock>? AssignmentReviewSettings
    {
        get => GetProperty<List<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock>>("assignment_review_settings");
        set => this.WithProperty("assignment_review_settings", value);
    }

    /// <summary>
    /// Block for question.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadAccessPackageAssignmentPolicyQuestionBlock>? Question
    {
        get => GetProperty<List<AzureadAccessPackageAssignmentPolicyQuestionBlock>>("question");
        set => this.WithProperty("question", value);
    }

    /// <summary>
    /// Block for requestor_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestorSettings block(s) allowed")]
    public List<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock>? RequestorSettings
    {
        get => GetProperty<List<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock>>("requestor_settings");
        set => this.WithProperty("requestor_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAccessPackageAssignmentPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadAccessPackageAssignmentPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
