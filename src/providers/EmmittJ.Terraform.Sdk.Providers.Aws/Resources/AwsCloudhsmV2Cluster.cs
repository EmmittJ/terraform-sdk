using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudhsmV2ClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudhsm_v2_cluster resource.
/// </summary>
public class AwsCloudhsmV2Cluster : TerraformResource
{
    public AwsCloudhsmV2Cluster(string name) : base("aws_cloudhsm_v2_cluster", name)
    {
    }

    /// <summary>
    /// The hsm_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmType is required")]
    [TerraformPropertyName("hsm_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HsmType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_backup_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_backup_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceBackupIdentifier { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudhsmV2ClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cluster_certificates attribute.
    /// </summary>
    [TerraformPropertyName("cluster_certificates")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClusterCertificates => new TerraformReference(this, "cluster_certificates");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterId => new TerraformReference(this, "cluster_id");

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    [TerraformPropertyName("cluster_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterState => new TerraformReference(this, "cluster_state");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupId => new TerraformReference(this, "security_group_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}
