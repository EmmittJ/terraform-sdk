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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A Boolean value that specifies whether values are required for each row in this field. Default: false.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The field type. S3 Tables supports all Apache Iceberg primitive types.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => TerraformMap<object>.Lazy(ctx => new TerraformReference<TerraformMap<object>>(this, "encryption_configuration").ResolveNodes(ctx));
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    public TerraformMap<object> MaintenanceConfiguration
    {
        get => TerraformMap<object>.Lazy(ctx => new TerraformReference<TerraformMap<object>>(this, "maintenance_configuration").ResolveNodes(ctx));
        set => SetArgument("maintenance_configuration", value);
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
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
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
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformValue<string> TableBucketArn
    {
        get => new TerraformReference<string>(this, "table_bucket_arn");
        set => SetArgument("table_bucket_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
    }

    /// <summary>
    /// The metadata_location attribute.
    /// </summary>
    public TerraformValue<string> MetadataLocation
    {
        get => new TerraformReference<string>(this, "metadata_location");
    }

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformValue<string> ModifiedAt
    {
        get => new TerraformReference<string>(this, "modified_at");
    }

    /// <summary>
    /// The modified_by attribute.
    /// </summary>
    public TerraformValue<string> ModifiedBy
    {
        get => new TerraformReference<string>(this, "modified_by");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The version_token attribute.
    /// </summary>
    public TerraformValue<string> VersionToken
    {
        get => new TerraformReference<string>(this, "version_token");
    }

    /// <summary>
    /// The warehouse_location attribute.
    /// </summary>
    public TerraformValue<string> WarehouseLocation
    {
        get => new TerraformReference<string>(this, "warehouse_location");
    }

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3tablesTableMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<AwsS3tablesTableMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

}
