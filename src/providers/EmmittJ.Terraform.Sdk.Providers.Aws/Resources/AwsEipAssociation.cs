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
        get => GetArgument<TerraformValue<string>>("allocation_id") ?? AsReference("allocation_id");
        set => SetArgument("allocation_id", value);
    }

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    public TerraformValue<bool>? AllowReassociation
    {
        get => GetArgument<TerraformValue<bool>>("allow_reassociation");
        set => SetArgument("allow_reassociation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id") ?? AsReference("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => GetArgument<TerraformValue<string>>("network_interface_id") ?? AsReference("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address") ?? AsReference("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => GetArgument<TerraformValue<string>>("public_ip") ?? AsReference("public_ip");
        set => SetArgument("public_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
