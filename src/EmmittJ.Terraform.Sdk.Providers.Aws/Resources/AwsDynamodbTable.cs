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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("hash_key");
        set => WithProperty("hash_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NonKeyAttributes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("non_key_attributes");
        set => WithProperty("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformProperty<string> ProjectionType
    {
        get => GetProperty<TerraformProperty<string>>("projection_type");
        set => WithProperty("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKey
    {
        get => GetProperty<TerraformProperty<string>>("range_key");
        set => WithProperty("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ReadCapacity
    {
        get => GetProperty<TerraformProperty<double>>("read_capacity");
        set => WithProperty("read_capacity", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WriteCapacity
    {
        get => GetProperty<TerraformProperty<double>>("write_capacity");
        set => WithProperty("write_capacity", value);
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
        get => GetProperty<TerraformProperty<string>>("input_compression_type");
        set => WithProperty("input_compression_type", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    public required TerraformProperty<string> InputFormat
    {
        get => GetProperty<TerraformProperty<string>>("input_format");
        set => WithProperty("input_format", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NonKeyAttributes
    {
        get => GetProperty<List<TerraformProperty<string>>>("non_key_attributes");
        set => WithProperty("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformProperty<string> ProjectionType
    {
        get => GetProperty<TerraformProperty<string>>("projection_type");
        set => WithProperty("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    public required TerraformProperty<string> RangeKey
    {
        get => GetProperty<TerraformProperty<string>>("range_key");
        set => WithProperty("range_key", value);
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
        get => GetProperty<TerraformProperty<double>>("max_read_request_units");
        set => WithProperty("max_read_request_units", value);
    }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaxWriteRequestUnits
    {
        get => GetProperty<TerraformProperty<double>>("max_write_request_units");
        set => WithProperty("max_write_request_units", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RecoveryPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("recovery_period_in_days");
        set => WithProperty("recovery_period_in_days", value);
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
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConsistencyMode
    {
        get => GetProperty<TerraformProperty<string>>("consistency_mode");
        set => WithProperty("consistency_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection_enabled");
        set => WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformProperty<bool>? PointInTimeRecovery
    {
        get => GetProperty<TerraformProperty<bool>>("point_in_time_recovery");
        set => WithProperty("point_in_time_recovery", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? PropagateTags
    {
        get => GetProperty<TerraformProperty<bool>>("propagate_tags");
        set => WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformProperty<string> RegionName
    {
        get => GetProperty<TerraformProperty<string>>("region_name");
        set => WithProperty("region_name", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformProperty<string>? StreamArn
    {
        get => GetProperty<TerraformProperty<string>>("stream_arn");
        set => WithProperty("stream_arn", value);
    }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformProperty<string>? StreamLabel
    {
        get => GetProperty<TerraformProperty<string>>("stream_label");
        set => WithProperty("stream_label", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
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
public class AwsDynamodbTableTtlBlock : TerraformBlock
{
    /// <summary>
    /// The attribute_name attribute.
    /// </summary>
    public TerraformProperty<string>? AttributeName
    {
        get => GetProperty<TerraformProperty<string>>("attribute_name");
        set => WithProperty("attribute_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetProperty<TerraformProperty<double>>("read_units_per_second");
        set => WithProperty("read_units_per_second", value);
    }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? WriteUnitsPerSecond
    {
        get => GetProperty<TerraformProperty<double>>("write_units_per_second");
        set => WithProperty("write_units_per_second", value);
    }

}

/// <summary>
/// Manages a aws_dynamodb_table resource.
/// </summary>
public class AwsDynamodbTable : TerraformResource
{
    public AwsDynamodbTable(string name) : base("aws_dynamodb_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("stream_arn");
        this.DeclareOutput("stream_label");
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? BillingMode
    {
        get => GetProperty<TerraformProperty<string>>("billing_mode");
        set => this.WithProperty("billing_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformProperty<string>? HashKey
    {
        get => GetProperty<TerraformProperty<string>>("hash_key");
        set => this.WithProperty("hash_key", value);
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
    /// The range_key attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKey
    {
        get => GetProperty<TerraformProperty<string>>("range_key");
        set => this.WithProperty("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ReadCapacity
    {
        get => GetProperty<TerraformProperty<double>>("read_capacity");
        set => this.WithProperty("read_capacity", value);
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
    /// The restore_date_time attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreDateTime
    {
        get => GetProperty<TerraformProperty<string>>("restore_date_time");
        set => this.WithProperty("restore_date_time", value);
    }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreSourceName
    {
        get => GetProperty<TerraformProperty<string>>("restore_source_name");
        set => this.WithProperty("restore_source_name", value);
    }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreSourceTableArn
    {
        get => GetProperty<TerraformProperty<string>>("restore_source_table_arn");
        set => this.WithProperty("restore_source_table_arn", value);
    }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    public TerraformProperty<bool>? RestoreToLatestTime
    {
        get => GetProperty<TerraformProperty<bool>>("restore_to_latest_time");
        set => this.WithProperty("restore_to_latest_time", value);
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StreamEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("stream_enabled");
        set => this.WithProperty("stream_enabled", value);
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformProperty<string>? StreamViewType
    {
        get => GetProperty<TerraformProperty<string>>("stream_view_type");
        set => this.WithProperty("stream_view_type", value);
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformProperty<string>? TableClass
    {
        get => GetProperty<TerraformProperty<string>>("table_class");
        set => this.WithProperty("table_class", value);
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
    /// The write_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WriteCapacity
    {
        get => GetProperty<TerraformProperty<double>>("write_capacity");
        set => this.WithProperty("write_capacity", value);
    }

    /// <summary>
    /// Block for attribute.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableAttributeBlock>? Attribute
    {
        get => GetProperty<HashSet<AwsDynamodbTableAttributeBlock>>("attribute");
        set => this.WithProperty("attribute", value);
    }

    /// <summary>
    /// Block for global_secondary_index.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableGlobalSecondaryIndexBlock>? GlobalSecondaryIndex
    {
        get => GetProperty<HashSet<AwsDynamodbTableGlobalSecondaryIndexBlock>>("global_secondary_index");
        set => this.WithProperty("global_secondary_index", value);
    }

    /// <summary>
    /// Block for import_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImportTable block(s) allowed")]
    public List<AwsDynamodbTableImportTableBlock>? ImportTable
    {
        get => GetProperty<List<AwsDynamodbTableImportTableBlock>>("import_table");
        set => this.WithProperty("import_table", value);
    }

    /// <summary>
    /// Block for local_secondary_index.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableLocalSecondaryIndexBlock>? LocalSecondaryIndex
    {
        get => GetProperty<HashSet<AwsDynamodbTableLocalSecondaryIndexBlock>>("local_secondary_index");
        set => this.WithProperty("local_secondary_index", value);
    }

    /// <summary>
    /// Block for on_demand_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    public List<AwsDynamodbTableOnDemandThroughputBlock>? OnDemandThroughput
    {
        get => GetProperty<List<AwsDynamodbTableOnDemandThroughputBlock>>("on_demand_throughput");
        set => this.WithProperty("on_demand_throughput", value);
    }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    public List<AwsDynamodbTablePointInTimeRecoveryBlock>? PointInTimeRecovery
    {
        get => GetProperty<List<AwsDynamodbTablePointInTimeRecoveryBlock>>("point_in_time_recovery");
        set => this.WithProperty("point_in_time_recovery", value);
    }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDynamodbTableReplicaBlock>? Replica
    {
        get => GetProperty<HashSet<AwsDynamodbTableReplicaBlock>>("replica");
        set => this.WithProperty("replica", value);
    }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public List<AwsDynamodbTableServerSideEncryptionBlock>? ServerSideEncryption
    {
        get => GetProperty<List<AwsDynamodbTableServerSideEncryptionBlock>>("server_side_encryption");
        set => this.WithProperty("server_side_encryption", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDynamodbTableTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDynamodbTableTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public List<AwsDynamodbTableTtlBlock>? Ttl
    {
        get => GetProperty<List<AwsDynamodbTableTtlBlock>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// Block for warm_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    public List<AwsDynamodbTableWarmThroughputBlock>? WarmThroughput
    {
        get => GetProperty<List<AwsDynamodbTableWarmThroughputBlock>>("warm_throughput");
        set => this.WithProperty("warm_throughput", value);
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
