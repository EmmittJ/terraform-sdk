using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMemorydbMultiRegionClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("arn");
        SetOutput("multi_region_cluster_name");
        SetOutput("status");
        SetOutput("tags_all");
        SetOutput("description");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("multi_region_cluster_name_suffix");
        SetOutput("multi_region_parameter_group_name");
        SetOutput("node_type");
        SetOutput("num_shards");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tls_enabled");
        SetOutput("update_strategy");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The multi_region_cluster_name_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiRegionClusterNameSuffix is required")]
    public required TerraformProperty<string> MultiRegionClusterNameSuffix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("multi_region_cluster_name_suffix");
        set => SetProperty("multi_region_cluster_name_suffix", value);
    }

    /// <summary>
    /// The multi_region_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> MultiRegionParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("multi_region_parameter_group_name");
        set => SetProperty("multi_region_parameter_group_name", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformProperty<double> NumShards
    {
        get => GetRequiredOutput<TerraformProperty<double>>("num_shards");
        set => SetProperty("num_shards", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TlsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls_enabled");
        set => SetProperty("tls_enabled", value);
    }

    /// <summary>
    /// The update_strategy attribute.
    /// </summary>
    public TerraformProperty<string> UpdateStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("update_strategy");
        set => SetProperty("update_strategy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMemorydbMultiRegionClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
