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
