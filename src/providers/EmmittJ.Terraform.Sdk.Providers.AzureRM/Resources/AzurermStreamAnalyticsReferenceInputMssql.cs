using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsReferenceInputMssqlTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_stream_analytics_reference_input_mssql resource.
/// </summary>
public class AzurermStreamAnalyticsReferenceInputMssql : TerraformResource
{
    public AzurermStreamAnalyticsReferenceInputMssql(string name) : base("azurerm_stream_analytics_reference_input_mssql", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("database");
        SetOutput("delta_snapshot_query");
        SetOutput("full_snapshot_query");
        SetOutput("id");
        SetOutput("name");
        SetOutput("password");
        SetOutput("refresh_interval_duration");
        SetOutput("refresh_type");
        SetOutput("resource_group_name");
        SetOutput("server");
        SetOutput("stream_analytics_job_name");
        SetOutput("table");
        SetOutput("username");
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The delta_snapshot_query attribute.
    /// </summary>
    public TerraformProperty<string> DeltaSnapshotQuery
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delta_snapshot_query");
        set => SetProperty("delta_snapshot_query", value);
    }

    /// <summary>
    /// The full_snapshot_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullSnapshotQuery is required")]
    public required TerraformProperty<string> FullSnapshotQuery
    {
        get => GetRequiredOutput<TerraformProperty<string>>("full_snapshot_query");
        set => SetProperty("full_snapshot_query", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The refresh_interval_duration attribute.
    /// </summary>
    public TerraformProperty<string> RefreshIntervalDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("refresh_interval_duration");
        set => SetProperty("refresh_interval_duration", value);
    }

    /// <summary>
    /// The refresh_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshType is required")]
    public required TerraformProperty<string> RefreshType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("refresh_type");
        set => SetProperty("refresh_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server");
        set => SetProperty("server", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_name");
        set => SetProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public TerraformProperty<string> Table
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table");
        set => SetProperty("table", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsReferenceInputMssqlTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
