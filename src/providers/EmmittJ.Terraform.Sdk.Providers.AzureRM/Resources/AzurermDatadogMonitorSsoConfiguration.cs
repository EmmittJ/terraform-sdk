using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "datadog_monitor_id");
        set => SetArgument("datadog_monitor_id", value);
    }

    /// <summary>
    /// The enterprise_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnterpriseApplicationId is required")]
    public required TerraformValue<string> EnterpriseApplicationId
    {
        get => new TerraformReference<string>(this, "enterprise_application_id");
        set => SetArgument("enterprise_application_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The single_sign_on attribute.
    /// </summary>
    public TerraformValue<string> SingleSignOn
    {
        get => new TerraformReference<string>(this, "single_sign_on");
        set => SetArgument("single_sign_on", value);
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> SingleSignOnEnabled
    {
        get => new TerraformReference<string>(this, "single_sign_on_enabled");
        set => SetArgument("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The login_url attribute.
    /// </summary>
    public TerraformValue<string> LoginUrl
    {
        get => new TerraformReference<string>(this, "login_url");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatadogMonitorSsoConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatadogMonitorSsoConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
