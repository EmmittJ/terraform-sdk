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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The multi_region_cluster_name_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? MultiRegionClusterNameSuffix
    {
        get => GetProperty<TerraformProperty<string>>("multi_region_cluster_name_suffix");
        set => this.WithProperty("multi_region_cluster_name_suffix", value);
    }

    /// <summary>
    /// The multi_region_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? MultiRegionParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("multi_region_parameter_group_name");
        set => this.WithProperty("multi_region_parameter_group_name", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformProperty<double>? NumShards
    {
        get => GetProperty<TerraformProperty<double>>("num_shards");
        set => this.WithProperty("num_shards", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_enabled");
        set => this.WithProperty("tls_enabled", value);
    }

    /// <summary>
    /// The update_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateStrategy
    {
        get => GetProperty<TerraformProperty<string>>("update_strategy");
        set => this.WithProperty("update_strategy", value);
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
