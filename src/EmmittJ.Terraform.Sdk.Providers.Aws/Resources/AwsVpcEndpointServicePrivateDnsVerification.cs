using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_service_private_dns_verification resource.
/// </summary>
public class AwsVpcEndpointServicePrivateDnsVerification : TerraformResource
{
    public AwsVpcEndpointServicePrivateDnsVerification(string name) : base("aws_vpc_endpoint_service_private_dns_verification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The service_id attribute.
    /// </summary>
    public string? ServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_id")?.Value;
        set => this.WithProperty("service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public bool? WaitForVerification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_verification")?.Value;
        set => this.WithProperty("wait_for_verification", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
