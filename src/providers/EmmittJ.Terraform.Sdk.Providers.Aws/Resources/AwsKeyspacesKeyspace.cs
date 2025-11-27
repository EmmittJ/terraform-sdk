using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for replication_specification in AwsKeyspacesKeyspace.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesKeyspaceReplicationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_specification";

    /// <summary>
    /// The region_list attribute.
    /// </summary>
    public TerraformSet<string>? RegionList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "region_list").ResolveNodes(ctx));
        set => SetArgument("region_list", value);
    }

    /// <summary>
    /// The replication_strategy attribute.
    /// </summary>
    public TerraformValue<string> ReplicationStrategy
    {
        get => new TerraformReference<string>(this, "replication_strategy");
        set => SetArgument("replication_strategy", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKeyspacesKeyspace.
/// Nesting mode: single
/// </summary>
public class AwsKeyspacesKeyspaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_keyspaces_keyspace Terraform resource.
/// Manages a aws_keyspaces_keyspace resource.
/// </summary>
public partial class AwsKeyspacesKeyspace(string name) : TerraformResource("aws_keyspaces_keyspace", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// ReplicationSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationSpecification block(s) allowed")]
    public TerraformList<AwsKeyspacesKeyspaceReplicationSpecificationBlock>? ReplicationSpecification
    {
        get => GetArgument<TerraformList<AwsKeyspacesKeyspaceReplicationSpecificationBlock>>("replication_specification");
        set => SetArgument("replication_specification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKeyspacesKeyspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKeyspacesKeyspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
