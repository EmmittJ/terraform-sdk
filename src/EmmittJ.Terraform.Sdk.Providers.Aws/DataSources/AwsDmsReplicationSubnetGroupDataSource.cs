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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    public string? ReplicationSubnetGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_subnet_group_id")?.Value;
        set => this.WithProperty("replication_subnet_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
