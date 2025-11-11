using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pit_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsDrsReplicationConfigurationTemplatePitPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The retention_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDuration is required")]
    [TerraformProperty("retention_duration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RetentionDuration { get; set; }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [TerraformProperty("rule_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RuleId { get; set; }

    /// <summary>
    /// The units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Units is required")]
    [TerraformProperty("units")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Units { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDrsReplicationConfigurationTemplateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_drs_replication_configuration_template resource.
/// </summary>
public partial class AwsDrsReplicationConfigurationTemplate : TerraformResource
{
    public AwsDrsReplicationConfigurationTemplate(string name) : base("aws_drs_replication_configuration_template", name)
    {
    }

    /// <summary>
    /// The associate_default_security_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociateDefaultSecurityGroup is required")]
    [TerraformProperty("associate_default_security_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> AssociateDefaultSecurityGroup { get; set; }

    /// <summary>
    /// The auto_replicate_new_disks attribute.
    /// </summary>
    [TerraformProperty("auto_replicate_new_disks")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AutoReplicateNewDisks { get; set; }

    /// <summary>
    /// The bandwidth_throttling attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthThrottling is required")]
    [TerraformProperty("bandwidth_throttling")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BandwidthThrottling { get; set; }

    /// <summary>
    /// The create_public_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatePublicIp is required")]
    [TerraformProperty("create_public_ip")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> CreatePublicIp { get; set; }

    /// <summary>
    /// The data_plane_routing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPlaneRouting is required")]
    [TerraformProperty("data_plane_routing")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataPlaneRouting { get; set; }

    /// <summary>
    /// The default_large_staging_disk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLargeStagingDiskType is required")]
    [TerraformProperty("default_large_staging_disk_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DefaultLargeStagingDiskType { get; set; }

    /// <summary>
    /// The ebs_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEncryption is required")]
    [TerraformProperty("ebs_encryption")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EbsEncryption { get; set; }

    /// <summary>
    /// The ebs_encryption_key_arn attribute.
    /// </summary>
    [TerraformProperty("ebs_encryption_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EbsEncryptionKeyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_server_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServerInstanceType is required")]
    [TerraformProperty("replication_server_instance_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationServerInstanceType { get; set; }

    /// <summary>
    /// The replication_servers_security_groups_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationServersSecurityGroupsIds is required")]
    [TerraformProperty("replication_servers_security_groups_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ReplicationServersSecurityGroupsIds { get; set; }

    /// <summary>
    /// The staging_area_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaSubnetId is required")]
    [TerraformProperty("staging_area_subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StagingAreaSubnetId { get; set; }

    /// <summary>
    /// The staging_area_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingAreaTags is required")]
    [TerraformProperty("staging_area_tags")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> StagingAreaTags { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The use_dedicated_replication_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseDedicatedReplicationServer is required")]
    [TerraformProperty("use_dedicated_replication_server")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> UseDedicatedReplicationServer { get; set; }

    /// <summary>
    /// Block for pit_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("pit_policy")]
    public TerraformList<TerraformBlock<AwsDrsReplicationConfigurationTemplatePitPolicyBlock>>? PitPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDrsReplicationConfigurationTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
