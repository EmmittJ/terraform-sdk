using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_subnet_group.
/// </summary>
public class AwsDmsReplicationSubnetGroupDataSource : TerraformDataSource
{
    public AwsDmsReplicationSubnetGroupDataSource(string name) : base("aws_dms_replication_subnet_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("replication_subnet_group_arn");
        this.DeclareOutput("replication_subnet_group_description");
        this.DeclareOutput("subnet_group_status");
        this.DeclareOutput("subnet_ids");
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
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSubnetGroupId
    {
        get => GetProperty<TerraformProperty<string>>("replication_subnet_group_id");
        set => this.WithProperty("replication_subnet_group_id", value);
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
    /// The replication_subnet_group_arn attribute.
    /// </summary>
    public TerraformExpression ReplicationSubnetGroupArn => this["replication_subnet_group_arn"];

    /// <summary>
    /// The replication_subnet_group_description attribute.
    /// </summary>
    public TerraformExpression ReplicationSubnetGroupDescription => this["replication_subnet_group_description"];

    /// <summary>
    /// The subnet_group_status attribute.
    /// </summary>
    public TerraformExpression SubnetGroupStatus => this["subnet_group_status"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
