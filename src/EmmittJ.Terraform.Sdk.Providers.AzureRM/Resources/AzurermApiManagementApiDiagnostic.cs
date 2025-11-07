using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<bool>? AlwaysLogErrors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("always_log_errors");
        set => this.WithProperty("always_log_errors", value);
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementLoggerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_logger_id");
        set => this.WithProperty("api_management_logger_id", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_name");
        set => this.WithProperty("api_name", value);
    }

    /// <summary>
    /// The http_correlation_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpCorrelationProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_correlation_protocol");
        set => this.WithProperty("http_correlation_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The log_client_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LogClientIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_client_ip");
        set => this.WithProperty("log_client_ip", value);
    }

    /// <summary>
    /// The operation_name_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OperationNameFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operation_name_format");
        set => this.WithProperty("operation_name_format", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SamplingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_percentage");
        set => this.WithProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The verbosity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Verbosity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("verbosity");
        set => this.WithProperty("verbosity", value);
    }

}
