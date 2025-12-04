using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDatadogMonitorSsoConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermDatadogMonitorSsoConfigurationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_datadog_monitor_sso_configuration Terraform resource.
/// Manages a azurerm_datadog_monitor_sso_configuration resource.
/// </summary>
public partial class AzurermDatadogMonitorSsoConfiguration(string name) : TerraformResource("azurerm_datadog_monitor_sso_configuration", name)
{
    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    public required TerraformValue<string> DatadogMonitorId
    {
        get => GetArgument<TerraformValue<string>>("datadog_monitor_id");
        set => SetArgument("datadog_monitor_id", value);
    }

    /// <summary>
    /// The enterprise_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnterpriseApplicationId is required")]
    public required TerraformValue<string> EnterpriseApplicationId
    {
        get => GetArgument<TerraformValue<string>>("enterprise_application_id");
        set => SetArgument("enterprise_application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The single_sign_on attribute.
    /// </summary>
    public TerraformValue<string>? SingleSignOn
    {
        get => GetArgument<TerraformValue<string>>("single_sign_on");
        set => SetArgument("single_sign_on", value);
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? SingleSignOnEnabled
    {
        get => GetArgument<TerraformValue<string>>("single_sign_on_enabled");
        set => SetArgument("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The login_url attribute.
    /// </summary>
    public TerraformValue<string> LoginUrl
        => AsReference("login_url");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatadogMonitorSsoConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatadogMonitorSsoConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
