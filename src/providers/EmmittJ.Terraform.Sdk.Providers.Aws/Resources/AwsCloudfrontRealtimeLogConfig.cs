using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in AwsCloudfrontRealtimeLogConfig.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontRealtimeLogConfigEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint";

    /// <summary>
    /// The stream_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamType is required")]
    public required TerraformValue<string> StreamType
    {
        get => new TerraformReference<string>(this, "stream_type");
        set => SetArgument("stream_type", value);
    }

    /// <summary>
    /// KinesisStreamConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KinesisStreamConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStreamConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontRealtimeLogConfigEndpointBlockKinesisStreamConfigBlock> KinesisStreamConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontRealtimeLogConfigEndpointBlockKinesisStreamConfigBlock>>("kinesis_stream_config");
        set => SetArgument("kinesis_stream_config", value);
    }

}

/// <summary>
/// Block type for kinesis_stream_config in AwsCloudfrontRealtimeLogConfigEndpointBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontRealtimeLogConfigEndpointBlockKinesisStreamConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_stream_config";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
        set => SetArgument("stream_arn", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_realtime_log_config Terraform resource.
/// Manages a aws_cloudfront_realtime_log_config resource.
/// </summary>
public partial class AwsCloudfrontRealtimeLogConfig(string name) : TerraformResource("aws_cloudfront_realtime_log_config", name)
{
    /// <summary>
    /// The fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    public required TerraformSet<string> Fields
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fields").ResolveNodes(ctx));
        set => SetArgument("fields", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    public required TerraformValue<double> SamplingRate
    {
        get => new TerraformReference<double>(this, "sampling_rate");
        set => SetArgument("sampling_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Endpoint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public required TerraformList<AwsCloudfrontRealtimeLogConfigEndpointBlock> Endpoint
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontRealtimeLogConfigEndpointBlock>>("endpoint");
        set => SetArgument("endpoint", value);
    }

}
