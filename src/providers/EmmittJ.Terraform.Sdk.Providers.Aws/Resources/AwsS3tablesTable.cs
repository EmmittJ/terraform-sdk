using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata in AwsS3tablesTable.
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// Iceberg block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3tablesTableMetadataBlockIcebergBlock>? Iceberg
    {
        get => GetArgument<TerraformList<AwsS3tablesTableMetadataBlockIcebergBlock>>("iceberg");
        set => SetArgument("iceberg", value);
    }

}

/// <summary>
/// Block type for iceberg in AwsS3tablesTableMetadataBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlockIcebergBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iceberg";

    /// <summary>
    /// Schema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlock>? Schema
    {
        get => GetArgument<TerraformList<AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

}

/// <summary>
/// Block type for schema in AwsS3tablesTableMetadataBlockIcebergBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// Field block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlockFieldBlock>? Field
    {
        get => GetArgument<TerraformList<AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlockFieldBlock>>("field");
        set => SetArgument("field", value);
    }

}

/// <summary>
/// Block type for field in AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlockIcebergBlockSchemaBlockFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field";

    /// <summary>
    /// The name of the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A Boolean value that specifies whether values are required for each row in this field. Default: false.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => GetArgument<TerraformValue<bool>>("required") ?? CreateReference("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The field type. S3 Tables supports all Apache Iceberg primitive types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_s3tables_table Terraform resource.
/// Manages a aws_s3tables_table resource.
/// </summary>
public partial class AwsS3tablesTable(string name) : TerraformResource("aws_s3tables_table", name)
{
    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformMap<object> EncryptionConfiguration
    {
        get => GetArgument<TerraformMap<object>>("encryption_configuration") ?? CreateReference("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    public TerraformMap<object> MaintenanceConfiguration
    {
        get => GetArgument<TerraformMap<object>>("maintenance_configuration") ?? CreateReference("maintenance_configuration");
        set => SetArgument("maintenance_configuration", value);
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
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformValue<string> TableBucketArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_bucket_arn");
        set => SetArgument("table_bucket_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
        => CreateReference("created_by");

    /// <summary>
    /// The metadata_location attribute.
    /// </summary>
    public TerraformValue<string> MetadataLocation
        => CreateReference("metadata_location");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformValue<string> ModifiedAt
        => CreateReference("modified_at");

    /// <summary>
    /// The modified_by attribute.
    /// </summary>
    public TerraformValue<string> ModifiedBy
        => CreateReference("modified_by");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => CreateReference("owner_account_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The version_token attribute.
    /// </summary>
    public TerraformValue<string> VersionToken
        => CreateReference("version_token");

    /// <summary>
    /// The warehouse_location attribute.
    /// </summary>
    public TerraformValue<string> WarehouseLocation
        => CreateReference("warehouse_location");

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3tablesTableMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<AwsS3tablesTableMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

}
