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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("address");
        SetOutput("arn");
        SetOutput("dbi_resource_id");
        SetOutput("endpoint");
        SetOutput("kms_key_arn");
        SetOutput("storage_encrypted");
        SetOutput("storage_type");
        SetOutput("writer");
        SetOutput("apply_immediately");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("availability_zone");
        SetOutput("cluster_identifier");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("identifier");
        SetOutput("identifier_prefix");
        SetOutput("instance_class");
        SetOutput("neptune_parameter_group_name");
        SetOutput("neptune_subnet_group_name");
        SetOutput("port");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("promotion_tier");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("skip_final_snapshot");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
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
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string> Identifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier");
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string> IdentifierPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier_prefix");
        set => SetProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// The neptune_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> NeptuneParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("neptune_parameter_group_name");
        set => SetProperty("neptune_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> NeptuneSubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("neptune_subnet_group_name");
        set => SetProperty("neptune_subnet_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredBackupWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_backup_window");
        set => SetProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    public TerraformProperty<double> PromotionTier
    {
        get => GetRequiredOutput<TerraformProperty<double>>("promotion_tier");
        set => SetProperty("promotion_tier", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
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
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_snapshot");
        set => SetProperty("skip_final_snapshot", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNeptuneClusterInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
