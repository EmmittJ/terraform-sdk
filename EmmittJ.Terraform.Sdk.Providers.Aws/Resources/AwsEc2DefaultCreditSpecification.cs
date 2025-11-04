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
    public string? CpuCredits
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cpu_credits")?.Value;
        set => this.WithProperty("cpu_credits", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    public string? InstanceFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_family")?.Value;
        set => this.WithProperty("instance_family", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
