using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsMemorydbMultiRegionCluster.
/// Nesting mode: single
/// </summary>
public class AwsMemorydbMultiRegionClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_memorydb_multi_region_cluster Terraform resource.
/// Manages a aws_memorydb_multi_region_cluster resource.
/// </summary>
public partial class AwsMemorydbMultiRegionCluster(string name) : TerraformResource("aws_memorydb_multi_region_cluster", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine") ?? CreateReference("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? CreateReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The multi_region_cluster_name_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiRegionClusterNameSuffix is required")]
    public required TerraformValue<string> MultiRegionClusterNameSuffix
    {
        get => GetRequiredArgument<TerraformValue<string>>("multi_region_cluster_name_suffix");
        set => SetArgument("multi_region_cluster_name_suffix", value);
    }

    /// <summary>
    /// The multi_region_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> MultiRegionParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("multi_region_parameter_group_name") ?? CreateReference("multi_region_parameter_group_name");
        set => SetArgument("multi_region_parameter_group_name", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformValue<double> NumShards
    {
        get => GetArgument<TerraformValue<double>>("num_shards") ?? CreateReference("num_shards");
        set => SetArgument("num_shards", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TlsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_enabled") ?? CreateReference("tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The update_strategy attribute.
    /// </summary>
    public TerraformValue<string>? UpdateStrategy
    {
        get => GetArgument<TerraformValue<string>>("update_strategy");
        set => SetArgument("update_strategy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public TerraformValue<string> MultiRegionClusterName
        => CreateReference("multi_region_cluster_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMemorydbMultiRegionClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMemorydbMultiRegionClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
