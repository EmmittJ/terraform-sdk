using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNeptuneGlobalClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_neptune_global_cluster resource.
/// </summary>
public class AwsNeptuneGlobalCluster : TerraformResource
{
    public AwsNeptuneGlobalCluster(string name) : base("aws_neptune_global_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("global_cluster_members");
        this.DeclareOutput("global_cluster_resource_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalClusterIdentifier is required")]
    public required TerraformProperty<string> GlobalClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("global_cluster_identifier");
        set => this.WithProperty("global_cluster_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_db_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_db_cluster_identifier");
        set => this.WithProperty("source_db_cluster_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("storage_encrypted");
        set => this.WithProperty("storage_encrypted", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNeptuneGlobalClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNeptuneGlobalClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The global_cluster_members attribute.
    /// </summary>
    public TerraformExpression GlobalClusterMembers => this["global_cluster_members"];

    /// <summary>
    /// The global_cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression GlobalClusterResourceId => this["global_cluster_resource_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
