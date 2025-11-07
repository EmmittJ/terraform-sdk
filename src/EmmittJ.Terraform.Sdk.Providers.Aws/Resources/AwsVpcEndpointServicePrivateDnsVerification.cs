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
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceId
    {
        get => GetProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForVerification
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_verification");
        set => this.WithProperty("wait_for_verification", value);
    }

}
