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
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationArn
    {
        get => GetProperty<TerraformProperty<string>>("destination_arn");
        set => this.WithProperty("destination_arn", value);
    }

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    public TerraformProperty<string>? Distribution
    {
        get => GetProperty<TerraformProperty<string>>("distribution");
        set => this.WithProperty("distribution", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPattern
    {
        get => GetProperty<TerraformProperty<string>>("filter_pattern");
        set => this.WithProperty("filter_pattern", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? LogGroupName
    {
        get => GetProperty<TerraformProperty<string>>("log_group_name");
        set => this.WithProperty("log_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

}
