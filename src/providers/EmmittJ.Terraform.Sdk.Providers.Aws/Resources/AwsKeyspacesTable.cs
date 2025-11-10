using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCapacitySpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The read_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? ReadCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("read_capacity_units");
        set => WithProperty("read_capacity_units", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThroughputMode
    {
        get => GetProperty<TerraformProperty<string>>("throughput_mode");
        set => WithProperty("throughput_mode", value);
    }

    /// <summary>
    /// The write_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? WriteCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("write_capacity_units");
        set => WithProperty("write_capacity_units", value);
    }

}

/// <summary>
/// Block type for client_side_timestamps in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableClientSideTimestampsBlock : TerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformProperty<string> Status
    {
        get => GetRequiredProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for comment in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCommentBlock : TerraformBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string>? Message
    {
        get => GetProperty<TerraformProperty<string>>("message");
        set => WithProperty("message", value);
    }

}

/// <summary>
/// Block type for encryption_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableEncryptionSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_identifier");
        set => WithProperty("kms_key_identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTablePointInTimeRecoveryBlock : TerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for schema_definition in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKeyspacesTableTimeoutsBlock : TerraformBlock
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
/// Block type for ttl in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableTtlBlock : TerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformProperty<string> Status
    {
        get => GetRequiredProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_keyspaces_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKeyspacesTable : TerraformResource
{
    public AwsKeyspacesTable(string name) : base("aws_keyspaces_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The default_time_to_live attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTimeToLive
    {
        get => GetProperty<TerraformProperty<double>>("default_time_to_live");
        set => this.WithProperty("default_time_to_live", value);
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
    /// The keyspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyspaceName is required")]
    public required TerraformProperty<string> KeyspaceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("keyspace_name");
        set => this.WithProperty("keyspace_name", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
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
    /// Block for capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacitySpecification block(s) allowed")]
    public List<AwsKeyspacesTableCapacitySpecificationBlock>? CapacitySpecification
    {
        get => GetProperty<List<AwsKeyspacesTableCapacitySpecificationBlock>>("capacity_specification");
        set => this.WithProperty("capacity_specification", value);
    }

    /// <summary>
    /// Block for client_side_timestamps.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSideTimestamps block(s) allowed")]
    public List<AwsKeyspacesTableClientSideTimestampsBlock>? ClientSideTimestamps
    {
        get => GetProperty<List<AwsKeyspacesTableClientSideTimestampsBlock>>("client_side_timestamps");
        set => this.WithProperty("client_side_timestamps", value);
    }

    /// <summary>
    /// Block for comment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Comment block(s) allowed")]
    public List<AwsKeyspacesTableCommentBlock>? Comment
    {
        get => GetProperty<List<AwsKeyspacesTableCommentBlock>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// Block for encryption_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpecification block(s) allowed")]
    public List<AwsKeyspacesTableEncryptionSpecificationBlock>? EncryptionSpecification
    {
        get => GetProperty<List<AwsKeyspacesTableEncryptionSpecificationBlock>>("encryption_specification");
        set => this.WithProperty("encryption_specification", value);
    }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    public List<AwsKeyspacesTablePointInTimeRecoveryBlock>? PointInTimeRecovery
    {
        get => GetProperty<List<AwsKeyspacesTablePointInTimeRecoveryBlock>>("point_in_time_recovery");
        set => this.WithProperty("point_in_time_recovery", value);
    }

    /// <summary>
    /// Block for schema_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaDefinition block(s) allowed")]
    public List<AwsKeyspacesTableSchemaDefinitionBlock>? SchemaDefinition
    {
        get => GetProperty<List<AwsKeyspacesTableSchemaDefinitionBlock>>("schema_definition");
        set => this.WithProperty("schema_definition", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKeyspacesTableTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsKeyspacesTableTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public List<AwsKeyspacesTableTtlBlock>? Ttl
    {
        get => GetProperty<List<AwsKeyspacesTableTtlBlock>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
