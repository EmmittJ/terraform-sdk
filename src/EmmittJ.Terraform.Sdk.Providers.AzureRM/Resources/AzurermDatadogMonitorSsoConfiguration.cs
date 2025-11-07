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
    public TerraformProperty<string>? DatadogMonitorId
    {
        get => GetProperty<TerraformProperty<string>>("datadog_monitor_id");
        set => this.WithProperty("datadog_monitor_id", value);
    }

    /// <summary>
    /// The enterprise_application_id attribute.
    /// </summary>
    public TerraformProperty<string>? EnterpriseApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("enterprise_application_id");
        set => this.WithProperty("enterprise_application_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The single_sign_on attribute.
    /// </summary>
    public TerraformProperty<string>? SingleSignOn
    {
        get => GetProperty<TerraformProperty<string>>("single_sign_on");
        set => this.WithProperty("single_sign_on", value);
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? SingleSignOnEnabled
    {
        get => GetProperty<TerraformProperty<string>>("single_sign_on_enabled");
        set => this.WithProperty("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The login_url attribute.
    /// </summary>
    public TerraformExpression LoginUrl => this["login_url"];

}
