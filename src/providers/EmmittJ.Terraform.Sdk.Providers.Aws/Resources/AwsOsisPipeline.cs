using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for buffer_options in AwsOsisPipeline.
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineBufferOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "buffer_options";

    /// <summary>
    /// The persistent_buffer_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentBufferEnabled is required")]
    public required TerraformValue<bool> PersistentBufferEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("persistent_buffer_enabled");
        set => SetArgument("persistent_buffer_enabled", value);
    }

}


/// <summary>
/// Block type for encryption_at_rest_options in AwsOsisPipeline.
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineEncryptionAtRestOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_at_rest_options";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Block type for log_publishing_options in AwsOsisPipeline.
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineLogPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_publishing_options";

    /// <summary>
    /// The is_logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsLoggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_logging_enabled");
        set => SetArgument("is_logging_enabled", value);
    }

    /// <summary>
    /// CloudwatchLogDestination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOsisPipelineLogPublishingOptionsBlockCloudwatchLogDestinationBlock>? CloudwatchLogDestination
    {
        get => GetArgument<TerraformList<AwsOsisPipelineLogPublishingOptionsBlockCloudwatchLogDestinationBlock>>("cloudwatch_log_destination");
        set => SetArgument("cloudwatch_log_destination", value);
    }

}

/// <summary>
/// Block type for cloudwatch_log_destination in AwsOsisPipelineLogPublishingOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineLogPublishingOptionsBlockCloudwatchLogDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_log_destination";

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
/// Block type for timeouts in AwsOsisPipeline.
/// Nesting mode: single
/// </summary>
public class AwsOsisPipelineTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_options in AwsOsisPipeline.
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineVpcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_options";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_endpoint_management attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointManagement
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_management");
        set => SetArgument("vpc_endpoint_management", value);
    }

}


/// <summary>
/// Represents a aws_osis_pipeline Terraform resource.
/// Manages a aws_osis_pipeline resource.
/// </summary>
public partial class AwsOsisPipeline(string name) : TerraformResource("aws_osis_pipeline", name)
{
    /// <summary>
    /// The max_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnits is required")]
    public required TerraformValue<double> MaxUnits
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_units");
        set => SetArgument("max_units", value);
    }

    /// <summary>
    /// The min_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinUnits is required")]
    public required TerraformValue<double> MinUnits
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_units");
        set => SetArgument("min_units", value);
    }

    /// <summary>
    /// The pipeline_configuration_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineConfigurationBody is required")]
    public required TerraformValue<string> PipelineConfigurationBody
    {
        get => GetRequiredArgument<TerraformValue<string>>("pipeline_configuration_body");
        set => SetArgument("pipeline_configuration_body", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    public required TerraformValue<string> PipelineName
    {
        get => GetRequiredArgument<TerraformValue<string>>("pipeline_name");
        set => SetArgument("pipeline_name", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The ingest_endpoint_urls attribute.
    /// </summary>
    public TerraformSet<string> IngestEndpointUrls
        => AsReference("ingest_endpoint_urls");

    /// <summary>
    /// The pipeline_arn attribute.
    /// </summary>
    public TerraformValue<string> PipelineArn
        => AsReference("pipeline_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// BufferOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOsisPipelineBufferOptionsBlock>? BufferOptions
    {
        get => GetArgument<TerraformList<AwsOsisPipelineBufferOptionsBlock>>("buffer_options");
        set => SetArgument("buffer_options", value);
    }

    /// <summary>
    /// EncryptionAtRestOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOsisPipelineEncryptionAtRestOptionsBlock>? EncryptionAtRestOptions
    {
        get => GetArgument<TerraformList<AwsOsisPipelineEncryptionAtRestOptionsBlock>>("encryption_at_rest_options");
        set => SetArgument("encryption_at_rest_options", value);
    }

    /// <summary>
    /// LogPublishingOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOsisPipelineLogPublishingOptionsBlock>? LogPublishingOptions
    {
        get => GetArgument<TerraformList<AwsOsisPipelineLogPublishingOptionsBlock>>("log_publishing_options");
        set => SetArgument("log_publishing_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOsisPipelineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOsisPipelineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOsisPipelineVpcOptionsBlock>? VpcOptions
    {
        get => GetArgument<TerraformList<AwsOsisPipelineVpcOptionsBlock>>("vpc_options");
        set => SetArgument("vpc_options", value);
    }

}
