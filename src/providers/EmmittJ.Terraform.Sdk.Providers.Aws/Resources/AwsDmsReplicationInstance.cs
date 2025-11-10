using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kerberos_authentication_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The key_cache_secret_iam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretIamArn is required")]
    [TerraformPropertyName("key_cache_secret_iam_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyCacheSecretIamArn { get; set; }

    /// <summary>
    /// The key_cache_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyCacheSecretId is required")]
    [TerraformPropertyName("key_cache_secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyCacheSecretId { get; set; }

    /// <summary>
    /// The krb5_file_contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Krb5FileContents is required")]
    [TerraformPropertyName("krb5_file_contents")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Krb5FileContents { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsReplicationInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_dms_replication_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDmsReplicationInstance : TerraformResource
{
    public AwsDmsReplicationInstance(string name) : base("aws_dms_replication_instance", name)
    {
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AllocatedStorage { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocated_storage");

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_major_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApplyImmediately { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutoMinorVersionUpgrade { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_minor_version_upgrade");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_name_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsNameServers { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MultiAz { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceClass is required")]
    [TerraformPropertyName("replication_instance_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationInstanceClass { get; set; }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    [TerraformPropertyName("replication_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationInstanceId { get; set; }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [TerraformPropertyName("replication_subnet_group_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReplicationSubnetGroupId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_subnet_group_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// Block for kerberos_authentication_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAuthenticationSettings block(s) allowed")]
    [TerraformPropertyName("kerberos_authentication_settings")]
    public TerraformList<TerraformBlock<AwsDmsReplicationInstanceKerberosAuthenticationSettingsBlock>>? KerberosAuthenticationSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDmsReplicationInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReplicationInstanceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_instance_arn");

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_private_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReplicationInstancePrivateIps => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "replication_instance_private_ips");

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_public_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReplicationInstancePublicIps => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "replication_instance_public_ips");

}
