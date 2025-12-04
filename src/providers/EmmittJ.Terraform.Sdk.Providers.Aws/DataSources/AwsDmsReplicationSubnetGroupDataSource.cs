using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_replication_subnet_group Terraform data source.
/// Retrieves information about a aws_dms_replication_subnet_group.
/// </summary>
public partial class AwsDmsReplicationSubnetGroupDataSource(string name) : TerraformDataSource("aws_dms_replication_subnet_group", name)
{
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
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformValue<string> ReplicationSubnetGroupId
    {
        get => GetArgument<TerraformValue<string>>("replication_subnet_group_id");
        set => SetArgument("replication_subnet_group_id", value);
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
    /// The replication_subnet_group_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupArn
        => AsReference("replication_subnet_group_arn");

    /// <summary>
    /// The replication_subnet_group_description attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupDescription
        => AsReference("replication_subnet_group_description");

    /// <summary>
    /// The subnet_group_status attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupStatus
        => AsReference("subnet_group_status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
        => AsReference("subnet_ids");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}
