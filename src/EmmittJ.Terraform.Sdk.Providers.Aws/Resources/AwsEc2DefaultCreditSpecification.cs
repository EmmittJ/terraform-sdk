using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_default_credit_specification resource.
/// </summary>
public class AwsEc2DefaultCreditSpecification : TerraformResource
{
    public AwsEc2DefaultCreditSpecification(string name) : base("aws_ec2_default_credit_specification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CpuCredits
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cpu_credits");
        set => this.WithProperty("cpu_credits", value);
    }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_family");
        set => this.WithProperty("instance_family", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
