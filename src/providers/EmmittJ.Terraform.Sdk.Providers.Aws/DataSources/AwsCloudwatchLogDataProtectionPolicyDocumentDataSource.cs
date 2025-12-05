using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsCloudwatchLogDataProtectionPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// CustomDataIdentifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CustomDataIdentifier block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlockCustomDataIdentifierBlock>? CustomDataIdentifier
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlockCustomDataIdentifierBlock>>("custom_data_identifier");
        set => SetArgument("custom_data_identifier", value);
    }

}

/// <summary>
/// Block type for custom_data_identifier in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlockCustomDataIdentifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_data_identifier";

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
    /// The regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regex is required")]
    public required TerraformValue<string> Regex
    {
        get => GetRequiredArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

}


/// <summary>
/// Block type for statement in AwsCloudwatchLogDataProtectionPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "statement";

    /// <summary>
    /// The data_identifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataIdentifiers is required")]
    public required TerraformSet<string> DataIdentifiers
    {
        get => GetRequiredArgument<TerraformSet<string>>("data_identifiers");
        set => SetArgument("data_identifiers", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformValue<string>? Sid
    {
        get => GetArgument<TerraformValue<string>>("sid");
        set => SetArgument("sid", value);
    }

    /// <summary>
    /// Operation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Operation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Operation block(s) allowed")]
    public required TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlock> Operation
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlock>>("operation");
        set => SetArgument("operation", value);
    }

}

/// <summary>
/// Block type for operation in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation";

    /// <summary>
    /// Audit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audit block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlock>? Audit
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlock>>("audit");
        set => SetArgument("audit", value);
    }

    /// <summary>
    /// Deidentify block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deidentify block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlock>? Deidentify
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlock>>("deidentify");
        set => SetArgument("deidentify", value);
    }

}

/// <summary>
/// Block type for audit in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit";

    /// <summary>
    /// FindingsDestination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FindingsDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FindingsDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FindingsDestination block(s) allowed")]
    public required TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlock> FindingsDestination
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlock>>("findings_destination");
        set => SetArgument("findings_destination", value);
    }

}

/// <summary>
/// Block type for findings_destination in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "findings_destination";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// Firehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Firehose block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockFirehoseBlock>? Firehose
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockFirehoseBlock>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroup is required")]
    public required TerraformValue<string> LogGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_group");
        set => SetArgument("log_group", value);
    }

}

/// <summary>
/// Block type for firehose in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose";

    /// <summary>
    /// The delivery_stream attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStream is required")]
    public required TerraformValue<string> DeliveryStream
    {
        get => GetRequiredArgument<TerraformValue<string>>("delivery_stream");
        set => SetArgument("delivery_stream", value);
    }

}

/// <summary>
/// Block type for s3 in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockAuditBlockFindingsDestinationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

}

/// <summary>
/// Block type for deidentify in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deidentify";

    /// <summary>
    /// MaskConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaskConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaskConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaskConfig block(s) allowed")]
    public required TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlockMaskConfigBlock> MaskConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlockMaskConfigBlock>>("mask_config");
        set => SetArgument("mask_config", value);
    }

}

/// <summary>
/// Block type for mask_config in AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlockOperationBlockDeidentifyBlockMaskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mask_config";

}


/// <summary>
/// Represents a aws_cloudwatch_log_data_protection_policy_document Terraform data source.
/// Retrieves information about a aws_cloudwatch_log_data_protection_policy_document.
/// </summary>
public partial class AwsCloudwatchLogDataProtectionPolicyDocumentDataSource(string name) : TerraformDataSource("aws_cloudwatch_log_data_protection_policy_document", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
        => CreateReference("json");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Statement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Statement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Statement block(s) allowed")]
    public TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>? Statement
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>>("statement");
        set => SetArgument("statement", value);
    }

}
