using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsGlobalClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_rds_global_cluster resource.
/// </summary>
public class AwsRdsGlobalCluster : TerraformResource
{
    public AwsRdsGlobalCluster(string name) : base("aws_rds_global_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("engine_version_actual");
        SetOutput("global_cluster_members");
        SetOutput("global_cluster_resource_id");
        SetOutput("database_name");
        SetOutput("deletion_protection");
        SetOutput("engine");
        SetOutput("engine_lifecycle_support");
        SetOutput("engine_version");
        SetOutput("force_destroy");
        SetOutput("global_cluster_identifier");
        SetOutput("id");
        SetOutput("region");
        SetOutput("source_db_cluster_identifier");
        SetOutput("storage_encrypted");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
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
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformProperty<string> EngineLifecycleSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_lifecycle_support");
        set => SetProperty("engine_lifecycle_support", value);
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
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalClusterIdentifier is required")]
    public required TerraformProperty<string> GlobalClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_cluster_identifier");
        set => SetProperty("global_cluster_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_db_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SourceDbClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_db_cluster_identifier");
        set => SetProperty("source_db_cluster_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> StorageEncrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_encrypted");
        set => SetProperty("storage_encrypted", value);
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
    public AwsRdsGlobalClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformExpression EngineVersionActual => this["engine_version_actual"];

    /// <summary>
    /// The global_cluster_members attribute.
    /// </summary>
    public TerraformExpression GlobalClusterMembers => this["global_cluster_members"];

    /// <summary>
    /// The global_cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression GlobalClusterResourceId => this["global_cluster_resource_id"];

}
