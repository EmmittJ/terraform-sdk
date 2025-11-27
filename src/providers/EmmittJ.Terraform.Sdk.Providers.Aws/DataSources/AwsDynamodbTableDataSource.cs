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
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

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
    public TerraformMap<string> Tags
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
    /// The attribute attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Attribute
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "attribute").ResolveNodes(ctx));
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformValue<string> BillingMode
    {
        get => new TerraformReference<string>(this, "billing_mode");
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
    }

    /// <summary>
    /// The global_secondary_index attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> GlobalSecondaryIndex
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "global_secondary_index").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformValue<string> HashKey
    {
        get => new TerraformReference<string>(this, "hash_key");
    }

    /// <summary>
    /// The local_secondary_index attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LocalSecondaryIndex
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "local_secondary_index").ResolveNodes(ctx));
    }

    /// <summary>
    /// The on_demand_throughput attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OnDemandThroughput
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "on_demand_throughput").ResolveNodes(ctx));
    }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PointInTimeRecovery
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "point_in_time_recovery").ResolveNodes(ctx));
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string> RangeKey
    {
        get => new TerraformReference<string>(this, "range_key");
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformValue<double> ReadCapacity
    {
        get => new TerraformReference<double>(this, "read_capacity");
    }

    /// <summary>
    /// The replica attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Replica
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "replica").ResolveNodes(ctx));
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformValue<bool> StreamEnabled
    {
        get => new TerraformReference<bool>(this, "stream_enabled");
    }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformValue<string> StreamLabel
    {
        get => new TerraformReference<string>(this, "stream_label");
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformValue<string> StreamViewType
    {
        get => new TerraformReference<string>(this, "stream_view_type");
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformValue<string> TableClass
    {
        get => new TerraformReference<string>(this, "table_class");
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Ttl
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "ttl").ResolveNodes(ctx));
    }

    /// <summary>
    /// The warm_throughput attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WarmThroughput
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "warm_throughput").ResolveNodes(ctx));
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformValue<double> WriteCapacity
    {
        get => new TerraformReference<double>(this, "write_capacity");
    }

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
