using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_diagnostic resource.
/// </summary>
public class AzurermApiManagementDiagnostic : TerraformResource
{
    public AzurermApiManagementDiagnostic(string name) : base("azurerm_api_management_diagnostic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The always_log_errors attribute.
    /// </summary>
    public bool? AlwaysLogErrors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("always_log_errors")?.Value;
        set => this.WithProperty("always_log_errors", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    public string? ApiManagementLoggerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_logger_id")?.Value;
        set => this.WithProperty("api_management_logger_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    public string? HttpCorrelationProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_correlation_protocol")?.Value;
        set => this.WithProperty("http_correlation_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public string? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier")?.Value;
        set => this.WithProperty("identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    public bool? LogClientIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_client_ip")?.Value;
        set => this.WithProperty("log_client_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    public string? OperationNameFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operation_name_format")?.Value;
        set => this.WithProperty("operation_name_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public double? SamplingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_percentage")?.Value;
        set => this.WithProperty("sampling_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    public string? Verbosity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("verbosity")?.Value;
        set => this.WithProperty("verbosity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
