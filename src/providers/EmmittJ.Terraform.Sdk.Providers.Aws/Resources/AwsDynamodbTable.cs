using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableAttributeBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for global_secondary_index in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableGlobalSecondaryIndexBlock : TerraformBlock
{
    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    public required TerraformProperty<string> HashKey
    {
        set => SetProperty("hash_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NonKeyAttributes
    {
        set => SetProperty("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformProperty<string> ProjectionType
    {
        set => SetProperty("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKey
    {
        set => SetProperty("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ReadCapacity
    {
        set => SetProperty("read_capacity", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WriteCapacity
    {
        set => SetProperty("write_capacity", value);
    }

}

/// <summary>
/// Block type for import_table in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlock : TerraformBlock
{
    /// <summary>
    /// The input_compression_type attribute.
    /// </summary>
    public TerraformProperty<string>? InputCompressionType
    {
        set => SetProperty("input_compression_type", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    public required TerraformProperty<string> InputFormat
    {
        set => SetProperty("input_format", value);
    }

}

/// <summary>
/// Block type for local_secondary_index in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableLocalSecondaryIndexBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NonKeyAttributes
    {
        set => SetProperty("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformProperty<string> ProjectionType
    {
        set => SetProperty("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    public required TerraformProperty<string> RangeKey
    {
        set => SetProperty("range_key", value);
    }

}

/// <summary>
/// Block type for on_demand_throughput in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableOnDemandThroughputBlock : TerraformBlock
{
    /// <summary>
    /// The max_read_request_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaxReadRequestUnits
    {
        set => SetProperty("max_read_request_units", value);
    }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaxWriteRequestUnits
    {
        set => SetProperty("max_write_request_units", value);
    }

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTablePointInTimeRecoveryBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RecoveryPeriodInDays
    {
        set => SetProperty("recovery_period_in_days", value);
    }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableReplicaBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConsistencyMode
    {
        set => SetProperty("consistency_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformProperty<bool>? PointInTimeRecovery
    {
        set => SetProperty("point_in_time_recovery", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? PropagateTags
    {
        set => SetProperty("propagate_tags", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformProperty<string> RegionName
    {
        set => SetProperty("region_name", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformProperty<string>? StreamArn
    {
        set => SetProperty("stream_arn", value);
    }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformProperty<string>? StreamLabel
    {
        set => SetProperty("stream_label", value);
    }

}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableTimeoutsBlock : TerraformBlock
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
public class AwsDynamodbTableTtlBlock : TerraformBlock
{
    /// <summary>
    /// The attribute_name attribute.
    /// </summary>
    public TerraformProperty<string>? AttributeName
    {
        set => SetProperty("attribute_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for warm_throughput in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableWarmThroughputBlock : TerraformBlock
{
    /// <summary>
    /// The read_units_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? ReadUnitsPerSecond
    {
        set => SetProperty("read_units_per_second", value);
    }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? WriteUnitsPerSecond
    {
        set => SetProperty("write_units_per_second", value);
    }

}

/// <summary>
/// Manages a aws_dynamodb_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDynamodbTable : TerraformResource
{
    public AwsDynamodbTable(string name) : base("aws_dynamodb_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("stream_arn");
        SetOutput("stream_label");
        SetOutput("billing_mode");
        SetOutput("deletion_protection_enabled");
        SetOutput("hash_key");
        SetOutput("id");
        SetOutput("name");
        SetOutput("range_key");
        SetOutput("read_capacity");
        SetOutput("region");
        SetOutput("restore_date_time");
        SetOutput("restore_source_name");
        SetOutput("restore_source_table_arn");
        SetOutput("restore_to_latest_time");
        SetOutput("stream_enabled");
        SetOutput("stream_view_type");
        SetOutput("table_class");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("write_capacity");
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformProperty<string> BillingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_mode");
        set => SetProperty("billing_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection_enabled");
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformProperty<string> HashKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hash_key");
        set => SetProperty("hash_key", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformProperty<string> RangeKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("range_key");
        set => SetProperty("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformProperty<double> ReadCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("read_capacity");
        set => SetProperty("read_capacity", value);
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
    /// The restore_date_time attribute.
    /// </summary>
    public TerraformProperty<string> RestoreDateTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_date_time");
        set => SetProperty("restore_date_time", value);
    }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    public TerraformProperty<string> RestoreSourceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_source_name");
        set => SetProperty("restore_source_name", value);
    }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    public TerraformProperty<string> RestoreSourceTableArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_source_table_arn");
        set => SetProperty("restore_source_table_arn", value);
    }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    public TerraformProperty<bool> RestoreToLatestTime
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("restore_to_latest_time");
        set => SetProperty("restore_to_latest_time", value);
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> StreamEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("stream_enabled");
        set => SetProperty("stream_enabled", value);
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformProperty<string> StreamViewType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_view_type");
        set => SetProperty("stream_view_type", value);
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformProperty<string> TableClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_class");
        set => SetProperty("table_class", value);
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
    /// The write_capacity attribute.
    /// </summary>
    public TerraformProperty<double> WriteCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("write_capacity");
        set => SetProperty("write_capacity", value);
    }

    /// <summary>
    /// Block for attribute.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableAttributeBlock>? Attribute
    {
        set => SetProperty("attribute", value);
    }

    /// <summary>
    /// Block for global_secondary_index.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableGlobalSecondaryIndexBlock>? GlobalSecondaryIndex
    {
        set => SetProperty("global_secondary_index", value);
    }

    /// <summary>
    /// Block for import_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImportTable block(s) allowed")]
    public List<AwsDynamodbTableImportTableBlock>? ImportTable
    {
        set => SetProperty("import_table", value);
    }

    /// <summary>
    /// Block for local_secondary_index.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableLocalSecondaryIndexBlock>? LocalSecondaryIndex
    {
        set => SetProperty("local_secondary_index", value);
    }

    /// <summary>
    /// Block for on_demand_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    public List<AwsDynamodbTableOnDemandThroughputBlock>? OnDemandThroughput
    {
        set => SetProperty("on_demand_throughput", value);
    }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    public List<AwsDynamodbTablePointInTimeRecoveryBlock>? PointInTimeRecovery
    {
        set => SetProperty("point_in_time_recovery", value);
    }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableReplicaBlock>? Replica
    {
        set => SetProperty("replica", value);
    }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public List<AwsDynamodbTableServerSideEncryptionBlock>? ServerSideEncryption
    {
        set => SetProperty("server_side_encryption", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDynamodbTableTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public List<AwsDynamodbTableTtlBlock>? Ttl
    {
        set => SetProperty("ttl", value);
    }

    /// <summary>
    /// Block for warm_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    public List<AwsDynamodbTableWarmThroughputBlock>? WarmThroughput
    {
        set => SetProperty("warm_throughput", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformExpression StreamArn => this["stream_arn"];

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformExpression StreamLabel => this["stream_label"];

}
