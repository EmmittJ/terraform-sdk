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
        set => SetProperty("enable_magnetic_store_writes", value);
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
        set => SetProperty("magnetic_store_retention_period_in_days", value);
    }

    /// <summary>
    /// The memory_store_retention_period_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryStoreRetentionPeriodInHours is required")]
    public required TerraformProperty<double> MemoryStoreRetentionPeriodInHours
    {
        set => SetProperty("memory_store_retention_period_in_hours", value);
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
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTimestreamwriteTable : TerraformResource
{
    public AwsTimestreamwriteTable(string name) : base("aws_timestreamwrite_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("database_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("table_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for magnetic_store_write_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreWriteProperties block(s) allowed")]
    public List<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>? MagneticStoreWriteProperties
    {
        set => SetProperty("magnetic_store_write_properties", value);
    }

    /// <summary>
    /// Block for retention_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionProperties block(s) allowed")]
    public List<AwsTimestreamwriteTableRetentionPropertiesBlock>? RetentionProperties
    {
        set => SetProperty("retention_properties", value);
    }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public List<AwsTimestreamwriteTableSchemaBlock>? Schema
    {
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
