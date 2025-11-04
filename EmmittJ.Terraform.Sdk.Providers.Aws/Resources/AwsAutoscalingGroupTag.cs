using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_group_tag resource.
/// </summary>
public class AwsAutoscalingGroupTag : TerraformResource
{
    public AwsAutoscalingGroupTag(string name) : base("aws_autoscaling_group_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    public string? AutoscalingGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autoscaling_group_name")?.Value;
        set => this.WithProperty("autoscaling_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
