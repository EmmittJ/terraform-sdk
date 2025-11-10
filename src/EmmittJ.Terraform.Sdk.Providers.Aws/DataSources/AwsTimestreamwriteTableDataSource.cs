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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
