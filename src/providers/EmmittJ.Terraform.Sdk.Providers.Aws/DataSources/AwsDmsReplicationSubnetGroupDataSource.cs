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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformValue<string> ReplicationSubnetGroupId
    {
        get => new TerraformReference<string>(this, "replication_subnet_group_id");
        set => SetArgument("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The replication_subnet_group_arn attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupArn
    {
        get => new TerraformReference<string>(this, "replication_subnet_group_arn");
    }

    /// <summary>
    /// The replication_subnet_group_description attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSubnetGroupDescription
    {
        get => new TerraformReference<string>(this, "replication_subnet_group_description");
    }

    /// <summary>
    /// The subnet_group_status attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupStatus
    {
        get => new TerraformReference<string>(this, "subnet_group_status");
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}
