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
    public TerraformProperty<bool>? AlwaysLogErrors
    {
        get => GetProperty<TerraformProperty<bool>>("always_log_errors");
        set => this.WithProperty("always_log_errors", value);
    }

    /// <summary>
    /// The api_management_logger_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementLoggerId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_logger_id");
        set => this.WithProperty("api_management_logger_id", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
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
    public TerraformProperty<string>? Identifier
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
    public TerraformProperty<string>? ResourceGroupName
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

}
