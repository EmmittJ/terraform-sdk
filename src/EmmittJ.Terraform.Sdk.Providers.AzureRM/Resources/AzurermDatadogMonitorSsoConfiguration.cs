using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_datadog_monitor_sso_configuration resource.
/// </summary>
public class AzurermDatadogMonitorSsoConfiguration : TerraformResource
{
    public AzurermDatadogMonitorSsoConfiguration(string name) : base("azurerm_datadog_monitor_sso_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("login_url");
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    public string? DatadogMonitorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("datadog_monitor_id")?.Value;
        set => this.WithProperty("datadog_monitor_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enterprise_application_id attribute.
    /// </summary>
    public string? EnterpriseApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enterprise_application_id")?.Value;
        set => this.WithProperty("enterprise_application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The single_sign_on attribute.
    /// </summary>
    public string? SingleSignOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("single_sign_on")?.Value;
        set => this.WithProperty("single_sign_on", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? SingleSignOnEnabled
    {
        get => GetProperty<TerraformLiteralProperty<string>>("single_sign_on_enabled")?.Value;
        set => this.WithProperty("single_sign_on_enabled", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The login_url attribute.
    /// </summary>
    public TerraformExpression LoginUrl => this["login_url"];

}
