using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2NetworkInsightsAnalysisDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock : TerraformBlock
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
/// Represents a aws_ec2_network_insights_analysis Terraform data source.
/// Retrieves information about a aws_ec2_network_insights_analysis.
/// </summary>
public partial class AwsEc2NetworkInsightsAnalysisDataSource(string name) : TerraformDataSource("aws_ec2_network_insights_analysis", name)
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
    /// The network_insights_analysis_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInsightsAnalysisId
    {
        get => new TerraformReference<string>(this, "network_insights_analysis_id");
        set => SetArgument("network_insights_analysis_id", value);
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
    /// The alternate_path_hints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AlternatePathHints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "alternate_path_hints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The explanations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Explanations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "explanations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    public TerraformList<string> FilterInArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "filter_in_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ForwardPathComponents
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "forward_path_components").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInsightsPathId
    {
        get => new TerraformReference<string>(this, "network_insights_path_id");
    }

    /// <summary>
    /// The path_found attribute.
    /// </summary>
    public TerraformValue<bool> PathFound
    {
        get => new TerraformReference<bool>(this, "path_found");
    }

    /// <summary>
    /// The return_path_components attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReturnPathComponents
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "return_path_components").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    public TerraformValue<string> WarningMessage
    {
        get => new TerraformReference<string>(this, "warning_message");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
