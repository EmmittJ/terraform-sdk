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
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    public TerraformProperty<string>? InstrumentationKey
    {
        set => SetProperty("instrumentation_key", value);
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
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointUri
    {
        set => SetProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The user_assigned_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityClientId
    {
        set => SetProperty("user_assigned_identity_client_id", value);
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
        SetOutput("api_management_name");
        SetOutput("buffered");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("resource_id");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_name");
        set => SetProperty("api_management_name", value);
    }

    /// <summary>
    /// The buffered attribute.
    /// </summary>
    public TerraformProperty<bool> Buffered
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("buffered");
        set => SetProperty("buffered", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// Block for application_insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsights block(s) allowed")]
    public List<AzurermApiManagementLoggerApplicationInsightsBlock>? ApplicationInsights
    {
        set => SetProperty("application_insights", value);
    }

    /// <summary>
    /// Block for eventhub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eventhub block(s) allowed")]
    public List<AzurermApiManagementLoggerEventhubBlock>? Eventhub
    {
        set => SetProperty("eventhub", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementLoggerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
