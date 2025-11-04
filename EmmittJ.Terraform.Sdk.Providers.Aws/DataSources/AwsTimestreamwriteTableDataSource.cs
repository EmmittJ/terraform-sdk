using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_timestreamwrite_table.
/// </summary>
public class AwsTimestreamwriteTableDataSource : TerraformDataSource
{
    public AwsTimestreamwriteTableDataSource(string name) : base("aws_timestreamwrite_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("magnetic_store_write_properties");
        this.DeclareOutput("retention_properties");
        this.DeclareOutput("schema");
        this.DeclareOutput("table_status");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The magnetic_store_write_properties attribute.
    /// </summary>
    public TerraformExpression MagneticStoreWriteProperties => this["magnetic_store_write_properties"];

    /// <summary>
    /// The retention_properties attribute.
    /// </summary>
    public TerraformExpression RetentionProperties => this["retention_properties"];

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformExpression Schema => this["schema"];

    /// <summary>
    /// The table_status attribute.
    /// </summary>
    public TerraformExpression TableStatus => this["table_status"];

}
