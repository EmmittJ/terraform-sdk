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
        get => GetProperty<TerraformProperty<double>>("body_bytes");
        set => WithProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("headers_to_log");
        set => WithProperty("headers_to_log", value);
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
        get => GetProperty<TerraformProperty<double>>("body_bytes");
        set => WithProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("headers_to_log");
        set => WithProperty("headers_to_log", value);
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
        get => GetProperty<TerraformProperty<double>>("body_bytes");
        set => WithProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("headers_to_log");
        set => WithProperty("headers_to_log", value);
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
        get => GetProperty<TerraformProperty<double>>("body_bytes");
        set => WithProperty("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HeadersToLog
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("headers_to_log");
        set => WithProperty("headers_to_log", value);
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
/// Manages a azurerm_api_management_api_diagnostic resource.
/// </summary>
public class AzurermApiManagementApiDiagnostic : TerraformResource
{
    public AzurermApiManagementApiDiagnostic(string name) : base("azurerm_api_management_api_diagnostic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The always_log_errors attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysLogErrors
    {
        get => GetProperty<TerraformProperty<bool>>("always_log_errors");
        set => this.WithProperty("always_log_errors", value);
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementLoggerId is required")]
    public required TerraformProperty<string> ApiManagementLoggerId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_logger_id");
        set => this.WithProperty("api_management_logger_id", value);
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
    /// The api_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiName is required")]
    public required TerraformProperty<string> ApiName
    {
        get => GetProperty<TerraformProperty<string>>("api_name");
        set => this.WithProperty("api_name", value);
    }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? HttpCorrelationProtocol
    {
        get => GetProperty<TerraformProperty<string>>("http_correlation_protocol");
        set => this.WithProperty("http_correlation_protocol", value);
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
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<string> Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    public TerraformProperty<bool>? LogClientIp
    {
        get => GetProperty<TerraformProperty<bool>>("log_client_ip");
        set => this.WithProperty("log_client_ip", value);
    }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    public TerraformProperty<string>? OperationNameFormat
    {
        get => GetProperty<TerraformProperty<string>>("operation_name_format");
        set => this.WithProperty("operation_name_format", value);
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
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? SamplingPercentage
    {
        get => GetProperty<TerraformProperty<double>>("sampling_percentage");
        set => this.WithProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    public TerraformProperty<string>? Verbosity
    {
        get => GetProperty<TerraformProperty<string>>("verbosity");
        set => this.WithProperty("verbosity", value);
    }

    /// <summary>
    /// Block for backend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendRequest block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticBackendRequestBlock>? BackendRequest
    {
        get => GetProperty<List<AzurermApiManagementApiDiagnosticBackendRequestBlock>>("backend_request");
        set => this.WithProperty("backend_request", value);
    }

    /// <summary>
    /// Block for backend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendResponse block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticBackendResponseBlock>? BackendResponse
    {
        get => GetProperty<List<AzurermApiManagementApiDiagnosticBackendResponseBlock>>("backend_response");
        set => this.WithProperty("backend_response", value);
    }

    /// <summary>
    /// Block for frontend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendRequest block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticFrontendRequestBlock>? FrontendRequest
    {
        get => GetProperty<List<AzurermApiManagementApiDiagnosticFrontendRequestBlock>>("frontend_request");
        set => this.WithProperty("frontend_request", value);
    }

    /// <summary>
    /// Block for frontend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendResponse block(s) allowed")]
    public List<AzurermApiManagementApiDiagnosticFrontendResponseBlock>? FrontendResponse
    {
        get => GetProperty<List<AzurermApiManagementApiDiagnosticFrontendResponseBlock>>("frontend_response");
        set => this.WithProperty("frontend_response", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiDiagnosticTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementApiDiagnosticTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
