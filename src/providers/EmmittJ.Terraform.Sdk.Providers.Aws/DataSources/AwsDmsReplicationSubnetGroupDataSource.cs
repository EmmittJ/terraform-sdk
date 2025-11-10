using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_subnet_group.
/// </summary>
public class AwsDmsReplicationSubnetGroupDataSource : TerraformDataSource
{
    public AwsDmsReplicationSubnetGroupDataSource(string name) : base("aws_dms_replication_subnet_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    [TerraformPropertyName("replication_subnet_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationSubnetGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The replication_subnet_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("replication_subnet_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReplicationSubnetGroupArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_subnet_group_arn");

    /// <summary>
    /// The replication_subnet_group_description attribute.
    /// </summary>
    [TerraformPropertyName("replication_subnet_group_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReplicationSubnetGroupDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_subnet_group_description");

    /// <summary>
    /// The subnet_group_status attribute.
    /// </summary>
    [TerraformPropertyName("subnet_group_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetGroupStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_group_status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
