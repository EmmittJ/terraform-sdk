using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_memorydb_multi_region_cluster resource.
/// </summary>
public class AwsMemorydbMultiRegionCluster : TerraformResource
{
    public AwsMemorydbMultiRegionCluster(string name) : base("aws_memorydb_multi_region_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("multi_region_cluster_name");
        this.DeclareOutput("status");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The multi_region_cluster_name_suffix attribute.
    /// </summary>
    public string? MultiRegionClusterNameSuffix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multi_region_cluster_name_suffix")?.Value;
        set => this.WithProperty("multi_region_cluster_name_suffix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_region_parameter_group_name attribute.
    /// </summary>
    public string? MultiRegionParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multi_region_parameter_group_name")?.Value;
        set => this.WithProperty("multi_region_parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public double? NumShards
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_shards")?.Value;
        set => this.WithProperty("num_shards", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public bool? TlsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_enabled")?.Value;
        set => this.WithProperty("tls_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The update_strategy attribute.
    /// </summary>
    public string? UpdateStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("update_strategy")?.Value;
        set => this.WithProperty("update_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public TerraformExpression MultiRegionClusterName => this["multi_region_cluster_name"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
