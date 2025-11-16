using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for backend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticBackendRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_request";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public TerraformSet<string>? HeadersToLog
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers_to_log").ResolveNodes(ctx));
        set => SetArgument("headers_to_log", value);
    }

}

/// <summary>
/// Block type for backend_response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticBackendResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_response";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public TerraformSet<string>? HeadersToLog
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers_to_log").ResolveNodes(ctx));
        set => SetArgument("headers_to_log", value);
    }

}

/// <summary>
/// Block type for frontend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticFrontendRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_request";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public TerraformSet<string>? HeadersToLog
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers_to_log").ResolveNodes(ctx));
        set => SetArgument("headers_to_log", value);
    }

}

/// <summary>
/// Block type for frontend_response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiDiagnosticFrontendResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_response";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    public TerraformSet<string>? HeadersToLog
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers_to_log").ResolveNodes(ctx));
        set => SetArgument("headers_to_log", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiDiagnosticTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_api_diagnostic Terraform resource.
/// Manages a azurerm_api_management_api_diagnostic resource.
/// </summary>
public partial class AzurermApiManagementApiDiagnostic(string name) : TerraformResource("azurerm_api_management_api_diagnostic", name)
{
    /// <summary>
    /// The always_log_errors attribute.
    /// </summary>
    public TerraformValue<bool> AlwaysLogErrors
    {
        get => new TerraformReference<bool>(this, "always_log_errors");
        set => SetArgument("always_log_errors", value);
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementLoggerId is required")]
    public required TerraformValue<string> ApiManagementLoggerId
    {
        get => new TerraformReference<string>(this, "api_management_logger_id");
        set => SetArgument("api_management_logger_id", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiName is required")]
    public required TerraformValue<string> ApiName
    {
        get => new TerraformReference<string>(this, "api_name");
        set => SetArgument("api_name", value);
    }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    public TerraformValue<string> HttpCorrelationProtocol
    {
        get => new TerraformReference<string>(this, "http_correlation_protocol");
        set => SetArgument("http_correlation_protocol", value);
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
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    public TerraformValue<bool> LogClientIp
    {
        get => new TerraformReference<bool>(this, "log_client_ip");
        set => SetArgument("log_client_ip", value);
    }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    public TerraformValue<string>? OperationNameFormat
    {
        get => new TerraformReference<string>(this, "operation_name_format");
        set => SetArgument("operation_name_format", value);
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
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformValue<double> SamplingPercentage
    {
        get => new TerraformReference<double>(this, "sampling_percentage");
        set => SetArgument("sampling_percentage", value);
    }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    public TerraformValue<string> Verbosity
    {
        get => new TerraformReference<string>(this, "verbosity");
        set => SetArgument("verbosity", value);
    }

    /// <summary>
    /// BackendRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendRequest block(s) allowed")]
    public TerraformList<AzurermApiManagementApiDiagnosticBackendRequestBlock>? BackendRequest
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiDiagnosticBackendRequestBlock>>("backend_request");
        set => SetArgument("backend_request", value);
    }

    /// <summary>
    /// BackendResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendResponse block(s) allowed")]
    public TerraformList<AzurermApiManagementApiDiagnosticBackendResponseBlock>? BackendResponse
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiDiagnosticBackendResponseBlock>>("backend_response");
        set => SetArgument("backend_response", value);
    }

    /// <summary>
    /// FrontendRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendRequest block(s) allowed")]
    public TerraformList<AzurermApiManagementApiDiagnosticFrontendRequestBlock>? FrontendRequest
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiDiagnosticFrontendRequestBlock>>("frontend_request");
        set => SetArgument("frontend_request", value);
    }

    /// <summary>
    /// FrontendResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendResponse block(s) allowed")]
    public TerraformList<AzurermApiManagementApiDiagnosticFrontendResponseBlock>? FrontendResponse
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiDiagnosticFrontendResponseBlock>>("frontend_response");
        set => SetArgument("frontend_response", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiDiagnosticTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiDiagnosticTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
