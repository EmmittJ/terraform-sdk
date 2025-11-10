using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for magnetic_store_write_properties in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The enable_magnetic_store_writes attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableMagneticStoreWrites
    {
        get => GetProperty<TerraformProperty<bool>>("enable_magnetic_store_writes");
        set => WithProperty("enable_magnetic_store_writes", value);
    }

}

/// <summary>
/// Block type for retention_properties in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableRetentionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The magnetic_store_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MagneticStoreRetentionPeriodInDays is required")]
    public required TerraformProperty<double> MagneticStoreRetentionPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("magnetic_store_retention_period_in_days");
        set => WithProperty("magnetic_store_retention_period_in_days", value);
    }

    /// <summary>
    /// The memory_store_retention_period_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryStoreRetentionPeriodInHours is required")]
    public required TerraformProperty<double> MemoryStoreRetentionPeriodInHours
    {
        get => GetProperty<TerraformProperty<double>>("memory_store_retention_period_in_hours");
        set => WithProperty("memory_store_retention_period_in_hours", value);
    }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableSchemaBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_timestreamwrite_table resource.
/// </summary>
public class AwsTimestreamwriteTable : TerraformResource
{
    public AwsTimestreamwriteTable(string name) : base("aws_timestreamwrite_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for magnetic_store_write_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreWriteProperties block(s) allowed")]
    public List<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>? MagneticStoreWriteProperties
    {
        get => GetProperty<List<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>>("magnetic_store_write_properties");
        set => this.WithProperty("magnetic_store_write_properties", value);
    }

    /// <summary>
    /// Block for retention_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionProperties block(s) allowed")]
    public List<AwsTimestreamwriteTableRetentionPropertiesBlock>? RetentionProperties
    {
        get => GetProperty<List<AwsTimestreamwriteTableRetentionPropertiesBlock>>("retention_properties");
        set => this.WithProperty("retention_properties", value);
    }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public List<AwsTimestreamwriteTableSchemaBlock>? Schema
    {
        get => GetProperty<List<AwsTimestreamwriteTableSchemaBlock>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
