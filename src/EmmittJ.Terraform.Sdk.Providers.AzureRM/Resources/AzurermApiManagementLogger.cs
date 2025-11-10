using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for application_insights in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementLoggerApplicationInsightsBlock : TerraformBlock
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => WithProperty("connection_string", value);
    }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    public TerraformProperty<string>? InstrumentationKey
    {
        get => GetProperty<TerraformProperty<string>>("instrumentation_key");
        set => WithProperty("instrumentation_key", value);
    }

}

/// <summary>
/// Block type for eventhub in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementLoggerEventhubBlock : TerraformBlock
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => WithProperty("connection_string", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointUri
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_uri");
        set => WithProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The user_assigned_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_client_id");
        set => WithProperty("user_assigned_identity_client_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementLoggerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_logger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementLogger : TerraformResource
{
    public AzurermApiManagementLogger(string name) : base("azurerm_api_management_logger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The buffered attribute.
    /// </summary>
    public TerraformProperty<bool>? Buffered
    {
        get => GetProperty<TerraformProperty<bool>>("buffered");
        set => this.WithProperty("buffered", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// Block for application_insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsights block(s) allowed")]
    public List<AzurermApiManagementLoggerApplicationInsightsBlock>? ApplicationInsights
    {
        get => GetProperty<List<AzurermApiManagementLoggerApplicationInsightsBlock>>("application_insights");
        set => this.WithProperty("application_insights", value);
    }

    /// <summary>
    /// Block for eventhub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eventhub block(s) allowed")]
    public List<AzurermApiManagementLoggerEventhubBlock>? Eventhub
    {
        get => GetProperty<List<AzurermApiManagementLoggerEventhubBlock>>("eventhub");
        set => this.WithProperty("eventhub", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementLoggerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementLoggerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
