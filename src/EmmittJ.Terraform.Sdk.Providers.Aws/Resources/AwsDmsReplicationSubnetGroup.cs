using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_replication_subnet_group resource.
/// </summary>
public class AwsDmsReplicationSubnetGroup : TerraformResource
{
    public AwsDmsReplicationSubnetGroup(string name) : base("aws_dms_replication_subnet_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("replication_subnet_group_arn");
        this.DeclareOutput("vpc_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_subnet_group_description attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSubnetGroupDescription
    {
        get => GetProperty<TerraformProperty<string>>("replication_subnet_group_description");
        set => this.WithProperty("replication_subnet_group_description", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSubnetGroupId
    {
        get => GetProperty<TerraformProperty<string>>("replication_subnet_group_id");
        set => this.WithProperty("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The replication_subnet_group_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationSubnetGroupArn => this["replication_subnet_group_arn"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
