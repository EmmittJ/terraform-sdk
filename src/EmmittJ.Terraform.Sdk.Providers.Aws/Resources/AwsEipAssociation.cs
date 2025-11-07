using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eip_association resource.
/// </summary>
public class AwsEipAssociation : TerraformResource
{
    public AwsEipAssociation(string name) : base("aws_eip_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationId
    {
        get => GetProperty<TerraformProperty<string>>("allocation_id");
        set => this.WithProperty("allocation_id", value);
    }

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowReassociation
    {
        get => GetProperty<TerraformProperty<bool>>("allow_reassociation");
        set => this.WithProperty("allow_reassociation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address");
        set => this.WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIp
    {
        get => GetProperty<TerraformProperty<string>>("public_ip");
        set => this.WithProperty("public_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
