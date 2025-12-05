using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsS3BucketAnalyticsConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAnalyticsConfigurationFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for storage_class_analysis in AwsS3BucketAnalyticsConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_class_analysis";

    /// <summary>
    /// DataExport block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExport is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataExport block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataExport block(s) allowed")]
    public required TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlock> DataExport
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlock>>("data_export");
        set => SetArgument("data_export", value);
    }

}

/// <summary>
/// Block type for data_export in AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_export";

    /// <summary>
    /// The output_schema_version attribute.
    /// </summary>
    public TerraformValue<string>? OutputSchemaVersion
    {
        get => GetArgument<TerraformValue<string>>("output_schema_version");
        set => SetArgument("output_schema_version", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// S3BucketDestination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3BucketDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3BucketDestination block(s) allowed")]
    public required TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlockS3BucketDestinationBlock> S3BucketDestination
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlockS3BucketDestinationBlock>>("s3_bucket_destination");
        set => SetArgument("s3_bucket_destination", value);
    }

}

/// <summary>
/// Block type for s3_bucket_destination in AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlockDataExportBlockDestinationBlockS3BucketDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_bucket_destination";

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformValue<string>? BucketAccountId
    {
        get => GetArgument<TerraformValue<string>>("bucket_account_id");
        set => SetArgument("bucket_account_id", value);
    }

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string>? Format
    {
        get => GetArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_analytics_configuration Terraform resource.
/// Manages a aws_s3_bucket_analytics_configuration resource.
/// </summary>
public partial class AwsS3BucketAnalyticsConfiguration(string name) : TerraformResource("aws_s3_bucket_analytics_configuration", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsS3BucketAnalyticsConfigurationFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3BucketAnalyticsConfigurationFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// StorageClassAnalysis block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageClassAnalysis block(s) allowed")]
    public TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlock>? StorageClassAnalysis
    {
        get => GetArgument<TerraformList<AwsS3BucketAnalyticsConfigurationStorageClassAnalysisBlock>>("storage_class_analysis");
        set => SetArgument("storage_class_analysis", value);
    }

}
