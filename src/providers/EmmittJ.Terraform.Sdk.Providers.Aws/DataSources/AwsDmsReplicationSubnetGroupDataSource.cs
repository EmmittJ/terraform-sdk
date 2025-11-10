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
        SetOutput("replication_subnet_group_arn");
        SetOutput("replication_subnet_group_description");
        SetOutput("subnet_group_status");
        SetOutput("subnet_ids");
        SetOutput("vpc_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replication_subnet_group_id");
        SetOutput("tags");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    public required TerraformProperty<string> ReplicationSubnetGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_subnet_group_id");
        set => SetProperty("replication_subnet_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
