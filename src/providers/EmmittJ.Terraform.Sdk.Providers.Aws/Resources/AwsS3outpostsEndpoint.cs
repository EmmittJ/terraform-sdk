using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3outposts_endpoint Terraform resource.
/// Manages a aws_s3outposts_endpoint resource.
/// </summary>
public partial class AwsS3outpostsEndpoint(string name) : TerraformResource("aws_s3outposts_endpoint", name)
{
    /// <summary>
    /// The access_type attribute.
    /// </summary>
    public TerraformValue<string>? AccessType
    {
        get => GetArgument<TerraformValue<string>>("access_type");
        set => SetArgument("access_type", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string>? CustomerOwnedIpv4Pool
    {
        get => GetArgument<TerraformValue<string>>("customer_owned_ipv4_pool");
        set => SetArgument("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostId is required")]
    public required TerraformValue<string> OutpostId
    {
        get => GetArgument<TerraformValue<string>>("outpost_id");
        set => SetArgument("outpost_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformValue<string> SecurityGroupId
    {
        get => GetArgument<TerraformValue<string>>("security_group_id");
        set => SetArgument("security_group_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
        => AsReference("cidr_block");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NetworkInterfaces
        => AsReference("network_interfaces");

}
