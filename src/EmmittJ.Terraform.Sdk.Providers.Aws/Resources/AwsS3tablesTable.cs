using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("created_by");
        this.DeclareOutput("metadata_location");
        this.DeclareOutput("modified_at");
        this.DeclareOutput("modified_by");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("type");
        this.DeclareOutput("version_token");
        this.DeclareOutput("warehouse_location");
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public object? EncryptionConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<object>>("encryption_configuration")?.Value;
        set => this.WithProperty("encryption_configuration", value == null ? null : new TerraformLiteralProperty<object>(value));
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public string? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format")?.Value;
        set => this.WithProperty("format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    public object? MaintenanceConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<object>>("maintenance_configuration")?.Value;
        set => this.WithProperty("maintenance_configuration", value == null ? null : new TerraformLiteralProperty<object>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public string? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace")?.Value;
        set => this.WithProperty("namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    public string? TableBucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_bucket_arn")?.Value;
        set => this.WithProperty("table_bucket_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
