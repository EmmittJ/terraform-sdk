using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticBackendRequestBlock : TerraformBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? BodyBytes
    {
        set => SetProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        set => SetProperty("headers_to_log", value);
    }

}

/// <summary>
/// Block type for backend_response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticBackendResponseBlock : TerraformBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? BodyBytes
    {
        set => SetProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        set => SetProperty("headers_to_log", value);
    }

}

/// <summary>
/// Block type for frontend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticFrontendRequestBlock : TerraformBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? BodyBytes
    {
        set => SetProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        set => SetProperty("headers_to_log", value);
    }

}

/// <summary>
/// Block type for frontend_response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticFrontendResponseBlock : TerraformBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? BodyBytes
    {
        set => SetProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        set => SetProperty("headers_to_log", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiDiagnosticTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_api_diagnostic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementApiDiagnostic : TerraformResource
{
    public AzurermApiManagementApiDiagnostic(string name) : base("azurerm_api_management_api_diagnostic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("always_log_errors");
        SetOutput("api_management_logger_id");
        SetOutput("api_management_name");
        SetOutput("api_name");
        SetOutput("http_correlation_protocol");
        SetOutput("id");
        SetOutput("identifier");
        SetOutput("log_client_ip");
        SetOutput("operation_name_format");
        SetOutput("resource_group_name");
        SetOutput("sampling_percentage");
        SetOutput("verbosity");
    }

    /// <summary>
    /// The always_log_errors attribute.
    /// </summary>
    public TerraformProperty<bool> AlwaysLogErrors
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("always_log_errors");
        set => SetProperty("always_log_errors", value);
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementLoggerId is required")]
    public required TerraformProperty<string> ApiManagementLoggerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_logger_id");
        set => SetProperty("api_management_logger_id", value);
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
    /// The api_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiName is required")]
    public required TerraformProperty<string> ApiName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_name");
        set => SetProperty("api_name", value);
    }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    public TerraformProperty<string> HttpCorrelationProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_correlation_protocol");
        set => SetProperty("http_correlation_protocol", value);
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
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<string> Identifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier");
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    public TerraformProperty<bool> LogClientIp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_client_ip");
        set => SetProperty("log_client_ip", value);
    }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    public TerraformProperty<string> OperationNameFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operation_name_format");
        set => SetProperty("operation_name_format", value);
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
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double> SamplingPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sampling_percentage");
        set => SetProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    public TerraformProperty<string> Verbosity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("verbosity");
        set => SetProperty("verbosity", value);
    }

    /// <summary>
    /// Block for backend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendRequest block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticBackendRequestBlock>? BackendRequest
    {
        set => SetProperty("backend_request", value);
    }

    /// <summary>
    /// Block for backend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendResponse block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticBackendResponseBlock>? BackendResponse
    {
        set => SetProperty("backend_response", value);
    }

    /// <summary>
    /// Block for frontend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendRequest block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticFrontendRequestBlock>? FrontendRequest
    {
        set => SetProperty("frontend_request", value);
    }

    /// <summary>
    /// Block for frontend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendResponse block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticFrontendResponseBlock>? FrontendResponse
    {
        set => SetProperty("frontend_response", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiDiagnosticTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
