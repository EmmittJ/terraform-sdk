using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_eip_association Terraform resource.
/// Manages a aws_eip_association resource.
/// </summary>
public partial class AwsEipAssociation(string name) : TerraformResource("aws_eip_association", name)
{
    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string> AllocationId
    {
        get => new TerraformReference<string>(this, "allocation_id");
        set => SetArgument("allocation_id", value);
    }

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    public TerraformValue<bool>? AllowReassociation
    {
        get => new TerraformReference<bool>(this, "allow_reassociation");
        set => SetArgument("allow_reassociation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => new TerraformReference<string>(this, "public_ip");
        set => SetArgument("public_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
