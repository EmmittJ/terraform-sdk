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
        SetOutput("replication_subnet_group_arn");
        SetOutput("vpc_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replication_subnet_group_description");
        SetOutput("replication_subnet_group_id");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The replication_subnet_group_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupDescription is required")]
    public required TerraformProperty<string> ReplicationSubnetGroupDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_subnet_group_description");
        set => SetProperty("replication_subnet_group_description", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
