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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInsightsPathId
    {
        get => new TerraformReference<string>(this, "network_insights_path_id");
        set => SetArgument("network_insights_path_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformValue<string> DestinationArn
    {
        get => new TerraformReference<string>(this, "destination_arn");
    }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public TerraformValue<string> DestinationIp
    {
        get => new TerraformReference<string>(this, "destination_ip");
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformValue<double> DestinationPort
    {
        get => new TerraformReference<double>(this, "destination_port");
    }

    /// <summary>
    /// The filter_at_destination attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FilterAtDestination
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "filter_at_destination").ResolveNodes(ctx));
    }

    /// <summary>
    /// The filter_at_source attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FilterAtSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "filter_at_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceArn
    {
        get => new TerraformReference<string>(this, "source_arn");
    }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformValue<string> SourceIp
    {
        get => new TerraformReference<string>(this, "source_ip");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
