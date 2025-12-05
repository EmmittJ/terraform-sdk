using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2NetworkInsightsPathDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsPathDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ec2_network_insights_path Terraform data source.
/// Retrieves information about a aws_ec2_network_insights_path.
/// </summary>
public partial class AwsEc2NetworkInsightsPathDataSource(string name) : TerraformDataSource("aws_ec2_network_insights_path", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInsightsPathId
    {
        get => GetArgument<TerraformValue<string>>("network_insights_path_id") ?? CreateReference("network_insights_path_id");
        set => SetArgument("network_insights_path_id", value);
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
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformValue<string> Destination
        => CreateReference("destination");

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformValue<string> DestinationArn
        => CreateReference("destination_arn");

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public TerraformValue<string> DestinationIp
        => CreateReference("destination_ip");

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformValue<double> DestinationPort
        => CreateReference("destination_port");

    /// <summary>
    /// The filter_at_destination attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FilterAtDestination
        => CreateReference("filter_at_destination");

    /// <summary>
    /// The filter_at_source attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FilterAtSource
        => CreateReference("filter_at_source");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
        => CreateReference("protocol");

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string> Source
        => CreateReference("source");

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceArn
        => CreateReference("source_arn");

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformValue<string> SourceIp
        => CreateReference("source_ip");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
