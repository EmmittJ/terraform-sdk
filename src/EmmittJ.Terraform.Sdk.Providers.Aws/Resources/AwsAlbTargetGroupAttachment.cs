using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_alb_target_group_attachment resource.
/// </summary>
public class AwsAlbTargetGroupAttachment : TerraformResource
{
    public AwsAlbTargetGroupAttachment(string name) : base("aws_alb_target_group_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_group_arn");
        set => this.WithProperty("target_group_arn", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

}
