using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsWebTest.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsWebTestTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_application_insights_web_test Terraform resource.
/// Manages a azurerm_application_insights_web_test resource.
/// </summary>
public partial class AzurermApplicationInsightsWebTest(string name) : TerraformResource("azurerm_application_insights_web_test", name)
{
    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => new TerraformReference<string>(this, "application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    public required TerraformValue<string> Configuration
    {
        get => new TerraformReference<string>(this, "configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<double>? Frequency
    {
        get => new TerraformReference<double>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    public TerraformList<string>? GeoLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "geo_locations").ResolveNodes(ctx));
        set => SetArgument("geo_locations", value);
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
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RetryEnabled
    {
        get => new TerraformReference<bool>(this, "retry_enabled");
        set => SetArgument("retry_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    public TerraformValue<string> SyntheticMonitorId
    {
        get => new TerraformReference<string>(this, "synthetic_monitor_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsWebTestTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsWebTestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
