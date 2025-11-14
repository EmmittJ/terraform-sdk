using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for backend_request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementDiagnosticBackendRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_request";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformArgument("body_bytes")]
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformArgument("headers_to_log")]
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
public class AzurermApiManagementDiagnosticBackendResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_response";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformArgument("body_bytes")]
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformArgument("headers_to_log")]
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
public class AzurermApiManagementDiagnosticFrontendRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_request";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformArgument("body_bytes")]
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformArgument("headers_to_log")]
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
public class AzurermApiManagementDiagnosticFrontendResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_response";

    /// <summary>
    /// The body_bytes attribute.
    /// </summary>
    [TerraformArgument("body_bytes")]
    public TerraformValue<double>? BodyBytes
    {
        get => new TerraformReference<double>(this, "body_bytes");
        set => SetArgument("body_bytes", value);
    }

    /// <summary>
    /// The headers_to_log attribute.
    /// </summary>
    [TerraformArgument("headers_to_log")]
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
public class AzurermApiManagementDiagnosticTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("always_log_errors")]
    public TerraformValue<bool> AlwaysLogErrors
    {
        get => new TerraformReference<bool>(this, "always_log_errors");
        set => SetArgument("always_log_errors", value);
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementLoggerId is required")]
    [TerraformArgument("api_management_logger_id")]
    public required TerraformValue<string> ApiManagementLoggerId
    {
        get => new TerraformReference<string>(this, "api_management_logger_id");
        set => SetArgument("api_management_logger_id", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformArgument("api_management_name")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    [TerraformArgument("http_correlation_protocol")]
    public TerraformValue<string> HttpCorrelationProtocol
    {
        get => new TerraformReference<string>(this, "http_correlation_protocol");
        set => SetArgument("http_correlation_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformArgument("identifier")]
    public required TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    [TerraformArgument("log_client_ip")]
    public TerraformValue<bool> LogClientIp
    {
        get => new TerraformReference<bool>(this, "log_client_ip");
        set => SetArgument("log_client_ip", value);
    }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    [TerraformArgument("operation_name_format")]
    public TerraformValue<string>? OperationNameFormat
    {
        get => new TerraformReference<string>(this, "operation_name_format");
        set => SetArgument("operation_name_format", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformArgument("sampling_percentage")]
    public TerraformValue<double> SamplingPercentage
    {
        get => new TerraformReference<double>(this, "sampling_percentage");
        set => SetArgument("sampling_percentage", value);
    }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    [TerraformArgument("verbosity")]
    public TerraformValue<string> Verbosity
    {
        get => new TerraformReference<string>(this, "verbosity");
        set => SetArgument("verbosity", value);
    }

    /// <summary>
    /// Block for backend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendRequest block(s) allowed")]
    [TerraformArgument("backend_request")]
    public TerraformList<AzurermApiManagementDiagnosticBackendRequestBlock> BackendRequest { get; set; } = new();

    /// <summary>
    /// Block for backend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendResponse block(s) allowed")]
    [TerraformArgument("backend_response")]
    public TerraformList<AzurermApiManagementDiagnosticBackendResponseBlock> BackendResponse { get; set; } = new();

    /// <summary>
    /// Block for frontend_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendRequest block(s) allowed")]
    [TerraformArgument("frontend_request")]
    public TerraformList<AzurermApiManagementDiagnosticFrontendRequestBlock> FrontendRequest { get; set; } = new();

    /// <summary>
    /// Block for frontend_response.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendResponse block(s) allowed")]
    [TerraformArgument("frontend_response")]
    public TerraformList<AzurermApiManagementDiagnosticFrontendResponseBlock> FrontendResponse { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementDiagnosticTimeoutsBlock Timeouts { get; set; } = new();

}
