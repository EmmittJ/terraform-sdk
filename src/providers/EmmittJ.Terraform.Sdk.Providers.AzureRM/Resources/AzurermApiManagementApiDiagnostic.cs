using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_request in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiDiagnosticBackendRequestBlock : TerraformBlockBase
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformProperty("body_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformProperty("headers_to_log")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for backend_response in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiDiagnosticBackendResponseBlock : TerraformBlockBase
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformProperty("body_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformProperty("headers_to_log")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for frontend_request in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiDiagnosticFrontendRequestBlock : TerraformBlockBase
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformProperty("body_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformProperty("headers_to_log")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for frontend_response in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementApiDiagnosticFrontendResponseBlock : TerraformBlockBase
{
    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformProperty("body_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BodyBytes { get; set; }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformProperty("headers_to_log")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? HeadersToLog { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementApiDiagnosticTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_api_diagnostic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApiManagementApiDiagnostic : TerraformResource
{
    public AzurermApiManagementApiDiagnostic(string name) : base("azurerm_api_management_api_diagnostic", name)
    {
    }

    /// <summary>
    /// The always_log_errors attribute.
    /// </summary>
    [TerraformProperty("always_log_errors")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AlwaysLogErrors { get; set; }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementLoggerId is required")]
    [TerraformProperty("api_management_logger_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementLoggerId { get; set; }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiName is required")]
    [TerraformProperty("api_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiName { get; set; }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    [TerraformProperty("http_correlation_protocol")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpCorrelationProtocol { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    [TerraformProperty("log_client_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> LogClientIp { get; set; }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    [TerraformProperty("operation_name_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperationNameFormat { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformProperty("sampling_percentage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SamplingPercentage { get; set; }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    [TerraformProperty("verbosity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Verbosity { get; set; }

    /// <summary>
    /// Block for backend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendRequest block(s) allowed")]
    [TerraformProperty("backend_request")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementApiDiagnosticBackendRequestBlock>>? BackendRequest { get; set; }

    /// <summary>
    /// Block for backend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendResponse block(s) allowed")]
    [TerraformProperty("backend_response")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementApiDiagnosticBackendResponseBlock>>? BackendResponse { get; set; }

    /// <summary>
    /// Block for frontend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendRequest block(s) allowed")]
    [TerraformProperty("frontend_request")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementApiDiagnosticFrontendRequestBlock>>? FrontendRequest { get; set; }

    /// <summary>
    /// Block for frontend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendResponse block(s) allowed")]
    [TerraformProperty("frontend_response")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementApiDiagnosticFrontendResponseBlock>>? FrontendResponse { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApiManagementApiDiagnosticTimeoutsBlock>? Timeouts { get; set; }

}
