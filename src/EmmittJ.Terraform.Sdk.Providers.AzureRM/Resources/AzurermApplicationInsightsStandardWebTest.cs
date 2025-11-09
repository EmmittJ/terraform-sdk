using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_insights_standard_web_test resource.
/// </summary>
public class AzurermApplicationInsightsStandardWebTest : TerraformResource
{
    public AzurermApplicationInsightsStandardWebTest(string name) : base("azurerm_application_insights_standard_web_test", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("synthetic_monitor_id");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationInsightsId
    {
        get => GetProperty<TerraformProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
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
    public TerraformProperty<List<string>>? GeoLocations
    {
        get => GetProperty<TerraformProperty<List<string>>>("geo_locations");
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
    /// The synthetic_monitor_id attribute.
    /// </summary>
    public TerraformExpression SyntheticMonitorId => this["synthetic_monitor_id"];

}
