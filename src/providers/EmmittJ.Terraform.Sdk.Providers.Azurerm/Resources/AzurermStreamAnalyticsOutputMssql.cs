using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsOutputMssql.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputMssqlTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_stream_analytics_output_mssql Terraform resource.
/// Manages a azurerm_stream_analytics_output_mssql resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputMssql(string name) : TerraformResource("azurerm_stream_analytics_output_mssql", name)
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationMode
    {
        get => new TerraformReference<string>(this, "authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => new TerraformReference<string>(this, "database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_batch_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxBatchCount
    {
        get => new TerraformReference<double>(this, "max_batch_count");
        set => SetArgument("max_batch_count", value);
    }

    /// <summary>
    /// The max_writer_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxWriterCount
    {
        get => new TerraformReference<double>(this, "max_writer_count");
        set => SetArgument("max_writer_count", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => new TerraformReference<string>(this, "stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => new TerraformReference<string>(this, "table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformValue<string>? User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsOutputMssqlTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsOutputMssqlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
