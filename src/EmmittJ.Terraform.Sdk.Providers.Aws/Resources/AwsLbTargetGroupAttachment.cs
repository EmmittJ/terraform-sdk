using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_target_group_attachment resource.
/// </summary>
public class AwsLbTargetGroupAttachment : TerraformResource
{
    public AwsLbTargetGroupAttachment(string name) : base("aws_lb_target_group_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public string? TargetGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_group_arn")?.Value;
        set => this.WithProperty("target_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public string? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id")?.Value;
        set => this.WithProperty("target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
