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
    public TerraformProperty<bool>? PrivateDnsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_dns_enabled");
        set => this.WithProperty("private_dns_enabled", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
    }

}
