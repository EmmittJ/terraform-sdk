using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDiagnosticBackendRequestBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformPropertyName("body_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformPropertyName("headers_to_log")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for backend_response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDiagnosticBackendResponseBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformPropertyName("body_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformPropertyName("headers_to_log")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for frontend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDiagnosticFrontendRequestBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformPropertyName("body_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformPropertyName("headers_to_log")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for frontend_response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDiagnosticFrontendResponseBlock
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformPropertyName("body_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformPropertyName("headers_to_log")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementDiagnosticTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_diagnostic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementDiagnostic : TerraformResource
{
    public AzurermApiManagementDiagnostic(string name) : base("azurerm_api_management_diagnostic", name)
    {
    }

    /// <summary>
    /// The always_log_errors attribute.
    /// </summary>
    [TerraformPropertyName("always_log_errors")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AlwaysLogErrors { get; set; } = default!;

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementLoggerId is required")]
    [TerraformPropertyName("api_management_logger_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiManagementLoggerId { get; set; }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    [TerraformPropertyName("http_correlation_protocol")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HttpCorrelationProtocol { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    [TerraformPropertyName("log_client_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LogClientIp { get; set; } = default!;

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    [TerraformPropertyName("operation_name_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OperationNameFormat { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformPropertyName("sampling_percentage")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SamplingPercentage { get; set; } = default!;

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    [TerraformPropertyName("verbosity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Verbosity { get; set; } = default!;

    /// <summary>
    /// Block for backend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendRequest block(s) allowed")]
    [TerraformPropertyName("backend_request")]
    public TerraformList<TerraformBlock<AzurermApiManagementDiagnosticBackendRequestBlock>>? BackendRequest { get; set; }

    /// <summary>
    /// Block for backend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendResponse block(s) allowed")]
    [TerraformPropertyName("backend_response")]
    public TerraformList<TerraformBlock<AzurermApiManagementDiagnosticBackendResponseBlock>>? BackendResponse { get; set; }

    /// <summary>
    /// Block for frontend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendRequest block(s) allowed")]
    [TerraformPropertyName("frontend_request")]
    public TerraformList<TerraformBlock<AzurermApiManagementDiagnosticFrontendRequestBlock>>? FrontendRequest { get; set; }

    /// <summary>
    /// Block for frontend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendResponse block(s) allowed")]
    [TerraformPropertyName("frontend_response")]
    public TerraformList<TerraformBlock<AzurermApiManagementDiagnosticFrontendResponseBlock>>? FrontendResponse { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementDiagnosticTimeoutsBlock>? Timeouts { get; set; }

}
