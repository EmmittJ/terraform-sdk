using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_docdb_global_cluster resource.
/// </summary>
public class AwsDocdbGlobalCluster : TerraformResource
{
    public AwsDocdbGlobalCluster(string name) : base("aws_docdb_global_cluster", name)
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
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    public string? GlobalClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_cluster_identifier")?.Value;
        set => this.WithProperty("global_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_db_cluster_identifier attribute.
    /// </summary>
    public string? SourceDbClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_db_cluster_identifier")?.Value;
        set => this.WithProperty("source_db_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public bool? StorageEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_encrypted")?.Value;
        set => this.WithProperty("storage_encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
