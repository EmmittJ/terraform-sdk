using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsWebTestTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_application_insights_web_test resource.
/// </summary>
public class AzurermApplicationInsightsWebTest : TerraformResource
{
    public AzurermApplicationInsightsWebTest(string name) : base("azurerm_application_insights_web_test", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputynthetic_monitor_id");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    public required TerraformProperty<string> Configuration
    {
        get => GetRequiredProperty<TerraformProperty<string>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<double>? Frequency
    {
        get => GetProperty<TerraformProperty<double>>("frequency");
        set => this.WithProperty("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    public List<TerraformProperty<string>>? GeoLocations
    {
        get => GetProperty<List<TerraformProperty<string>>>("geo_locations");
        set => this.WithProperty("geo_locations", value);
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
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RetryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("retry_enabled");
        set => this.WithProperty("retry_enabled", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsWebTestTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApplicationInsightsWebTestTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    public TerraformExpression SyntheticMonitorId => this["synthetic_monitor_id"];

}
