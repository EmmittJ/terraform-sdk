using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_service_allowed_principal resource.
/// </summary>
public class AwsVpcEndpointServiceAllowedPrincipal : TerraformResource
{
    public AwsVpcEndpointServiceAllowedPrincipal(string name) : base("aws_vpc_endpoint_service_allowed_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The principal_arn attribute.
    /// </summary>
    public string? PrincipalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_arn")?.Value;
        set => this.WithProperty("principal_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public string? VpcEndpointServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_service_id")?.Value;
        set => this.WithProperty("vpc_endpoint_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
