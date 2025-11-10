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
        SetOutput("allocation_id");
        SetOutput("allow_reassociation");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("network_interface_id");
        SetOutput("private_ip_address");
        SetOutput("public_ip");
        SetOutput("region");
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformProperty<string> AllocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allocation_id");
        set => SetProperty("allocation_id", value);
    }

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    public TerraformProperty<bool> AllowReassociation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_reassociation");
        set => SetProperty("allow_reassociation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string> PrivateIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_ip_address");
        set => SetProperty("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformProperty<string> PublicIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ip");
        set => SetProperty("public_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
