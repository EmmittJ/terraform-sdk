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
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
    {
        get => new TerraformReference<string>(this, "last_updated_time");
    }

    /// <summary>
    /// The magnetic_store_write_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MagneticStoreWriteProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "magnetic_store_write_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The retention_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RetentionProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "retention_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Schema
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "schema").ResolveNodes(ctx));
    }

    /// <summary>
    /// The table_status attribute.
    /// </summary>
    public TerraformValue<string> TableStatus
    {
        get => new TerraformReference<string>(this, "table_status");
    }

}
