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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_insights_analysis_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInsightsAnalysisId
    {
        get => GetArgument<TerraformValue<string>>("network_insights_analysis_id") ?? CreateReference("network_insights_analysis_id");
        set => SetArgument("network_insights_analysis_id", value);
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
    /// The alternate_path_hints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AlternatePathHints
        => CreateReference("alternate_path_hints");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The explanations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Explanations
        => CreateReference("explanations");

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    public TerraformList<string> FilterInArns
        => CreateReference("filter_in_arns");

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ForwardPathComponents
        => CreateReference("forward_path_components");

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInsightsPathId
        => CreateReference("network_insights_path_id");

    /// <summary>
    /// The path_found attribute.
    /// </summary>
    public TerraformValue<bool> PathFound
        => CreateReference("path_found");

    /// <summary>
    /// The return_path_components attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReturnPathComponents
        => CreateReference("return_path_components");

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string> StartDate
        => CreateReference("start_date");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
        => CreateReference("status_message");

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    public TerraformValue<string> WarningMessage
        => CreateReference("warning_message");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
