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
    public TerraformLiteralProperty<object>? EncryptionConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<object>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format");
        set => this.WithProperty("format", value);
    }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    public TerraformLiteralProperty<object>? MaintenanceConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<object>>("maintenance_configuration");
        set => this.WithProperty("maintenance_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableBucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_bucket_arn");
        set => this.WithProperty("table_bucket_arn", value);
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
