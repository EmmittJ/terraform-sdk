using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_subnet_group.
/// </summary>
public partial class AwsDmsReplicationSubnetGroupDataSource : TerraformDataSource
{
    public AwsDmsReplicationSubnetGroupDataSource(string name) : base("aws_dms_replication_subnet_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    [TerraformProperty("replication_subnet_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationSubnetGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The replication_subnet_group_arn attribute.
    /// </summary>
    [TerraformProperty("replication_subnet_group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationSubnetGroupArn { get; }

    /// <summary>
    /// The replication_subnet_group_description attribute.
    /// </summary>
    [TerraformProperty("replication_subnet_group_description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationSubnetGroupDescription { get; }

    /// <summary>
    /// The subnet_group_status attribute.
    /// </summary>
    [TerraformProperty("subnet_group_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetGroupStatus { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

}
