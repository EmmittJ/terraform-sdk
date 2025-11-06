using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_private_dns resource.
/// </summary>
public class AwsVpcEndpointPrivateDns : TerraformResource
{
    public AwsVpcEndpointPrivateDns(string name) : base("aws_vpc_endpoint_private_dns", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public bool? PrivateDnsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_dns_enabled")?.Value;
        set => this.WithProperty("private_dns_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
