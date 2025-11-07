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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_arn");
        set => this.WithProperty("principal_arn", value);
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
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcEndpointServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_service_id");
        set => this.WithProperty("vpc_endpoint_service_id", value);
    }

}
