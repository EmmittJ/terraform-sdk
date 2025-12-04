using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_timestreamwrite_table Terraform data source.
/// Retrieves information about a aws_timestreamwrite_table.
/// </summary>
public partial class AwsTimestreamwriteTableDataSource(string name) : TerraformDataSource("aws_timestreamwrite_table", name)
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => AsReference("last_updated_time");

    /// <summary>
    /// The magnetic_store_write_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MagneticStoreWriteProperties
        => AsReference("magnetic_store_write_properties");

    /// <summary>
    /// The retention_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RetentionProperties
        => AsReference("retention_properties");

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Schema
        => AsReference("schema");

    /// <summary>
    /// The table_status attribute.
    /// </summary>
    public TerraformValue<string> TableStatus
        => AsReference("table_status");

}
