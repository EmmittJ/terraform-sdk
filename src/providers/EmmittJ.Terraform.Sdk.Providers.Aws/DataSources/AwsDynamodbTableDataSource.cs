using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in AwsDynamodbTableDataSource.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableDataSourceServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

}


/// <summary>
/// Represents a aws_dynamodb_table Terraform data source.
/// Retrieves information about a aws_dynamodb_table.
/// </summary>
public partial class AwsDynamodbTableDataSource(string name) : TerraformDataSource("aws_dynamodb_table", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Attribute
        => AsReference("attribute");

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformValue<string> BillingMode
        => AsReference("billing_mode");

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
        => AsReference("deletion_protection_enabled");

    /// <summary>
    /// The global_secondary_index attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> GlobalSecondaryIndex
        => AsReference("global_secondary_index");

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformValue<string> HashKey
        => AsReference("hash_key");

    /// <summary>
    /// The local_secondary_index attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LocalSecondaryIndex
        => AsReference("local_secondary_index");

    /// <summary>
    /// The on_demand_throughput attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OnDemandThroughput
        => AsReference("on_demand_throughput");

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PointInTimeRecovery
        => AsReference("point_in_time_recovery");

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string> RangeKey
        => AsReference("range_key");

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformValue<double> ReadCapacity
        => AsReference("read_capacity");

    /// <summary>
    /// The replica attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Replica
        => AsReference("replica");

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string> StreamArn
        => AsReference("stream_arn");

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformValue<bool> StreamEnabled
        => AsReference("stream_enabled");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformValue<string> StreamLabel
        => AsReference("stream_label");

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformValue<string> StreamViewType
        => AsReference("stream_view_type");

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformValue<string> TableClass
        => AsReference("table_class");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Ttl
        => AsReference("ttl");

    /// <summary>
    /// The warm_throughput attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WarmThroughput
        => AsReference("warm_throughput");

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformValue<double> WriteCapacity
        => AsReference("write_capacity");

    /// <summary>
    /// ServerSideEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public TerraformList<AwsDynamodbTableDataSourceServerSideEncryptionBlock>? ServerSideEncryption
    {
        get => GetArgument<TerraformList<AwsDynamodbTableDataSourceServerSideEncryptionBlock>>("server_side_encryption");
        set => SetArgument("server_side_encryption", value);
    }

}
