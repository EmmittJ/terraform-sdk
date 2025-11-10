using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_s3tables_table resource.
/// </summary>
public class AwsS3tablesTable : TerraformResource
{
    public AwsS3tablesTable(string name) : base("aws_s3tables_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_at");
        this.WithOutput("created_by");
        this.WithOutput("metadata_location");
        this.WithOutput("modified_at");
        this.WithOutput("modified_by");
        this.WithOutput("owner_account_id");
        this.WithOutput("type");
        this.WithOutput("version_token");
        this.WithOutput("warehouse_location");
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformProperty<object>? EncryptionConfiguration
    {
        get => GetProperty<TerraformProperty<object>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetRequiredProperty<TerraformProperty<string>>("format");
        set => this.WithProperty("format", value);
    }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    public TerraformProperty<object>? MaintenanceConfiguration
    {
        get => GetProperty<TerraformProperty<object>>("maintenance_configuration");
        set => this.WithProperty("maintenance_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformProperty<string> TableBucketArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_bucket_arn");
        set => this.WithProperty("table_bucket_arn", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3tablesTableMetadataBlock>? Metadata
    {
        get => GetProperty<List<AwsS3tablesTableMetadataBlock>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The metadata_location attribute.
    /// </summary>
    public TerraformExpression MetadataLocation => this["metadata_location"];

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformExpression ModifiedAt => this["modified_at"];

    /// <summary>
    /// The modified_by attribute.
    /// </summary>
    public TerraformExpression ModifiedBy => this["modified_by"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The version_token attribute.
    /// </summary>
    public TerraformExpression VersionToken => this["version_token"];

    /// <summary>
    /// The warehouse_location attribute.
    /// </summary>
    public TerraformExpression WarehouseLocation => this["warehouse_location"];

}
