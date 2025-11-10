using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for datadog_organization in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorDatadogOrganizationBlock : TerraformBlock
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformProperty<string> ApiKey
    {
        get => GetProperty<TerraformProperty<string>>("api_key");
        set => WithProperty("api_key", value);
    }

    /// <summary>
    /// The application_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationKey is required")]
    public required TerraformProperty<string> ApplicationKey
    {
        get => GetProperty<TerraformProperty<string>>("application_key");
        set => WithProperty("application_key", value);
    }

    /// <summary>
    /// The enterprise_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? EnterpriseAppId
    {
        get => GetProperty<TerraformProperty<string>>("enterprise_app_id");
        set => WithProperty("enterprise_app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The linking_auth_code attribute.
    /// </summary>
    public TerraformProperty<string>? LinkingAuthCode
    {
        get => GetProperty<TerraformProperty<string>>("linking_auth_code");
        set => WithProperty("linking_auth_code", value);
    }

    /// <summary>
    /// The linking_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? LinkingClientId
    {
        get => GetProperty<TerraformProperty<string>>("linking_client_id");
        set => WithProperty("linking_client_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectUri
    {
        get => GetProperty<TerraformProperty<string>>("redirect_uri");
        set => WithProperty("redirect_uri", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatadogMonitorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorUserBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

}

/// <summary>
/// Manages a azurerm_datadog_monitor resource.
/// </summary>
public class AzurermDatadogMonitor : TerraformResource
{
    public AzurermDatadogMonitor(string name) : base("azurerm_datadog_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("marketplace_subscription_status");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring_enabled");
        set => this.WithProperty("monitoring_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for datadog_organization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatadogOrganization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatadogOrganization block(s) allowed")]
    public List<AzurermDatadogMonitorDatadogOrganizationBlock>? DatadogOrganization
    {
        get => GetProperty<List<AzurermDatadogMonitorDatadogOrganizationBlock>>("datadog_organization");
        set => this.WithProperty("datadog_organization", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermDatadogMonitorIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermDatadogMonitorIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatadogMonitorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDatadogMonitorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    public List<AzurermDatadogMonitorUserBlock>? User
    {
        get => GetProperty<List<AzurermDatadogMonitorUserBlock>>("user");
        set => this.WithProperty("user", value);
    }

    /// <summary>
    /// The marketplace_subscription_status attribute.
    /// </summary>
    public TerraformExpression MarketplaceSubscriptionStatus => this["marketplace_subscription_status"];

}
