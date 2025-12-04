using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_subscription_filter Terraform resource.
/// Manages a aws_cloudwatch_log_subscription_filter resource.
/// </summary>
public partial class AwsCloudwatchLogSubscriptionFilter(string name) : TerraformResource("aws_cloudwatch_log_subscription_filter", name)
{
    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformValue<string> DestinationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    public TerraformValue<string>? Distribution
    {
        get => GetArgument<TerraformValue<string>>("distribution");
        set => SetArgument("distribution", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterPattern is required")]
    public required TerraformValue<string> FilterPattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_pattern");
        set => SetArgument("filter_pattern", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_group_name");
        set => SetArgument("log_group_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn") ?? AsReference("role_arn");
        set => SetArgument("role_arn", value);
    }

}
