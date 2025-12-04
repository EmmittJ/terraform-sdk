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
        get => GetArgument<TerraformSet<string>>("region_list");
        set => SetArgument("region_list", value);
    }

    /// <summary>
    /// The replication_strategy attribute.
    /// </summary>
    public TerraformValue<string> ReplicationStrategy
    {
        get => GetArgument<TerraformValue<string>>("replication_strategy") ?? AsReference("replication_strategy");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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
