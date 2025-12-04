using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in AwsAppfabricIngestionDestination.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_configuration";

    /// <summary>
    /// AuditLog block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlock>? AuditLog
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlock>>("audit_log");
        set => SetArgument("audit_log", value);
    }

}

/// <summary>
/// Block type for audit_log in AwsAppfabricIngestionDestinationDestinationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_log";

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// FirehoseStream block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlockFirehoseStreamBlock>? FirehoseStream
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlockFirehoseStreamBlock>>("firehose_stream");
        set => SetArgument("firehose_stream", value);
    }

    /// <summary>
    /// S3Bucket block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlockS3BucketBlock>? S3Bucket
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlockS3BucketBlock>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

}

/// <summary>
/// Block type for firehose_stream in AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlockFirehoseStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose_stream";

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stream_name");
        set => SetArgument("stream_name", value);
    }

}

/// <summary>
/// Block type for s3_bucket in AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationDestinationConfigurationBlockAuditLogBlockDestinationBlockS3BucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_bucket";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
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
/// Block type for processing_configuration in AwsAppfabricIngestionDestination.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// AuditLog block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationProcessingConfigurationBlockAuditLogBlock>? AuditLog
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationProcessingConfigurationBlockAuditLogBlock>>("audit_log");
        set => SetArgument("audit_log", value);
    }

}

/// <summary>
/// Block type for audit_log in AwsAppfabricIngestionDestinationProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricIngestionDestinationProcessingConfigurationBlockAuditLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_log";

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => GetRequiredArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAppfabricIngestionDestination.
/// Nesting mode: single
/// </summary>
public class AwsAppfabricIngestionDestinationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_appfabric_ingestion_destination Terraform resource.
/// Manages a aws_appfabric_ingestion_destination resource.
/// </summary>
public partial class AwsAppfabricIngestionDestination(string name) : TerraformResource("aws_appfabric_ingestion_destination", name)
{
    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    public required TerraformValue<string> AppBundleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_bundle_arn");
        set => SetArgument("app_bundle_arn", value);
    }

    /// <summary>
    /// The ingestion_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionArn is required")]
    public required TerraformValue<string> IngestionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("ingestion_arn");
        set => SetArgument("ingestion_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// DestinationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlock>? DestinationConfiguration
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationDestinationConfigurationBlock>>("destination_configuration");
        set => SetArgument("destination_configuration", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricIngestionDestinationProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsAppfabricIngestionDestinationProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAppfabricIngestionDestinationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAppfabricIngestionDestinationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
