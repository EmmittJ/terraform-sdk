using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kerberos_authentication_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_cache_secret_iam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretIamArn is required")]
    [TerraformProperty("key_cache_secret_iam_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyCacheSecretIamArn { get; set; }

    /// <summary>
    /// The key_cache_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretId is required")]
    [TerraformProperty("key_cache_secret_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyCacheSecretId { get; set; }

    /// <summary>
    /// The krb5_file_contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Krb5FileContents is required")]
    [TerraformProperty("krb5_file_contents")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Krb5FileContents { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDmsReplicationInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_dms_replication_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDmsReplicationInstance : TerraformResource
{
    public AwsDmsReplicationInstance(string name) : base("aws_dms_replication_instance", name)
    {
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> AllocatedStorage { get; set; }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("allow_major_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    [TerraformProperty("dns_name_servers")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DnsNameServers { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> MultiAz { get; set; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkType { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceClass is required")]
    [TerraformProperty("replication_instance_class")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationInstanceClass { get; set; }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    [TerraformProperty("replication_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationInstanceId { get; set; }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [TerraformProperty("replication_subnet_group_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ReplicationSubnetGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for kerberos_authentication_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAuthenticationSettings block(s) allowed")]
    [TerraformProperty("kerberos_authentication_settings")]
    public TerraformList<TerraformBlock<AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock>>? KerberosAuthenticationSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDmsReplicationInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [TerraformProperty("replication_instance_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationInstanceArn { get; }

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    [TerraformProperty("replication_instance_private_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReplicationInstancePrivateIps { get; }

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    [TerraformProperty("replication_instance_public_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReplicationInstancePublicIps { get; }

}
