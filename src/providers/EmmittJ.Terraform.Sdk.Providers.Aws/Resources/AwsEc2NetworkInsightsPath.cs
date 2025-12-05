using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_at_destination in AwsEc2NetworkInsightsPath.
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_at_destination";

    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    public TerraformValue<string>? DestinationAddress
    {
        get => GetArgument<TerraformValue<string>>("destination_address");
        set => SetArgument("destination_address", value);
    }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    public TerraformValue<string>? SourceAddress
    {
        get => GetArgument<TerraformValue<string>>("source_address");
        set => SetArgument("source_address", value);
    }

    /// <summary>
    /// DestinationPortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationPortRange block(s) allowed")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlockDestinationPortRangeBlock>? DestinationPortRange
    {
        get => GetArgument<TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlockDestinationPortRangeBlock>>("destination_port_range");
        set => SetArgument("destination_port_range", value);
    }

    /// <summary>
    /// SourcePortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourcePortRange block(s) allowed")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlockSourcePortRangeBlock>? SourcePortRange
    {
        get => GetArgument<TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlockSourcePortRangeBlock>>("source_port_range");
        set => SetArgument("source_port_range", value);
    }

}

/// <summary>
/// Block type for destination_port_range in AwsEc2NetworkInsightsPathFilterAtDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtDestinationBlockDestinationPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}

/// <summary>
/// Block type for source_port_range in AwsEc2NetworkInsightsPathFilterAtDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtDestinationBlockSourcePortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for filter_at_source in AwsEc2NetworkInsightsPath.
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_at_source";

    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    public TerraformValue<string>? DestinationAddress
    {
        get => GetArgument<TerraformValue<string>>("destination_address");
        set => SetArgument("destination_address", value);
    }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    public TerraformValue<string>? SourceAddress
    {
        get => GetArgument<TerraformValue<string>>("source_address");
        set => SetArgument("source_address", value);
    }

    /// <summary>
    /// DestinationPortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationPortRange block(s) allowed")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlockDestinationPortRangeBlock>? DestinationPortRange
    {
        get => GetArgument<TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlockDestinationPortRangeBlock>>("destination_port_range");
        set => SetArgument("destination_port_range", value);
    }

    /// <summary>
    /// SourcePortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourcePortRange block(s) allowed")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlockSourcePortRangeBlock>? SourcePortRange
    {
        get => GetArgument<TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlockSourcePortRangeBlock>>("source_port_range");
        set => SetArgument("source_port_range", value);
    }

}

/// <summary>
/// Block type for destination_port_range in AwsEc2NetworkInsightsPathFilterAtSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtSourceBlockDestinationPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}

/// <summary>
/// Block type for source_port_range in AwsEc2NetworkInsightsPathFilterAtSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtSourceBlockSourcePortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Represents a aws_ec2_network_insights_path Terraform resource.
/// Manages a aws_ec2_network_insights_path resource.
/// </summary>
public partial class AwsEc2NetworkInsightsPath(string name) : TerraformResource("aws_ec2_network_insights_path", name)
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformValue<string>? Destination
    {
        get => GetArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public TerraformValue<string>? DestinationIp
    {
        get => GetArgument<TerraformValue<string>>("destination_ip");
        set => SetArgument("destination_ip", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformValue<double>? DestinationPort
    {
        get => GetArgument<TerraformValue<double>>("destination_port");
        set => SetArgument("destination_port", value);
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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
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
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformValue<string>? SourceIp
    {
        get => GetArgument<TerraformValue<string>>("source_ip");
        set => SetArgument("source_ip", value);
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
    /// The destination_arn attribute.
    /// </summary>
    public TerraformValue<string> DestinationArn
        => CreateReference("destination_arn");

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceArn
        => CreateReference("source_arn");

    /// <summary>
    /// FilterAtDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtDestination block(s) allowed")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>? FilterAtDestination
    {
        get => GetArgument<TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>>("filter_at_destination");
        set => SetArgument("filter_at_destination", value);
    }

    /// <summary>
    /// FilterAtSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtSource block(s) allowed")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlock>? FilterAtSource
    {
        get => GetArgument<TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlock>>("filter_at_source");
        set => SetArgument("filter_at_source", value);
    }

}
