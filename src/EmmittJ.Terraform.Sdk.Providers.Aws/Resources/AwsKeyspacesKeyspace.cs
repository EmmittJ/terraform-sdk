using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for replication_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesKeyspaceReplicationSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The region_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RegionList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("region_list");
        set => WithProperty("region_list", value);
    }

    /// <summary>
    /// The replication_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("replication_strategy");
        set => WithProperty("replication_strategy", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKeyspacesKeyspaceTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a aws_keyspaces_keyspace resource.
/// </summary>
public class AwsKeyspacesKeyspace : TerraformResource
{
    public AwsKeyspacesKeyspace(string name) : base("aws_keyspaces_keyspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for replication_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationSpecification block(s) allowed")]
    public List<AwsKeyspacesKeyspaceReplicationSpecificationBlock>? ReplicationSpecification
    {
        get => GetProperty<List<AwsKeyspacesKeyspaceReplicationSpecificationBlock>>("replication_specification");
        set => this.WithProperty("replication_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKeyspacesKeyspaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsKeyspacesKeyspaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
