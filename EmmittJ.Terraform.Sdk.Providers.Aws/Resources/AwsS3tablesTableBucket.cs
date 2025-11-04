using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_table_bucket resource.
/// </summary>
public class AwsS3tablesTableBucket : TerraformResource
{
    public AwsS3tablesTableBucket(string name) : base("aws_s3tables_table_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("owner_account_id");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

}
