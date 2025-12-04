using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in AwsSecurityhubInsight.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// AwsAccountId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 AwsAccountId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockAwsAccountIdBlock>? AwsAccountId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockAwsAccountIdBlock>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// CompanyName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 CompanyName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockCompanyNameBlock>? CompanyName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockCompanyNameBlock>>("company_name");
        set => SetArgument("company_name", value);
    }

    /// <summary>
    /// ComplianceStatus block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ComplianceStatus block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockComplianceStatusBlock>? ComplianceStatus
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockComplianceStatusBlock>>("compliance_status");
        set => SetArgument("compliance_status", value);
    }

    /// <summary>
    /// Confidence block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Confidence block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockConfidenceBlock>? Confidence
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockConfidenceBlock>>("confidence");
        set => SetArgument("confidence", value);
    }

    /// <summary>
    /// CreatedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 CreatedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockCreatedAtBlock>? CreatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockCreatedAtBlock>>("created_at");
        set => SetArgument("created_at", value);
    }

    /// <summary>
    /// Criticality block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Criticality block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockCriticalityBlock>? Criticality
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockCriticalityBlock>>("criticality");
        set => SetArgument("criticality", value);
    }

    /// <summary>
    /// Description block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Description block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockDescriptionBlock>? Description
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockDescriptionBlock>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// FindingProviderFieldsConfidence block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsConfidence block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsConfidenceBlock>? FindingProviderFieldsConfidence
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsConfidenceBlock>>("finding_provider_fields_confidence");
        set => SetArgument("finding_provider_fields_confidence", value);
    }

    /// <summary>
    /// FindingProviderFieldsCriticality block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsCriticality block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsCriticalityBlock>? FindingProviderFieldsCriticality
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsCriticalityBlock>>("finding_provider_fields_criticality");
        set => SetArgument("finding_provider_fields_criticality", value);
    }

    /// <summary>
    /// FindingProviderFieldsRelatedFindingsId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsRelatedFindingsId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsRelatedFindingsIdBlock>? FindingProviderFieldsRelatedFindingsId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsRelatedFindingsIdBlock>>("finding_provider_fields_related_findings_id");
        set => SetArgument("finding_provider_fields_related_findings_id", value);
    }

    /// <summary>
    /// FindingProviderFieldsRelatedFindingsProductArn block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsRelatedFindingsProductArn block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsRelatedFindingsProductArnBlock>? FindingProviderFieldsRelatedFindingsProductArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsRelatedFindingsProductArnBlock>>("finding_provider_fields_related_findings_product_arn");
        set => SetArgument("finding_provider_fields_related_findings_product_arn", value);
    }

    /// <summary>
    /// FindingProviderFieldsSeverityLabel block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsSeverityLabel block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsSeverityLabelBlock>? FindingProviderFieldsSeverityLabel
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsSeverityLabelBlock>>("finding_provider_fields_severity_label");
        set => SetArgument("finding_provider_fields_severity_label", value);
    }

    /// <summary>
    /// FindingProviderFieldsSeverityOriginal block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsSeverityOriginal block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsSeverityOriginalBlock>? FindingProviderFieldsSeverityOriginal
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsSeverityOriginalBlock>>("finding_provider_fields_severity_original");
        set => SetArgument("finding_provider_fields_severity_original", value);
    }

    /// <summary>
    /// FindingProviderFieldsTypes block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FindingProviderFieldsTypes block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsTypesBlock>? FindingProviderFieldsTypes
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFindingProviderFieldsTypesBlock>>("finding_provider_fields_types");
        set => SetArgument("finding_provider_fields_types", value);
    }

    /// <summary>
    /// FirstObservedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 FirstObservedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockFirstObservedAtBlock>? FirstObservedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockFirstObservedAtBlock>>("first_observed_at");
        set => SetArgument("first_observed_at", value);
    }

    /// <summary>
    /// GeneratorId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 GeneratorId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockGeneratorIdBlock>? GeneratorId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockGeneratorIdBlock>>("generator_id");
        set => SetArgument("generator_id", value);
    }

    /// <summary>
    /// Id block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Id block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockIdBlock>? Id
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockIdBlock>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Keyword block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Keyword block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockKeywordBlock>? Keyword
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockKeywordBlock>>("keyword");
        set => SetArgument("keyword", value);
    }

    /// <summary>
    /// LastObservedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 LastObservedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockLastObservedAtBlock>? LastObservedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockLastObservedAtBlock>>("last_observed_at");
        set => SetArgument("last_observed_at", value);
    }

    /// <summary>
    /// MalwareName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 MalwareName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockMalwareNameBlock>? MalwareName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockMalwareNameBlock>>("malware_name");
        set => SetArgument("malware_name", value);
    }

    /// <summary>
    /// MalwarePath block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 MalwarePath block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockMalwarePathBlock>? MalwarePath
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockMalwarePathBlock>>("malware_path");
        set => SetArgument("malware_path", value);
    }

    /// <summary>
    /// MalwareState block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 MalwareState block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockMalwareStateBlock>? MalwareState
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockMalwareStateBlock>>("malware_state");
        set => SetArgument("malware_state", value);
    }

    /// <summary>
    /// MalwareType block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 MalwareType block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockMalwareTypeBlock>? MalwareType
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockMalwareTypeBlock>>("malware_type");
        set => SetArgument("malware_type", value);
    }

    /// <summary>
    /// NetworkDestinationDomain block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkDestinationDomain block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationDomainBlock>? NetworkDestinationDomain
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationDomainBlock>>("network_destination_domain");
        set => SetArgument("network_destination_domain", value);
    }

    /// <summary>
    /// NetworkDestinationIpv4 block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkDestinationIpv4 block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationIpv4Block>? NetworkDestinationIpv4
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationIpv4Block>>("network_destination_ipv4");
        set => SetArgument("network_destination_ipv4", value);
    }

    /// <summary>
    /// NetworkDestinationIpv6 block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkDestinationIpv6 block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationIpv6Block>? NetworkDestinationIpv6
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationIpv6Block>>("network_destination_ipv6");
        set => SetArgument("network_destination_ipv6", value);
    }

    /// <summary>
    /// NetworkDestinationPort block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkDestinationPort block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationPortBlock>? NetworkDestinationPort
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDestinationPortBlock>>("network_destination_port");
        set => SetArgument("network_destination_port", value);
    }

    /// <summary>
    /// NetworkDirection block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkDirection block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDirectionBlock>? NetworkDirection
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkDirectionBlock>>("network_direction");
        set => SetArgument("network_direction", value);
    }

    /// <summary>
    /// NetworkProtocol block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkProtocol block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkProtocolBlock>? NetworkProtocol
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkProtocolBlock>>("network_protocol");
        set => SetArgument("network_protocol", value);
    }

    /// <summary>
    /// NetworkSourceDomain block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkSourceDomain block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceDomainBlock>? NetworkSourceDomain
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceDomainBlock>>("network_source_domain");
        set => SetArgument("network_source_domain", value);
    }

    /// <summary>
    /// NetworkSourceIpv4 block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkSourceIpv4 block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceIpv4Block>? NetworkSourceIpv4
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceIpv4Block>>("network_source_ipv4");
        set => SetArgument("network_source_ipv4", value);
    }

    /// <summary>
    /// NetworkSourceIpv6 block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkSourceIpv6 block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceIpv6Block>? NetworkSourceIpv6
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceIpv6Block>>("network_source_ipv6");
        set => SetArgument("network_source_ipv6", value);
    }

    /// <summary>
    /// NetworkSourceMac block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkSourceMac block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceMacBlock>? NetworkSourceMac
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourceMacBlock>>("network_source_mac");
        set => SetArgument("network_source_mac", value);
    }

    /// <summary>
    /// NetworkSourcePort block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NetworkSourcePort block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourcePortBlock>? NetworkSourcePort
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNetworkSourcePortBlock>>("network_source_port");
        set => SetArgument("network_source_port", value);
    }

    /// <summary>
    /// NoteText block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NoteText block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNoteTextBlock>? NoteText
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNoteTextBlock>>("note_text");
        set => SetArgument("note_text", value);
    }

    /// <summary>
    /// NoteUpdatedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NoteUpdatedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlock>? NoteUpdatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlock>>("note_updated_at");
        set => SetArgument("note_updated_at", value);
    }

    /// <summary>
    /// NoteUpdatedBy block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 NoteUpdatedBy block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockNoteUpdatedByBlock>? NoteUpdatedBy
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockNoteUpdatedByBlock>>("note_updated_by");
        set => SetArgument("note_updated_by", value);
    }

    /// <summary>
    /// ProcessLaunchedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProcessLaunchedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlock>? ProcessLaunchedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlock>>("process_launched_at");
        set => SetArgument("process_launched_at", value);
    }

    /// <summary>
    /// ProcessName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProcessName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProcessNameBlock>? ProcessName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProcessNameBlock>>("process_name");
        set => SetArgument("process_name", value);
    }

    /// <summary>
    /// ProcessParentPid block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProcessParentPid block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProcessParentPidBlock>? ProcessParentPid
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProcessParentPidBlock>>("process_parent_pid");
        set => SetArgument("process_parent_pid", value);
    }

    /// <summary>
    /// ProcessPath block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProcessPath block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProcessPathBlock>? ProcessPath
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProcessPathBlock>>("process_path");
        set => SetArgument("process_path", value);
    }

    /// <summary>
    /// ProcessPid block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProcessPid block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProcessPidBlock>? ProcessPid
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProcessPidBlock>>("process_pid");
        set => SetArgument("process_pid", value);
    }

    /// <summary>
    /// ProcessTerminatedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProcessTerminatedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlock>? ProcessTerminatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlock>>("process_terminated_at");
        set => SetArgument("process_terminated_at", value);
    }

    /// <summary>
    /// ProductArn block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProductArn block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProductArnBlock>? ProductArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProductArnBlock>>("product_arn");
        set => SetArgument("product_arn", value);
    }

    /// <summary>
    /// ProductFields block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProductFields block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProductFieldsBlock>? ProductFields
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProductFieldsBlock>>("product_fields");
        set => SetArgument("product_fields", value);
    }

    /// <summary>
    /// ProductName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ProductName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockProductNameBlock>? ProductName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockProductNameBlock>>("product_name");
        set => SetArgument("product_name", value);
    }

    /// <summary>
    /// RecommendationText block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 RecommendationText block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockRecommendationTextBlock>? RecommendationText
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockRecommendationTextBlock>>("recommendation_text");
        set => SetArgument("recommendation_text", value);
    }

    /// <summary>
    /// RecordState block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 RecordState block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockRecordStateBlock>? RecordState
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockRecordStateBlock>>("record_state");
        set => SetArgument("record_state", value);
    }

    /// <summary>
    /// RelatedFindingsId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 RelatedFindingsId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockRelatedFindingsIdBlock>? RelatedFindingsId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockRelatedFindingsIdBlock>>("related_findings_id");
        set => SetArgument("related_findings_id", value);
    }

    /// <summary>
    /// RelatedFindingsProductArn block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 RelatedFindingsProductArn block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockRelatedFindingsProductArnBlock>? RelatedFindingsProductArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockRelatedFindingsProductArnBlock>>("related_findings_product_arn");
        set => SetArgument("related_findings_product_arn", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceIamInstanceProfileArn block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceIamInstanceProfileArn block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIamInstanceProfileArnBlock>? ResourceAwsEc2InstanceIamInstanceProfileArn
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIamInstanceProfileArnBlock>>("resource_aws_ec2_instance_iam_instance_profile_arn");
        set => SetArgument("resource_aws_ec2_instance_iam_instance_profile_arn", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceImageId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceImageId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceImageIdBlock>? ResourceAwsEc2InstanceImageId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceImageIdBlock>>("resource_aws_ec2_instance_image_id");
        set => SetArgument("resource_aws_ec2_instance_image_id", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceIpv4Addresses block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceIpv4Addresses block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIpv4AddressesBlock>? ResourceAwsEc2InstanceIpv4Addresses
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIpv4AddressesBlock>>("resource_aws_ec2_instance_ipv4_addresses");
        set => SetArgument("resource_aws_ec2_instance_ipv4_addresses", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceIpv6Addresses block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceIpv6Addresses block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIpv6AddressesBlock>? ResourceAwsEc2InstanceIpv6Addresses
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIpv6AddressesBlock>>("resource_aws_ec2_instance_ipv6_addresses");
        set => SetArgument("resource_aws_ec2_instance_ipv6_addresses", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceKeyName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceKeyName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceKeyNameBlock>? ResourceAwsEc2InstanceKeyName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceKeyNameBlock>>("resource_aws_ec2_instance_key_name");
        set => SetArgument("resource_aws_ec2_instance_key_name", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceLaunchedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceLaunchedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlock>? ResourceAwsEc2InstanceLaunchedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlock>>("resource_aws_ec2_instance_launched_at");
        set => SetArgument("resource_aws_ec2_instance_launched_at", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceSubnetId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceSubnetId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceSubnetIdBlock>? ResourceAwsEc2InstanceSubnetId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceSubnetIdBlock>>("resource_aws_ec2_instance_subnet_id");
        set => SetArgument("resource_aws_ec2_instance_subnet_id", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceType block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceType block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceTypeBlock>? ResourceAwsEc2InstanceType
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceTypeBlock>>("resource_aws_ec2_instance_type");
        set => SetArgument("resource_aws_ec2_instance_type", value);
    }

    /// <summary>
    /// ResourceAwsEc2InstanceVpcId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsEc2InstanceVpcId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceVpcIdBlock>? ResourceAwsEc2InstanceVpcId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceVpcIdBlock>>("resource_aws_ec2_instance_vpc_id");
        set => SetArgument("resource_aws_ec2_instance_vpc_id", value);
    }

    /// <summary>
    /// ResourceAwsIamAccessKeyCreatedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsIamAccessKeyCreatedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlock>? ResourceAwsIamAccessKeyCreatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlock>>("resource_aws_iam_access_key_created_at");
        set => SetArgument("resource_aws_iam_access_key_created_at", value);
    }

    /// <summary>
    /// ResourceAwsIamAccessKeyStatus block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsIamAccessKeyStatus block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyStatusBlock>? ResourceAwsIamAccessKeyStatus
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyStatusBlock>>("resource_aws_iam_access_key_status");
        set => SetArgument("resource_aws_iam_access_key_status", value);
    }

    /// <summary>
    /// ResourceAwsIamAccessKeyUserName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsIamAccessKeyUserName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyUserNameBlock>? ResourceAwsIamAccessKeyUserName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyUserNameBlock>>("resource_aws_iam_access_key_user_name");
        set => SetArgument("resource_aws_iam_access_key_user_name", value);
    }

    /// <summary>
    /// ResourceAwsS3BucketOwnerId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsS3BucketOwnerId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsS3BucketOwnerIdBlock>? ResourceAwsS3BucketOwnerId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsS3BucketOwnerIdBlock>>("resource_aws_s3_bucket_owner_id");
        set => SetArgument("resource_aws_s3_bucket_owner_id", value);
    }

    /// <summary>
    /// ResourceAwsS3BucketOwnerName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceAwsS3BucketOwnerName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsS3BucketOwnerNameBlock>? ResourceAwsS3BucketOwnerName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceAwsS3BucketOwnerNameBlock>>("resource_aws_s3_bucket_owner_name");
        set => SetArgument("resource_aws_s3_bucket_owner_name", value);
    }

    /// <summary>
    /// ResourceContainerImageId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceContainerImageId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerImageIdBlock>? ResourceContainerImageId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerImageIdBlock>>("resource_container_image_id");
        set => SetArgument("resource_container_image_id", value);
    }

    /// <summary>
    /// ResourceContainerImageName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceContainerImageName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerImageNameBlock>? ResourceContainerImageName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerImageNameBlock>>("resource_container_image_name");
        set => SetArgument("resource_container_image_name", value);
    }

    /// <summary>
    /// ResourceContainerLaunchedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceContainerLaunchedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlock>? ResourceContainerLaunchedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlock>>("resource_container_launched_at");
        set => SetArgument("resource_container_launched_at", value);
    }

    /// <summary>
    /// ResourceContainerName block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceContainerName block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerNameBlock>? ResourceContainerName
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceContainerNameBlock>>("resource_container_name");
        set => SetArgument("resource_container_name", value);
    }

    /// <summary>
    /// ResourceDetailsOther block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceDetailsOther block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceDetailsOtherBlock>? ResourceDetailsOther
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceDetailsOtherBlock>>("resource_details_other");
        set => SetArgument("resource_details_other", value);
    }

    /// <summary>
    /// ResourceId block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceId block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceIdBlock>? ResourceId
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceIdBlock>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// ResourcePartition block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourcePartition block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourcePartitionBlock>? ResourcePartition
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourcePartitionBlock>>("resource_partition");
        set => SetArgument("resource_partition", value);
    }

    /// <summary>
    /// ResourceRegion block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceRegion block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceRegionBlock>? ResourceRegion
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceRegionBlock>>("resource_region");
        set => SetArgument("resource_region", value);
    }

    /// <summary>
    /// ResourceTags block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceTags block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceTagsBlock>? ResourceTags
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceTagsBlock>>("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// ResourceTypeAttribute block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ResourceTypeAttribute block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockResourceTypeAttributeBlock>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockResourceTypeAttributeBlock>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// SeverityLabel block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 SeverityLabel block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockSeverityLabelBlock>? SeverityLabel
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockSeverityLabelBlock>>("severity_label");
        set => SetArgument("severity_label", value);
    }

    /// <summary>
    /// SourceUrl block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 SourceUrl block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockSourceUrlBlock>? SourceUrl
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockSourceUrlBlock>>("source_url");
        set => SetArgument("source_url", value);
    }

    /// <summary>
    /// ThreatIntelIndicatorCategory block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ThreatIntelIndicatorCategory block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorCategoryBlock>? ThreatIntelIndicatorCategory
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorCategoryBlock>>("threat_intel_indicator_category");
        set => SetArgument("threat_intel_indicator_category", value);
    }

    /// <summary>
    /// ThreatIntelIndicatorLastObservedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ThreatIntelIndicatorLastObservedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlock>? ThreatIntelIndicatorLastObservedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlock>>("threat_intel_indicator_last_observed_at");
        set => SetArgument("threat_intel_indicator_last_observed_at", value);
    }

    /// <summary>
    /// ThreatIntelIndicatorSource block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ThreatIntelIndicatorSource block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorSourceBlock>? ThreatIntelIndicatorSource
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorSourceBlock>>("threat_intel_indicator_source");
        set => SetArgument("threat_intel_indicator_source", value);
    }

    /// <summary>
    /// ThreatIntelIndicatorSourceUrl block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ThreatIntelIndicatorSourceUrl block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorSourceUrlBlock>? ThreatIntelIndicatorSourceUrl
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorSourceUrlBlock>>("threat_intel_indicator_source_url");
        set => SetArgument("threat_intel_indicator_source_url", value);
    }

    /// <summary>
    /// ThreatIntelIndicatorType block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ThreatIntelIndicatorType block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorTypeBlock>? ThreatIntelIndicatorType
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorTypeBlock>>("threat_intel_indicator_type");
        set => SetArgument("threat_intel_indicator_type", value);
    }

    /// <summary>
    /// ThreatIntelIndicatorValue block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 ThreatIntelIndicatorValue block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorValueBlock>? ThreatIntelIndicatorValue
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorValueBlock>>("threat_intel_indicator_value");
        set => SetArgument("threat_intel_indicator_value", value);
    }

    /// <summary>
    /// Title block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Title block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockTitleBlock>? Title
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockTitleBlock>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Type block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Type block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockTypeBlock>? Type
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockTypeBlock>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// UpdatedAt block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 UpdatedAt block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockUpdatedAtBlock>? UpdatedAt
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockUpdatedAtBlock>>("updated_at");
        set => SetArgument("updated_at", value);
    }

    /// <summary>
    /// UserDefinedValues block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 UserDefinedValues block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockUserDefinedValuesBlock>? UserDefinedValues
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockUserDefinedValuesBlock>>("user_defined_values");
        set => SetArgument("user_defined_values", value);
    }

    /// <summary>
    /// VerificationState block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 VerificationState block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockVerificationStateBlock>? VerificationState
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockVerificationStateBlock>>("verification_state");
        set => SetArgument("verification_state", value);
    }

    /// <summary>
    /// WorkflowStatus block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 WorkflowStatus block(s) allowed")]
    public TerraformSet<AwsSecurityhubInsightFiltersBlockWorkflowStatusBlock>? WorkflowStatus
    {
        get => GetArgument<TerraformSet<AwsSecurityhubInsightFiltersBlockWorkflowStatusBlock>>("workflow_status");
        set => SetArgument("workflow_status", value);
    }

}

/// <summary>
/// Block type for aws_account_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockAwsAccountIdBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for company_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockCompanyNameBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for compliance_status in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockComplianceStatusBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for confidence in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockConfidenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidence";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for created_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockCreatedAtBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockCreatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockCreatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockCreatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockCreatedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for criticality in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockCriticalityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criticality";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for description in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockDescriptionBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_confidence in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsConfidenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_confidence";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_criticality in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsCriticalityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_criticality";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_related_findings_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsRelatedFindingsIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_related_findings_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_related_findings_product_arn in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsRelatedFindingsProductArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_related_findings_product_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_severity_label in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsSeverityLabelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_severity_label";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_severity_original in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsSeverityOriginalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_severity_original";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_provider_fields_types in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFindingProviderFieldsTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_provider_fields_types";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for first_observed_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFirstObservedAtBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockFirstObservedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockFirstObservedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockFirstObservedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockFirstObservedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for generator_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockGeneratorIdBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockIdBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for keyword in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockKeywordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "keyword";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for last_observed_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockLastObservedAtBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockLastObservedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockLastObservedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockLastObservedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockLastObservedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for malware_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockMalwareNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "malware_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for malware_path in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockMalwarePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "malware_path";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for malware_state in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockMalwareStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "malware_state";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for malware_type in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockMalwareTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "malware_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for network_destination_domain in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkDestinationDomainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_destination_domain";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for network_destination_ipv4 in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkDestinationIpv4Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_destination_ipv4";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

}

/// <summary>
/// Block type for network_destination_ipv6 in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkDestinationIpv6Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_destination_ipv6";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

}

/// <summary>
/// Block type for network_destination_port in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkDestinationPortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_destination_port";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for network_direction in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkDirectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_direction";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for network_protocol in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkProtocolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_protocol";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for network_source_domain in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkSourceDomainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_source_domain";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for network_source_ipv4 in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkSourceIpv4Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_source_ipv4";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

}

/// <summary>
/// Block type for network_source_ipv6 in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkSourceIpv6Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_source_ipv6";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

}

/// <summary>
/// Block type for network_source_mac in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkSourceMacBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_source_mac";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for network_source_port in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNetworkSourcePortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_source_port";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for note_text in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNoteTextBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for note_updated_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNoteUpdatedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for note_updated_by in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockNoteUpdatedByBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for process_launched_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_launched_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessLaunchedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for process_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for process_parent_pid in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessParentPidBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_parent_pid";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for process_path in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_path";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for process_pid in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessPidBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_pid";

    /// <summary>
    /// The eq attribute.
    /// </summary>
    public TerraformValue<string>? Eq
    {
        get => GetArgument<TerraformValue<string>>("eq");
        set => SetArgument("eq", value);
    }

    /// <summary>
    /// The gte attribute.
    /// </summary>
    public TerraformValue<string>? Gte
    {
        get => GetArgument<TerraformValue<string>>("gte");
        set => SetArgument("gte", value);
    }

    /// <summary>
    /// The lte attribute.
    /// </summary>
    public TerraformValue<string>? Lte
    {
        get => GetArgument<TerraformValue<string>>("lte");
        set => SetArgument("lte", value);
    }

}

/// <summary>
/// Block type for process_terminated_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_terminated_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProcessTerminatedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for product_arn in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProductArnBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for product_fields in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProductFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "product_fields";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for product_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockProductNameBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for recommendation_text in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockRecommendationTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recommendation_text";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for record_state in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockRecordStateBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for related_findings_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockRelatedFindingsIdBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for related_findings_product_arn in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockRelatedFindingsProductArnBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_iam_instance_profile_arn in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIamInstanceProfileArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_iam_instance_profile_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_image_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceImageIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_image_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_ipv4_addresses in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIpv4AddressesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_ipv4_addresses";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_ipv6_addresses in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceIpv6AddressesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_ipv6_addresses";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_key_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceKeyNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_key_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_launched_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_launched_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceLaunchedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_subnet_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceSubnetIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_subnet_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_type in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_ec2_instance_vpc_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsEc2InstanceVpcIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_ec2_instance_vpc_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_iam_access_key_created_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_iam_access_key_created_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyCreatedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_iam_access_key_status in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_iam_access_key_status";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_iam_access_key_user_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsIamAccessKeyUserNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_iam_access_key_user_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_s3_bucket_owner_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsS3BucketOwnerIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_s3_bucket_owner_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_aws_s3_bucket_owner_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceAwsS3BucketOwnerNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_aws_s3_bucket_owner_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_container_image_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceContainerImageIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_container_image_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_container_image_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceContainerImageNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_container_image_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_container_launched_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_container_launched_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceContainerLaunchedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_container_name in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceContainerNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_container_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_details_other in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceDetailsOtherBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_id in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceIdBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_partition in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourcePartitionBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_region in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceRegionBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_tags in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceTagsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_type in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockResourceTypeAttributeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for severity_label in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockSeverityLabelBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_url in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockSourceUrlBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threat_intel_indicator_category in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intel_indicator_category";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threat_intel_indicator_last_observed_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intel_indicator_last_observed_at";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorLastObservedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threat_intel_indicator_source in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intel_indicator_source";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threat_intel_indicator_source_url in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorSourceUrlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intel_indicator_source_url";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threat_intel_indicator_type in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intel_indicator_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for threat_intel_indicator_value in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockThreatIntelIndicatorValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intel_indicator_value";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for title in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockTitleBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for type in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockTypeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for updated_at in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockUpdatedAtBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// DateRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateRange block(s) allowed")]
    public TerraformList<AwsSecurityhubInsightFiltersBlockUpdatedAtBlockDateRangeBlock>? DateRange
    {
        get => GetArgument<TerraformList<AwsSecurityhubInsightFiltersBlockUpdatedAtBlockDateRangeBlock>>("date_range");
        set => SetArgument("date_range", value);
    }

}

/// <summary>
/// Block type for date_range in AwsSecurityhubInsightFiltersBlockUpdatedAtBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubInsightFiltersBlockUpdatedAtBlockDateRangeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for user_defined_values in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockUserDefinedValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_defined_values";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for verification_state in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockVerificationStateBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for workflow_status in AwsSecurityhubInsightFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubInsightFiltersBlockWorkflowStatusBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_securityhub_insight Terraform resource.
/// Manages a aws_securityhub_insight resource.
/// </summary>
public partial class AwsSecurityhubInsight(string name) : TerraformResource("aws_securityhub_insight", name)
{
    /// <summary>
    /// The group_by_attribute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupByAttribute is required")]
    public required TerraformValue<string> GroupByAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_by_attribute");
        set => SetArgument("group_by_attribute", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Filters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filters block(s) allowed")]
    public required TerraformList<AwsSecurityhubInsightFiltersBlock> Filters
    {
        get => GetRequiredArgument<TerraformList<AwsSecurityhubInsightFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}
