using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_msk_vpc_connection Terraform data source.
/// Retrieves information about a aws_msk_vpc_connection.
/// </summary>
public partial class AwsMskVpcConnectionDataSource(string name) : TerraformDataSource("aws_msk_vpc_connection", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformValue<string> Authentication
        => AsReference("authentication");

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    public TerraformSet<string> ClientSubnets
        => AsReference("client_subnets");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => AsReference("security_groups");

    /// <summary>
    /// The target_cluster_arn attribute.
    /// </summary>
    public TerraformValue<string> TargetClusterArn
        => AsReference("target_cluster_arn");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}
