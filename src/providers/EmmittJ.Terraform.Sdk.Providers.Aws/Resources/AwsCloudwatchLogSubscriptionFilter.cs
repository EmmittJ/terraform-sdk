using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_subscription_filter resource.
/// </summary>
public class AwsCloudwatchLogSubscriptionFilter : TerraformResource
{
    public AwsCloudwatchLogSubscriptionFilter(string name) : base("aws_cloudwatch_log_subscription_filter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("destination_arn");
        SetOutput("distribution");
        SetOutput("filter_pattern");
        SetOutput("id");
        SetOutput("log_group_name");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformProperty<string> DestinationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_arn");
        set => SetProperty("destination_arn", value);
    }

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    public TerraformProperty<string> Distribution
    {
        get => GetRequiredOutput<TerraformProperty<string>>("distribution");
        set => SetProperty("distribution", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterPattern is required")]
    public required TerraformProperty<string> FilterPattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_pattern");
        set => SetProperty("filter_pattern", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_group_name");
        set => SetProperty("log_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

}
