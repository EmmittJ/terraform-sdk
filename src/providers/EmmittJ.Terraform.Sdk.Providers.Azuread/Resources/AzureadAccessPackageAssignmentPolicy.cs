using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for approval_settings in AzureadAccessPackageAssignmentPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approval_settings";

    /// <summary>
    /// Whether an approval is required
    /// </summary>
    public TerraformValue<bool>? ApprovalRequired
    {
        get => new TerraformReference<bool>(this, "approval_required");
        set => SetArgument("approval_required", value);
    }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    public TerraformValue<bool>? ApprovalRequiredForExtension
    {
        get => new TerraformReference<bool>(this, "approval_required_for_extension");
        set => SetArgument("approval_required_for_extension", value);
    }

    /// <summary>
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    public TerraformValue<bool>? RequestorJustificationRequired
    {
        get => new TerraformReference<bool>(this, "requestor_justification_required");
        set => SetArgument("requestor_justification_required", value);
    }

    /// <summary>
    /// ApprovalStage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlock>? ApprovalStage
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlock>>("approval_stage");
        set => SetArgument("approval_stage", value);
    }

}

/// <summary>
/// Block type for approval_stage in AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approval_stage";

    /// <summary>
    /// If no action taken, forward to alternate approvers?
    /// </summary>
    public TerraformValue<bool>? AlternativeApprovalEnabled
    {
        get => new TerraformReference<bool>(this, "alternative_approval_enabled");
        set => SetArgument("alternative_approval_enabled", value);
    }

    /// <summary>
    /// Decision must be made in how many days? If a request is not approved within this time period after it is made, it will be automatically rejected
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApprovalTimeoutInDays is required")]
    public required TerraformValue<double> ApprovalTimeoutInDays
    {
        get => new TerraformReference<double>(this, "approval_timeout_in_days");
        set => SetArgument("approval_timeout_in_days", value);
    }

    /// <summary>
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor
    /// </summary>
    public TerraformValue<bool>? ApproverJustificationRequired
    {
        get => new TerraformReference<bool>(this, "approver_justification_required");
        set => SetArgument("approver_justification_required", value);
    }

    /// <summary>
    /// Forward to alternate approver(s) after how many days?
    /// </summary>
    public TerraformValue<double>? EnableAlternativeApprovalInDays
    {
        get => new TerraformReference<double>(this, "enable_alternative_approval_in_days");
        set => SetArgument("enable_alternative_approval_in_days", value);
    }

    /// <summary>
    /// AlternativeApprover block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlockAlternativeApproverBlock>? AlternativeApprover
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlockAlternativeApproverBlock>>("alternative_approver");
        set => SetArgument("alternative_approver", value);
    }

    /// <summary>
    /// PrimaryApprover block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlockPrimaryApproverBlock>? PrimaryApprover
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlockPrimaryApproverBlock>>("primary_approver");
        set => SetArgument("primary_approver", value);
    }

}

/// <summary>
/// Block type for alternative_approver in AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlockAlternativeApproverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alternative_approver";

    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    public TerraformValue<bool>? Backup
    {
        get => new TerraformReference<bool>(this, "backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// The object ID of the subject
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// Type of users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubjectType is required")]
    public required TerraformValue<string> SubjectType
    {
        get => new TerraformReference<string>(this, "subject_type");
        set => SetArgument("subject_type", value);
    }

}

/// <summary>
/// Block type for primary_approver in AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyApprovalSettingsBlockApprovalStageBlockPrimaryApproverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_approver";

    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    public TerraformValue<bool>? Backup
    {
        get => new TerraformReference<bool>(this, "backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// The object ID of the subject
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// Type of users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubjectType is required")]
    public required TerraformValue<string> SubjectType
    {
        get => new TerraformReference<string>(this, "subject_type");
        set => SetArgument("subject_type", value);
    }

}


/// <summary>
/// Block type for assignment_review_settings in AzureadAccessPackageAssignmentPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assignment_review_settings";

    /// <summary>
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&#39; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    public TerraformValue<bool>? AccessRecommendationEnabled
    {
        get => new TerraformReference<bool>(this, "access_recommendation_enabled");
        set => SetArgument("access_recommendation_enabled", value);
    }

    /// <summary>
    /// What actions the system takes if reviewers don&#39;t respond in time
    /// </summary>
    public TerraformValue<string>? AccessReviewTimeoutBehavior
    {
        get => new TerraformReference<string>(this, "access_review_timeout_behavior");
        set => SetArgument("access_review_timeout_behavior", value);
    }

    /// <summary>
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    public TerraformValue<bool>? ApproverJustificationRequired
    {
        get => new TerraformReference<bool>(this, "approver_justification_required");
        set => SetArgument("approver_justification_required", value);
    }

    /// <summary>
    /// How many days each occurrence of the access review series will run
    /// </summary>
    public TerraformValue<double>? DurationInDays
    {
        get => new TerraformReference<double>(this, "duration_in_days");
        set => SetArgument("duration_in_days", value);
    }

    /// <summary>
    /// Whether to enable assignment review
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// This will determine how often the access review campaign runs
    /// </summary>
    public TerraformValue<string>? ReviewFrequency
    {
        get => new TerraformReference<string>(this, "review_frequency");
        set => SetArgument("review_frequency", value);
    }

    /// <summary>
    /// Self review or specific reviewers
    /// </summary>
    public TerraformValue<string>? ReviewType
    {
        get => new TerraformReference<string>(this, "review_type");
        set => SetArgument("review_type", value);
    }

    /// <summary>
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    public TerraformValue<string>? StartingOn
    {
        get => new TerraformReference<string>(this, "starting_on");
        set => SetArgument("starting_on", value);
    }

    /// <summary>
    /// Reviewer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlockReviewerBlock>? Reviewer
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlockReviewerBlock>>("reviewer");
        set => SetArgument("reviewer", value);
    }

}

/// <summary>
/// Block type for reviewer in AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlockReviewerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reviewer";

    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    public TerraformValue<bool>? Backup
    {
        get => new TerraformReference<bool>(this, "backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// The object ID of the subject
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// Type of users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubjectType is required")]
    public required TerraformValue<string> SubjectType
    {
        get => new TerraformReference<string>(this, "subject_type");
        set => SetArgument("subject_type", value);
    }

}


/// <summary>
/// Block type for question in AzureadAccessPackageAssignmentPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "question";

    /// <summary>
    /// Whether this question is required
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The sequence number of this question
    /// </summary>
    public TerraformValue<double>? Sequence
    {
        get => new TerraformReference<double>(this, "sequence");
        set => SetArgument("sequence", value);
    }

    /// <summary>
    /// Choice block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlock>? Choice
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlock>>("choice");
        set => SetArgument("choice", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Text block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public required TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlock> Text
    {
        get => GetRequiredArgument<TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for choice in AzureadAccessPackageAssignmentPolicyQuestionBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "choice";

    /// <summary>
    /// The actual value of this choice
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActualValue is required")]
    public required TerraformValue<string> ActualValue
    {
        get => new TerraformReference<string>(this, "actual_value");
        set => SetArgument("actual_value", value);
    }

    /// <summary>
    /// DisplayValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DisplayValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DisplayValue block(s) allowed")]
    public required TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlock> DisplayValue
    {
        get => GetRequiredArgument<TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlock>>("display_value");
        set => SetArgument("display_value", value);
    }

}

/// <summary>
/// Block type for display_value in AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "display_value";

    /// <summary>
    /// The default text of this question
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultText is required")]
    public required TerraformValue<string> DefaultText
    {
        get => new TerraformReference<string>(this, "default_text");
        set => SetArgument("default_text", value);
    }

    /// <summary>
    /// LocalizedText block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlockLocalizedTextBlock>? LocalizedText
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlockLocalizedTextBlock>>("localized_text");
        set => SetArgument("localized_text", value);
    }

}

/// <summary>
/// Block type for localized_text in AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlockChoiceBlockDisplayValueBlockLocalizedTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "localized_text";

    /// <summary>
    /// The localized content of this question
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The language code of this question content
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

}

/// <summary>
/// Block type for text in AzureadAccessPackageAssignmentPolicyQuestionBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// The default text of this question
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultText is required")]
    public required TerraformValue<string> DefaultText
    {
        get => new TerraformReference<string>(this, "default_text");
        set => SetArgument("default_text", value);
    }

    /// <summary>
    /// LocalizedText block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlockLocalizedTextBlock>? LocalizedText
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlockLocalizedTextBlock>>("localized_text");
        set => SetArgument("localized_text", value);
    }

}

/// <summary>
/// Block type for localized_text in AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyQuestionBlockTextBlockLocalizedTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "localized_text";

    /// <summary>
    /// The localized content of this question
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The language code of this question content
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

}


/// <summary>
/// Block type for requestor_settings in AzureadAccessPackageAssignmentPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requestor_settings";

    /// <summary>
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    public TerraformValue<bool>? RequestsAccepted
    {
        get => new TerraformReference<bool>(this, "requests_accepted");
        set => SetArgument("requests_accepted", value);
    }

    /// <summary>
    /// Specify the scopes of the requestors
    /// </summary>
    public TerraformValue<string>? ScopeType
    {
        get => new TerraformReference<string>(this, "scope_type");
        set => SetArgument("scope_type", value);
    }

    /// <summary>
    /// Requestor block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlockRequestorBlock>? Requestor
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlockRequestorBlock>>("requestor");
        set => SetArgument("requestor", value);
    }

}

/// <summary>
/// Block type for requestor in AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadAccessPackageAssignmentPolicyRequestorSettingsBlockRequestorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requestor";

    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    public TerraformValue<bool>? Backup
    {
        get => new TerraformReference<bool>(this, "backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// The object ID of the subject
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// Type of users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubjectType is required")]
    public required TerraformValue<string> SubjectType
    {
        get => new TerraformReference<string>(this, "subject_type");
        set => SetArgument("subject_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadAccessPackageAssignmentPolicy.
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageAssignmentPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_access_package_assignment_policy Terraform resource.
/// Manages a azuread_access_package_assignment_policy resource.
/// </summary>
public partial class AzureadAccessPackageAssignmentPolicy(string name) : TerraformResource("azuread_access_package_assignment_policy", name)
{
    /// <summary>
    /// The ID of the access package that will contain the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    public required TerraformValue<string> AccessPackageId
    {
        get => new TerraformReference<string>(this, "access_package_id");
        set => SetArgument("access_package_id", value);
    }

    /// <summary>
    /// The description of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// How many days this assignment is valid for
    /// </summary>
    public TerraformValue<double>? DurationInDays
    {
        get => new TerraformReference<double>(this, "duration_in_days");
        set => SetArgument("duration_in_days", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformValue<string>? ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    public TerraformValue<bool>? ExtensionEnabled
    {
        get => new TerraformReference<bool>(this, "extension_enabled");
        set => SetArgument("extension_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ApprovalSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalSettings block(s) allowed")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock>? ApprovalSettings
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyApprovalSettingsBlock>>("approval_settings");
        set => SetArgument("approval_settings", value);
    }

    /// <summary>
    /// AssignmentReviewSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignmentReviewSettings block(s) allowed")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock>? AssignmentReviewSettings
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyAssignmentReviewSettingsBlock>>("assignment_review_settings");
        set => SetArgument("assignment_review_settings", value);
    }

    /// <summary>
    /// Question block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlock>? Question
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyQuestionBlock>>("question");
        set => SetArgument("question", value);
    }

    /// <summary>
    /// RequestorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestorSettings block(s) allowed")]
    public TerraformList<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock>? RequestorSettings
    {
        get => GetArgument<TerraformList<AzureadAccessPackageAssignmentPolicyRequestorSettingsBlock>>("requestor_settings");
        set => SetArgument("requestor_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAccessPackageAssignmentPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAccessPackageAssignmentPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
