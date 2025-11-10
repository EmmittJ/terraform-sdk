using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNeptuneClusterInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_neptune_cluster_instance resource.
/// </summary>
public class AwsNeptuneClusterInstance : TerraformResource
{
    public AwsNeptuneClusterInstance(string name) : base("aws_neptune_cluster_instance", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ApplyImmediately { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "apply_immediately");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Engine { get; set; }

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
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Identifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier");

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("identifier_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdentifierPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier_prefix");

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    [TerraformPropertyName("instance_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceClass { get; set; }

    /// <summary>
    /// The neptune_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("neptune_parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NeptuneParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "neptune_parameter_group_name");

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("neptune_subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NeptuneSubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "neptune_subnet_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredBackupWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    [TerraformPropertyName("promotion_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PromotionTier { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipFinalSnapshot { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNeptuneClusterInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("dbi_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbiResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dbi_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StorageEncrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "storage_encrypted");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The writer attribute.
    /// </summary>
    [TerraformPropertyName("writer")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Writer => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "writer");

}
