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
        set => SetProperty("read_capacity_units", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThroughputMode
    {
        set => SetProperty("throughput_mode", value);
    }

    /// <summary>
    /// The write_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? WriteCapacityUnits
    {
        set => SetProperty("write_capacity_units", value);
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
        set => SetProperty("status", value);
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
        set => SetProperty("message", value);
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
        set => SetProperty("kms_key_identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("status", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("status", value);
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
        SetOutput("arn");
        SetOutput("default_time_to_live");
        SetOutput("id");
        SetOutput("keyspace_name");
        SetOutput("region");
        SetOutput("table_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The default_time_to_live attribute.
    /// </summary>
    public TerraformProperty<double> DefaultTimeToLive
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_time_to_live");
        set => SetProperty("default_time_to_live", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The keyspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyspaceName is required")]
    public required TerraformProperty<string> KeyspaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("keyspace_name");
        set => SetProperty("keyspace_name", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacitySpecification block(s) allowed")]
    public List<AwsKeyspacesTableCapacitySpecificationBlock>? CapacitySpecification
    {
        set => SetProperty("capacity_specification", value);
    }

    /// <summary>
    /// Block for client_side_timestamps.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSideTimestamps block(s) allowed")]
    public List<AwsKeyspacesTableClientSideTimestampsBlock>? ClientSideTimestamps
    {
        set => SetProperty("client_side_timestamps", value);
    }

    /// <summary>
    /// Block for comment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Comment block(s) allowed")]
    public List<AwsKeyspacesTableCommentBlock>? Comment
    {
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// Block for encryption_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpecification block(s) allowed")]
    public List<AwsKeyspacesTableEncryptionSpecificationBlock>? EncryptionSpecification
    {
        set => SetProperty("encryption_specification", value);
    }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    public List<AwsKeyspacesTablePointInTimeRecoveryBlock>? PointInTimeRecovery
    {
        set => SetProperty("point_in_time_recovery", value);
    }

    /// <summary>
    /// Block for schema_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaDefinition block(s) allowed")]
    public List<AwsKeyspacesTableSchemaDefinitionBlock>? SchemaDefinition
    {
        set => SetProperty("schema_definition", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKeyspacesTableTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public List<AwsKeyspacesTableTtlBlock>? Ttl
    {
        set => SetProperty("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
