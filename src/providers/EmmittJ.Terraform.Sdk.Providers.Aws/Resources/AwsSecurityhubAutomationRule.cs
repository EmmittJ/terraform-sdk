using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in AwsSecurityhubAutomationRule.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// FindingFieldsUpdate block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock>? FindingFieldsUpdate
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock>>("finding_fields_update");
        set => SetArgument("finding_fields_update", value);
    }

}

/// <summary>
/// Block type for finding_fields_update in AwsSecurityhubAutomationRuleActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_fields_update";

    /// <summary>
    /// The confidence attribute.
    /// </summary>
    public TerraformValue<double>? Confidence
    {
        get => new TerraformReference<double>(this, "confidence");
        set => SetArgument("confidence", value);
    }

    /// <summary>
    /// The criticality attribute.
    /// </summary>
    public TerraformValue<double>? Criticality
    {
        get => new TerraformReference<double>(this, "criticality");
        set => SetArgument("criticality", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    public TerraformList<string>? Types
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "types").ResolveNodes(ctx));
        set => SetArgument("types", value);
    }

    /// <summary>
    /// The user_defined_fields attribute.
    /// </summary>
    public TerraformMap<string>? UserDefinedFields
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "user_defined_fields").ResolveNodes(ctx));
        set => SetArgument("user_defined_fields", value);
    }

    /// <summary>
    /// The verification_state attribute.
    /// </summary>
    public TerraformValue<string>? VerificationState
    {
        get => new TerraformReference<string>(this, "verification_state");
        set => SetArgument("verification_state", value);
    }

    /// <summary>
    /// Note block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockNoteBlock>? Note
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockNoteBlock>>("note");
        set => SetArgument("note", value);
    }

    /// <summary>
    /// RelatedFindings block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockRelatedFindingsBlock>? RelatedFindings
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockRelatedFindingsBlock>>("related_findings");
        set => SetArgument("related_findings", value);
    }

    /// <summary>
    /// Severity block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockSeverityBlock>? Severity
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockSeverityBlock>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// Workflow block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockWorkflowBlock>? Workflow
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockWorkflowBlock>>("workflow");
        set => SetArgument("workflow", value);
    }

}

/// <summary>
/// Block type for note in AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockNoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "note";

    /// <summary>
    /// The text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// The updated_by attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpdatedBy is required")]
    public required TerraformValue<string> UpdatedBy
    {
        get => new TerraformReference<string>(this, "updated_by");
        set => SetArgument("updated_by", value);
    }

}

/// <summary>
/// Block type for related_findings in AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockRelatedFindingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "related_findings";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The product_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductArn is required")]
    public required TerraformValue<string> ProductArn
    {
        get => new TerraformReference<string>(this, "product_arn");
        set => SetArgument("product_arn", value);
    }

}

/// <summary>
/// Block type for severity in AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockSeverityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "severity";

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string> Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    public TerraformValue<double>? Product
    {
        get => new TerraformReference<double>(this, "product");
        set => SetArgument("product", value);
    }

}

/// <summary>
/// Block type for workflow in AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlockFindingFieldsUpdateBlockWorkflowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workflow";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for criteria in AwsSecurityhubAutomationRule.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criteria";

    /// <summary>
    /// AwsAccountId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockAwsAccountIdBlock>? AwsAccountId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockAwsAccountIdBlock>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// AwsAccountName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockAwsAccountNameBlock>? AwsAccountName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockAwsAccountNameBlock>>("aws_account_name");
        set => SetArgument("aws_account_name", value);
    }

    /// <summary>
    /// CompanyName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockCompanyNameBlock>? CompanyName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockCompanyNameBlock>>("company_name");
        set => SetArgument("company_name", value);
    }

    /// <summary>
    /// ComplianceAssociatedStandardsId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockComplianceAssociatedStandardsIdBlock>? ComplianceAssociatedStandardsId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockComplianceAssociatedStandardsIdBlock>>("compliance_associated_standards_id");
        set => SetArgument("compliance_associated_standards_id", value);
    }

    /// <summary>
    /// ComplianceSecurityControlId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockComplianceSecurityControlIdBlock>? ComplianceSecurityControlId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockComplianceSecurityControlIdBlock>>("compliance_security_control_id");
        set => SetArgument("compliance_security_control_id", value);
    }

    /// <summary>
    /// ComplianceStatus block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockComplianceStatusBlock>? ComplianceStatus
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockComplianceStatusBlock>>("compliance_status");
        set => SetArgument("compliance_status", value);
    }

    /// <summary>
    /// Confidence block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockConfidenceBlock>? Confidence
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockConfidenceBlock>>("confidence");
        set => SetArgument("confidence", value);
    }

    /// <summary>
    /// CreatedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlock>? CreatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlock>>("created_at");
        set => SetArgument("created_at", value);
    }

    /// <summary>
    /// Criticality block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockCriticalityBlock>? Criticality
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockCriticalityBlock>>("criticality");
        set => SetArgument("criticality", value);
    }

    /// <summary>
    /// Description block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockDescriptionBlock>? Description
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockDescriptionBlock>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// FirstObservedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlock>? FirstObservedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlock>>("first_observed_at");
        set => SetArgument("first_observed_at", value);
    }

    /// <summary>
    /// GeneratorId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockGeneratorIdBlock>? GeneratorId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockGeneratorIdBlock>>("generator_id");
        set => SetArgument("generator_id", value);
    }

    /// <summary>
    /// Id block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockIdBlock>? Id
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockIdBlock>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// LastObservedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlock>? LastObservedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlock>>("last_observed_at");
        set => SetArgument("last_observed_at", value);
    }

    /// <summary>
    /// NoteText block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockNoteTextBlock>? NoteText
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockNoteTextBlock>>("note_text");
        set => SetArgument("note_text", value);
    }

    /// <summary>
    /// NoteUpdatedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlock>? NoteUpdatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlock>>("note_updated_at");
        set => SetArgument("note_updated_at", value);
    }

    /// <summary>
    /// NoteUpdatedBy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedByBlock>? NoteUpdatedBy
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedByBlock>>("note_updated_by");
        set => SetArgument("note_updated_by", value);
    }

    /// <summary>
    /// ProductArn block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockProductArnBlock>? ProductArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockProductArnBlock>>("product_arn");
        set => SetArgument("product_arn", value);
    }

    /// <summary>
    /// ProductName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockProductNameBlock>? ProductName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockProductNameBlock>>("product_name");
        set => SetArgument("product_name", value);
    }

    /// <summary>
    /// RecordState block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockRecordStateBlock>? RecordState
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockRecordStateBlock>>("record_state");
        set => SetArgument("record_state", value);
    }

    /// <summary>
    /// RelatedFindingsId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockRelatedFindingsIdBlock>? RelatedFindingsId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockRelatedFindingsIdBlock>>("related_findings_id");
        set => SetArgument("related_findings_id", value);
    }

    /// <summary>
    /// RelatedFindingsProductArn block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockRelatedFindingsProductArnBlock>? RelatedFindingsProductArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockRelatedFindingsProductArnBlock>>("related_findings_product_arn");
        set => SetArgument("related_findings_product_arn", value);
    }

    /// <summary>
    /// ResourceApplicationArn block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceApplicationArnBlock>? ResourceApplicationArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceApplicationArnBlock>>("resource_application_arn");
        set => SetArgument("resource_application_arn", value);
    }

    /// <summary>
    /// ResourceApplicationName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceApplicationNameBlock>? ResourceApplicationName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceApplicationNameBlock>>("resource_application_name");
        set => SetArgument("resource_application_name", value);
    }

    /// <summary>
    /// ResourceDetailsOther block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceDetailsOtherBlock>? ResourceDetailsOther
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceDetailsOtherBlock>>("resource_details_other");
        set => SetArgument("resource_details_other", value);
    }

    /// <summary>
    /// ResourceId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceIdBlock>? ResourceId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceIdBlock>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// ResourcePartition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourcePartitionBlock>? ResourcePartition
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourcePartitionBlock>>("resource_partition");
        set => SetArgument("resource_partition", value);
    }

    /// <summary>
    /// ResourceRegion block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceRegionBlock>? ResourceRegion
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceRegionBlock>>("resource_region");
        set => SetArgument("resource_region", value);
    }

    /// <summary>
    /// ResourceTags block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceTagsBlock>? ResourceTags
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceTagsBlock>>("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// ResourceTypeAttribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceTypeAttributeBlock>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockResourceTypeAttributeBlock>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// SeverityLabel block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockSeverityLabelBlock>? SeverityLabel
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockSeverityLabelBlock>>("severity_label");
        set => SetArgument("severity_label", value);
    }

    /// <summary>
    /// SourceUrl block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockSourceUrlBlock>? SourceUrl
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockSourceUrlBlock>>("source_url");
        set => SetArgument("source_url", value);
    }

    /// <summary>
    /// Title block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockTitleBlock>? Title
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockTitleBlock>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Type block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockTypeBlock>? Type
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockTypeBlock>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// UpdatedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlock>? UpdatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlock>>("updated_at");
        set => SetArgument("updated_at", value);
    }

    /// <summary>
    /// UserDefinedFields block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockUserDefinedFieldsBlock>? UserDefinedFields
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockUserDefinedFieldsBlock>>("user_defined_fields");
        set => SetArgument("user_defined_fields", value);
    }

    /// <summary>
    /// VerificationState block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockVerificationStateBlock>? VerificationState
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockVerificationStateBlock>>("verification_state");
        set => SetArgument("verification_state", value);
    }

    /// <summary>
    /// WorkflowStatus block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockWorkflowStatusBlock>? WorkflowStatus
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleCriteriaBlockWorkflowStatusBlock>>("workflow_status");
        set => SetArgument("workflow_status", value);
    }

}

/// <summary>
/// Block type for aws_account_id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockAwsAccountIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_account_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for aws_account_name in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockAwsAccountNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_account_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for company_name in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockCompanyNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "company_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for compliance_associated_standards_id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockComplianceAssociatedStandardsIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compliance_associated_standards_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for compliance_security_control_id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockComplianceSecurityControlIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compliance_security_control_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for compliance_status in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockComplianceStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compliance_status";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for confidence in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockConfidenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidence";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<double>? Eq
    {
        get => new TerraformReference<double>(this, "eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gt attribute.
    /// </summary>
    public TerraformValue<double>? Gt
    {
        get => new TerraformReference<double>(this, "gt");
        set => SetArgument("gt", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<double>? Gte
    {
        get => new TerraformReference<double>(this, "gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lt attribute.
    /// </summary>
    public TerraformValue<double>? Lt
    {
        get => new TerraformReference<double>(this, "lt");
        set => SetArgument("lt", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<double>? Lte
    {
        get => new TerraformReference<double>(this, "lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for created_at in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "created_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockCreatedAtBlockDateRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_range";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for criticality in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockCriticalityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criticality";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<double>? Eq
    {
        get => new TerraformReference<double>(this, "eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gt attribute.
    /// </summary>
    public TerraformValue<double>? Gt
    {
        get => new TerraformReference<double>(this, "gt");
        set => SetArgument("gt", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<double>? Gte
    {
        get => new TerraformReference<double>(this, "gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lt attribute.
    /// </summary>
    public TerraformValue<double>? Lt
    {
        get => new TerraformReference<double>(this, "lt");
        set => SetArgument("lt", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<double>? Lte
    {
        get => new TerraformReference<double>(this, "lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for description in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "description";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for first_observed_at in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "first_observed_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockFirstObservedAtBlockDateRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_range";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for generator_id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockGeneratorIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generator_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for last_observed_at in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "last_observed_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockLastObservedAtBlockDateRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_range";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for note_text in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockNoteTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "note_text";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for note_updated_at in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "note_updated_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedAtBlockDateRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_range";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for note_updated_by in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockNoteUpdatedByBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "note_updated_by";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for product_arn in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockProductArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "product_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for product_name in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockProductNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "product_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for record_state in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockRecordStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_state";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for related_findings_id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockRelatedFindingsIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "related_findings_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for related_findings_product_arn in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockRelatedFindingsProductArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "related_findings_product_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_application_arn in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceApplicationArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_application_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_application_name in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceApplicationNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_application_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_details_other in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceDetailsOtherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_details_other";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_id in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_partition in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourcePartitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_partition";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_region in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_region";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_tags in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_tags";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_type in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockResourceTypeAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for severity_label in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockSeverityLabelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "severity_label";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_url in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockSourceUrlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_url";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for title in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockTitleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "title";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for type in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for updated_at in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "updated_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockUpdatedAtBlockDateRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_range";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for user_defined_fields in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockUserDefinedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_defined_fields";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for verification_state in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockVerificationStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "verification_state";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for workflow_status in AwsSecurityhubAutomationRuleCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlockWorkflowStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workflow_status";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => new TerraformReference<string>(this, "comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_securityhub_automation_rule Terraform resource.
/// Manages a aws_securityhub_automation_rule resource.
/// </summary>
public partial class AwsSecurityhubAutomationRule(string name) : TerraformResource("aws_securityhub_automation_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The is_terminal attribute.
    /// </summary>
    public TerraformValue<bool> IsTerminal
    {
        get => new TerraformReference<bool>(this, "is_terminal");
        set => SetArgument("is_terminal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleOrder is required")]
    public required TerraformValue<double> RuleOrder
    {
        get => new TerraformReference<double>(this, "rule_order");
        set => SetArgument("rule_order", value);
    }

    /// <summary>
    /// The rule_status attribute.
    /// </summary>
    public TerraformValue<string> RuleStatus
    {
        get => new TerraformReference<string>(this, "rule_status");
        set => SetArgument("rule_status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Actions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecurityhubAutomationRuleActionsBlock>? Actions
    {
        get => GetArgument<TerraformSet<AwsSecurityhubAutomationRuleActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubAutomationRuleCriteriaBlock>? Criteria
    {
        get => GetArgument<TerraformList<AwsSecurityhubAutomationRuleCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

}
