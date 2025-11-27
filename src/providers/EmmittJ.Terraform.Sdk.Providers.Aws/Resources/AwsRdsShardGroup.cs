using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsShardGroup.
/// Nesting mode: single
/// </summary>
public class AwsRdsShardGroupTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_rds_shard_group Terraform resource.
/// Manages a aws_rds_shard_group resource.
/// </summary>
public partial class AwsRdsShardGroup(string name) : TerraformResource("aws_rds_shard_group", name)
{
    /// <summary>
    /// The compute_redundancy attribute.
    /// </summary>
    public TerraformValue<double> ComputeRedundancy
    {
        get => new TerraformReference<double>(this, "compute_redundancy");
        set => SetArgument("compute_redundancy", value);
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    public required TerraformValue<string> DbClusterIdentifier
    {
        get => new TerraformReference<string>(this, "db_cluster_identifier");
        set => SetArgument("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_shard_group_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbShardGroupIdentifier is required")]
    public required TerraformValue<string> DbShardGroupIdentifier
    {
        get => new TerraformReference<string>(this, "db_shard_group_identifier");
        set => SetArgument("db_shard_group_identifier", value);
    }

    /// <summary>
    /// The max_acu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAcu is required")]
    public required TerraformValue<double> MaxAcu
    {
        get => new TerraformReference<double>(this, "max_acu");
        set => SetArgument("max_acu", value);
    }

    /// <summary>
    /// The min_acu attribute.
    /// </summary>
    public TerraformValue<double> MinAcu
    {
        get => new TerraformReference<double>(this, "min_acu");
        set => SetArgument("min_acu", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The db_shard_group_resource_id attribute.
    /// </summary>
    public TerraformValue<string> DbShardGroupResourceId
    {
        get => new TerraformReference<string>(this, "db_shard_group_resource_id");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsShardGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsShardGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
