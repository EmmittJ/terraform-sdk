using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNeptuneClusterInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_neptune_cluster_instance resource.
/// </summary>
public class AwsNeptuneClusterInstance : TerraformResource
{
    public AwsNeptuneClusterInstance(string name) : base("aws_neptune_cluster_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputddress");
        this.WithOutputrn");
        this.WithOutputbi_resource_id");
        this.WithOutputndpoint");
        this.WithOutputms_key_arn");
        this.WithOutputtorage_encrypted");
        this.WithOutputtorage_type");
        this.WithOutputriter");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? IdentifierPrefix
    {
        get => GetProperty<TerraformProperty<string>>("identifier_prefix");
        set => this.WithProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformProperty<string> InstanceClass
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// The neptune_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NeptuneParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("neptune_parameter_group_name");
        set => this.WithProperty("neptune_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NeptuneSubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("neptune_subnet_group_name");
        set => this.WithProperty("neptune_subnet_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredBackupWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_backup_window");
        set => this.WithProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    public TerraformProperty<double>? PromotionTier
    {
        get => GetProperty<TerraformProperty<double>>("promotion_tier");
        set => this.WithProperty("promotion_tier", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNeptuneClusterInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNeptuneClusterInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    public TerraformExpression DbiResourceId => this["dbi_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The writer attribute.
    /// </summary>
    public TerraformExpression Writer => this["writer"];

}
