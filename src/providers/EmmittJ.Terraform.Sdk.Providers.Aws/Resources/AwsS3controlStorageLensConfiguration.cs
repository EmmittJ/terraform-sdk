using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_lens_configuration in AwsS3controlStorageLensConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_lens_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// AccountLevel block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountLevel is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccountLevel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountLevel block(s) allowed")]
    public required TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock> AccountLevel
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock>>("account_level");
        set => SetArgument("account_level", value);
    }

    /// <summary>
    /// AwsOrg block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsOrg block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAwsOrgBlock>? AwsOrg
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAwsOrgBlock>>("aws_org");
        set => SetArgument("aws_org", value);
    }

    /// <summary>
    /// DataExport block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataExport block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlock>? DataExport
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlock>>("data_export");
        set => SetArgument("data_export", value);
    }

    /// <summary>
    /// Exclude block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exclude block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockExcludeBlock>? Exclude
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockExcludeBlock>>("exclude");
        set => SetArgument("exclude", value);
    }

    /// <summary>
    /// Include block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Include block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockIncludeBlock>? Include
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockIncludeBlock>>("include");
        set => SetArgument("include", value);
    }

}

/// <summary>
/// Block type for account_level in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "account_level";

    /// <summary>
    /// ActivityMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivityMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockActivityMetricsBlock>? ActivityMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockActivityMetricsBlock>>("activity_metrics");
        set => SetArgument("activity_metrics", value);
    }

    /// <summary>
    /// AdvancedCostOptimizationMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedCostOptimizationMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockAdvancedCostOptimizationMetricsBlock>? AdvancedCostOptimizationMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockAdvancedCostOptimizationMetricsBlock>>("advanced_cost_optimization_metrics");
        set => SetArgument("advanced_cost_optimization_metrics", value);
    }

    /// <summary>
    /// AdvancedDataProtectionMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedDataProtectionMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockAdvancedDataProtectionMetricsBlock>? AdvancedDataProtectionMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockAdvancedDataProtectionMetricsBlock>>("advanced_data_protection_metrics");
        set => SetArgument("advanced_data_protection_metrics", value);
    }

    /// <summary>
    /// BucketLevel block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketLevel is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BucketLevel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketLevel block(s) allowed")]
    public required TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock> BucketLevel
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock>>("bucket_level");
        set => SetArgument("bucket_level", value);
    }

    /// <summary>
    /// DetailedStatusCodeMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DetailedStatusCodeMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockDetailedStatusCodeMetricsBlock>? DetailedStatusCodeMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockDetailedStatusCodeMetricsBlock>>("detailed_status_code_metrics");
        set => SetArgument("detailed_status_code_metrics", value);
    }

}

/// <summary>
/// Block type for activity_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockActivityMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "activity_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for advanced_cost_optimization_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockAdvancedCostOptimizationMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_cost_optimization_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for advanced_data_protection_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockAdvancedDataProtectionMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_data_protection_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for bucket_level in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket_level";

    /// <summary>
    /// ActivityMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivityMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockActivityMetricsBlock>? ActivityMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockActivityMetricsBlock>>("activity_metrics");
        set => SetArgument("activity_metrics", value);
    }

    /// <summary>
    /// AdvancedCostOptimizationMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedCostOptimizationMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockAdvancedCostOptimizationMetricsBlock>? AdvancedCostOptimizationMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockAdvancedCostOptimizationMetricsBlock>>("advanced_cost_optimization_metrics");
        set => SetArgument("advanced_cost_optimization_metrics", value);
    }

    /// <summary>
    /// AdvancedDataProtectionMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedDataProtectionMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockAdvancedDataProtectionMetricsBlock>? AdvancedDataProtectionMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockAdvancedDataProtectionMetricsBlock>>("advanced_data_protection_metrics");
        set => SetArgument("advanced_data_protection_metrics", value);
    }

    /// <summary>
    /// DetailedStatusCodeMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DetailedStatusCodeMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockDetailedStatusCodeMetricsBlock>? DetailedStatusCodeMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockDetailedStatusCodeMetricsBlock>>("detailed_status_code_metrics");
        set => SetArgument("detailed_status_code_metrics", value);
    }

    /// <summary>
    /// PrefixLevel block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrefixLevel block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlock>? PrefixLevel
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlock>>("prefix_level");
        set => SetArgument("prefix_level", value);
    }

}

/// <summary>
/// Block type for activity_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockActivityMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "activity_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for advanced_cost_optimization_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockAdvancedCostOptimizationMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_cost_optimization_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for advanced_data_protection_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockAdvancedDataProtectionMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_data_protection_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for detailed_status_code_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockDetailedStatusCodeMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "detailed_status_code_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for prefix_level in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prefix_level";

    /// <summary>
    /// StorageMetrics block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMetrics is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageMetrics block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageMetrics block(s) allowed")]
    public required TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlock> StorageMetrics
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlock>>("storage_metrics");
        set => SetArgument("storage_metrics", value);
    }

}

/// <summary>
/// Block type for storage_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// SelectionCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectionCriteria block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlockSelectionCriteriaBlock>? SelectionCriteria
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlockSelectionCriteriaBlock>>("selection_criteria");
        set => SetArgument("selection_criteria", value);
    }

}

/// <summary>
/// Block type for selection_criteria in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockBucketLevelBlockPrefixLevelBlockStorageMetricsBlockSelectionCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selection_criteria";

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => GetArgument<TerraformValue<string>>("delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The max_depth attribute.
    /// </summary>
    public TerraformValue<double>? MaxDepth
    {
        get => GetArgument<TerraformValue<double>>("max_depth");
        set => SetArgument("max_depth", value);
    }

    /// <summary>
    /// The min_storage_bytes_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MinStorageBytesPercentage
    {
        get => GetArgument<TerraformValue<double>>("min_storage_bytes_percentage");
        set => SetArgument("min_storage_bytes_percentage", value);
    }

}

/// <summary>
/// Block type for detailed_status_code_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAccountLevelBlockDetailedStatusCodeMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "detailed_status_code_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for aws_org in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockAwsOrgBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_org";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for data_export in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_export";

    /// <summary>
    /// CloudWatchMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudWatchMetrics block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockCloudWatchMetricsBlock>? CloudWatchMetrics
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockCloudWatchMetricsBlock>>("cloud_watch_metrics");
        set => SetArgument("cloud_watch_metrics", value);
    }

    /// <summary>
    /// S3BucketDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3BucketDestination block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlock>? S3BucketDestination
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlock>>("s3_bucket_destination");
        set => SetArgument("s3_bucket_destination", value);
    }

}

/// <summary>
/// Block type for cloud_watch_metrics in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockCloudWatchMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_watch_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for s3_bucket_destination in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_bucket_destination";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The output_schema_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputSchemaVersion is required")]
    public required TerraformValue<string> OutputSchemaVersion
    {
        get => GetArgument<TerraformValue<string>>("output_schema_version");
        set => SetArgument("output_schema_version", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

}

/// <summary>
/// Block type for encryption in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// SseKms block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseKms block(s) allowed")]
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlockSseKmsBlock>? SseKms
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlockSseKmsBlock>>("sse_kms");
        set => SetArgument("sse_kms", value);
    }

    /// <summary>
    /// SseS3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlockSseS3Block>? SseS3
    {
        get => GetArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlockSseS3Block>>("sse_s3");
        set => SetArgument("sse_s3", value);
    }

}

/// <summary>
/// Block type for sse_kms in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlockSseKmsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_kms";

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

}

/// <summary>
/// Block type for sse_s3 in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockDataExportBlockS3BucketDestinationBlockEncryptionBlockSseS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_s3";

}

/// <summary>
/// Block type for exclude in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockExcludeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude";

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformSet<string>? Buckets
    {
        get => GetArgument<TerraformSet<string>>("buckets");
        set => SetArgument("buckets", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => GetArgument<TerraformSet<string>>("regions");
        set => SetArgument("regions", value);
    }

}

/// <summary>
/// Block type for include in AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlStorageLensConfigurationStorageLensConfigurationBlockIncludeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include";

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    public TerraformSet<string>? Buckets
    {
        get => GetArgument<TerraformSet<string>>("buckets");
        set => SetArgument("buckets", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => GetArgument<TerraformSet<string>>("regions");
        set => SetArgument("regions", value);
    }

}


/// <summary>
/// Represents a aws_s3control_storage_lens_configuration Terraform resource.
/// Manages a aws_s3control_storage_lens_configuration resource.
/// </summary>
public partial class AwsS3controlStorageLensConfiguration(string name) : TerraformResource("aws_s3control_storage_lens_configuration", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    public required TerraformValue<string> ConfigId
    {
        get => GetArgument<TerraformValue<string>>("config_id");
        set => SetArgument("config_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// StorageLensConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLensConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLensConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLensConfiguration block(s) allowed")]
    public required TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock> StorageLensConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlStorageLensConfigurationStorageLensConfigurationBlock>>("storage_lens_configuration");
        set => SetArgument("storage_lens_configuration", value);
    }

}
