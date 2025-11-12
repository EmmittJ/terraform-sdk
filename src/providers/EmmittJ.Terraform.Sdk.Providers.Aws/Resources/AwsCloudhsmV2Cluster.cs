using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudhsmV2ClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudhsm_v2_cluster resource.
/// </summary>
public partial class AwsCloudhsmV2Cluster : TerraformResource
{
    public AwsCloudhsmV2Cluster(string name) : base("aws_cloudhsm_v2_cluster", name)
    {
    }

    /// <summary>
    /// The hsm_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmType is required")]
    [TerraformProperty("hsm_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HsmType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_backup_identifier attribute.
    /// </summary>
    [TerraformProperty("source_backup_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceBackupIdentifier { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCloudhsmV2ClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cluster_certificates attribute.
    /// </summary>
    [TerraformProperty("cluster_certificates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClusterCertificates { get; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformProperty("cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterId { get; }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    [TerraformProperty("cluster_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterState { get; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformProperty("security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityGroupId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
