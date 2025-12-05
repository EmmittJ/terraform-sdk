using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_network_insights_analysis Terraform resource.
/// Manages a aws_ec2_network_insights_analysis resource.
/// </summary>
public partial class AwsEc2NetworkInsightsAnalysis(string name) : TerraformResource("aws_ec2_network_insights_analysis", name)
{
    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    public TerraformSet<string>? FilterInArns
    {
        get => GetArgument<TerraformSet<string>>("filter_in_arns");
        set => SetArgument("filter_in_arns", value);
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
    /// The network_insights_path_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInsightsPathId is required")]
    public required TerraformValue<string> NetworkInsightsPathId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_insights_path_id");
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
    /// The wait_for_completion attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForCompletion
    {
        get => GetArgument<TerraformValue<bool>>("wait_for_completion");
        set => SetArgument("wait_for_completion", value);
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
    /// The forward_path_components attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ForwardPathComponents
        => CreateReference("forward_path_components");

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

}
