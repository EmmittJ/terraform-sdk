using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for matching in AwsCustomerprofilesDomain.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matching";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// AutoMerging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoMerging block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlockAutoMergingBlock>? AutoMerging
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlockAutoMergingBlock>>("auto_merging");
        set => SetArgument("auto_merging", value);
    }

    /// <summary>
    /// ExportingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportingConfig block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlockExportingConfigBlock>? ExportingConfig
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlockExportingConfigBlock>>("exporting_config");
        set => SetArgument("exporting_config", value);
    }

    /// <summary>
    /// JobSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobSchedule block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlockJobScheduleBlock>? JobSchedule
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlockJobScheduleBlock>>("job_schedule");
        set => SetArgument("job_schedule", value);
    }

}

/// <summary>
/// Block type for auto_merging in AwsCustomerprofilesDomainMatchingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlockAutoMergingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_merging";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The min_allowed_confidence_score_for_merging attribute.
    /// </summary>
    public TerraformValue<double>? MinAllowedConfidenceScoreForMerging
    {
        get => GetArgument<TerraformValue<double>>("min_allowed_confidence_score_for_merging");
        set => SetArgument("min_allowed_confidence_score_for_merging", value);
    }

    /// <summary>
    /// ConflictResolution block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolution block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlockAutoMergingBlockConflictResolutionBlock>? ConflictResolution
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlockAutoMergingBlockConflictResolutionBlock>>("conflict_resolution");
        set => SetArgument("conflict_resolution", value);
    }

    /// <summary>
    /// Consolidation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Consolidation block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlockAutoMergingBlockConsolidationBlock>? Consolidation
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlockAutoMergingBlockConsolidationBlock>>("consolidation");
        set => SetArgument("consolidation", value);
    }

}

/// <summary>
/// Block type for conflict_resolution in AwsCustomerprofilesDomainMatchingBlockAutoMergingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlockAutoMergingBlockConflictResolutionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conflict_resolution";

    /// <summary>
    /// The conflict_resolving_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConflictResolvingModel is required")]
    public required TerraformValue<string> ConflictResolvingModel
    {
        get => GetRequiredArgument<TerraformValue<string>>("conflict_resolving_model");
        set => SetArgument("conflict_resolving_model", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public TerraformValue<string>? SourceName
    {
        get => GetArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

}

/// <summary>
/// Block type for consolidation in AwsCustomerprofilesDomainMatchingBlockAutoMergingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlockAutoMergingBlockConsolidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consolidation";

    /// <summary>
    /// The matching_attributes_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingAttributesList is required")]
    public TerraformList<TerraformList<string>>? MatchingAttributesList
    {
        get => GetArgument<TerraformList<TerraformList<string>>>("matching_attributes_list");
        set => SetArgument("matching_attributes_list", value);
    }

}

/// <summary>
/// Block type for exporting_config in AwsCustomerprofilesDomainMatchingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlockExportingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exporting_config";

    /// <summary>
    /// S3Exporting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Exporting block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlockExportingConfigBlockS3ExportingBlock>? S3Exporting
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlockExportingConfigBlockS3ExportingBlock>>("s3_exporting");
        set => SetArgument("s3_exporting", value);
    }

}

/// <summary>
/// Block type for s3_exporting in AwsCustomerprofilesDomainMatchingBlockExportingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlockExportingConfigBlockS3ExportingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_exporting";

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_name attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyName
    {
        get => GetArgument<TerraformValue<string>>("s3_key_name");
        set => SetArgument("s3_key_name", value);
    }

}

/// <summary>
/// Block type for job_schedule in AwsCustomerprofilesDomainMatchingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlockJobScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_schedule";

    /// <summary>
    /// The day_of_the_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfTheWeek is required")]
    public required TerraformValue<string> DayOfTheWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_the_week");
        set => SetArgument("day_of_the_week", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => GetRequiredArgument<TerraformValue<string>>("time");
        set => SetArgument("time", value);
    }

}


/// <summary>
/// Block type for rule_based_matching in AwsCustomerprofilesDomain.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_based_matching";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The max_allowed_rule_level_for_matching attribute.
    /// </summary>
    public TerraformValue<double>? MaxAllowedRuleLevelForMatching
    {
        get => GetArgument<TerraformValue<double>>("max_allowed_rule_level_for_matching");
        set => SetArgument("max_allowed_rule_level_for_matching", value);
    }

    /// <summary>
    /// The max_allowed_rule_level_for_merging attribute.
    /// </summary>
    public TerraformValue<double>? MaxAllowedRuleLevelForMerging
    {
        get => GetArgument<TerraformValue<double>>("max_allowed_rule_level_for_merging");
        set => SetArgument("max_allowed_rule_level_for_merging", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? CreateReference("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// AttributeTypesSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttributeTypesSelector block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockAttributeTypesSelectorBlock>? AttributeTypesSelector
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockAttributeTypesSelectorBlock>>("attribute_types_selector");
        set => SetArgument("attribute_types_selector", value);
    }

    /// <summary>
    /// ConflictResolution block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolution block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockConflictResolutionBlock>? ConflictResolution
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockConflictResolutionBlock>>("conflict_resolution");
        set => SetArgument("conflict_resolution", value);
    }

    /// <summary>
    /// ExportingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportingConfig block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlock>? ExportingConfig
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlock>>("exporting_config");
        set => SetArgument("exporting_config", value);
    }

    /// <summary>
    /// MatchingRules block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCustomerprofilesDomainRuleBasedMatchingBlockMatchingRulesBlock>? MatchingRules
    {
        get => GetArgument<TerraformSet<AwsCustomerprofilesDomainRuleBasedMatchingBlockMatchingRulesBlock>>("matching_rules");
        set => SetArgument("matching_rules", value);
    }

}

/// <summary>
/// Block type for attribute_types_selector in AwsCustomerprofilesDomainRuleBasedMatchingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlockAttributeTypesSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute_types_selector";

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformList<string>? Address
    {
        get => GetArgument<TerraformList<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The attribute_matching_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeMatchingModel is required")]
    public required TerraformValue<string> AttributeMatchingModel
    {
        get => GetRequiredArgument<TerraformValue<string>>("attribute_matching_model");
        set => SetArgument("attribute_matching_model", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformList<string>? EmailAddress
    {
        get => GetArgument<TerraformList<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformList<string>? PhoneNumber
    {
        get => GetArgument<TerraformList<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for conflict_resolution in AwsCustomerprofilesDomainRuleBasedMatchingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlockConflictResolutionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conflict_resolution";

    /// <summary>
    /// The conflict_resolving_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConflictResolvingModel is required")]
    public required TerraformValue<string> ConflictResolvingModel
    {
        get => GetRequiredArgument<TerraformValue<string>>("conflict_resolving_model");
        set => SetArgument("conflict_resolving_model", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public TerraformValue<string>? SourceName
    {
        get => GetArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

}

/// <summary>
/// Block type for exporting_config in AwsCustomerprofilesDomainRuleBasedMatchingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exporting_config";

    /// <summary>
    /// S3Exporting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Exporting block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlockS3ExportingBlock>? S3Exporting
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlockS3ExportingBlock>>("s3_exporting");
        set => SetArgument("s3_exporting", value);
    }

}

/// <summary>
/// Block type for s3_exporting in AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlockExportingConfigBlockS3ExportingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_exporting";

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_name attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyName
    {
        get => GetArgument<TerraformValue<string>>("s3_key_name");
        set => SetArgument("s3_key_name", value);
    }

}

/// <summary>
/// Block type for matching_rules in AwsCustomerprofilesDomainRuleBasedMatchingBlock.
/// Nesting mode: set
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlockMatchingRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matching_rules";

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public TerraformList<string>? Rule
    {
        get => GetArgument<TerraformList<string>>("rule");
        set => SetArgument("rule", value);
    }

}


/// <summary>
/// Represents a aws_customerprofiles_domain Terraform resource.
/// Manages a aws_customerprofiles_domain resource.
/// </summary>
public partial class AwsCustomerprofilesDomain(string name) : TerraformResource("aws_customerprofiles_domain", name)
{
    /// <summary>
    /// The dead_letter_queue_url attribute.
    /// </summary>
    public TerraformValue<string>? DeadLetterQueueUrl
    {
        get => GetArgument<TerraformValue<string>>("dead_letter_queue_url");
        set => SetArgument("dead_letter_queue_url", value);
    }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    public TerraformValue<string>? DefaultEncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("default_encryption_key");
        set => SetArgument("default_encryption_key", value);
    }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultExpirationDays is required")]
    public required TerraformValue<double> DefaultExpirationDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("default_expiration_days");
        set => SetArgument("default_expiration_days", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// Matching block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Matching block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainMatchingBlock>? Matching
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainMatchingBlock>>("matching");
        set => SetArgument("matching", value);
    }

    /// <summary>
    /// RuleBasedMatching block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleBasedMatching block(s) allowed")]
    public TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlock>? RuleBasedMatching
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesDomainRuleBasedMatchingBlock>>("rule_based_matching");
        set => SetArgument("rule_based_matching", value);
    }

}
