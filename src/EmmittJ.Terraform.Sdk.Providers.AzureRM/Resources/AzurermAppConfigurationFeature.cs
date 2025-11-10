using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for targeting_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTargetingFilterBlock : TerraformBlock
{
    /// <summary>
    /// The default_rollout_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRolloutPercentage is required")]
    public required TerraformProperty<double> DefaultRolloutPercentage
    {
        get => GetProperty<TerraformProperty<double>>("default_rollout_percentage");
        set => WithProperty("default_rollout_percentage", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Users
    {
        get => GetProperty<List<TerraformProperty<string>>>("users");
        set => WithProperty("users", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationFeatureTimeoutsBlock : TerraformBlock
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
/// Block type for timewindow_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTimewindowFilterBlock : TerraformBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformProperty<string>? End
    {
        get => GetProperty<TerraformProperty<string>>("end");
        set => WithProperty("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformProperty<string>? Start
    {
        get => GetProperty<TerraformProperty<string>>("start");
        set => WithProperty("start", value);
    }

}

/// <summary>
/// Manages a azurerm_app_configuration_feature resource.
/// </summary>
public class AzurermAppConfigurationFeature : TerraformResource
{
    public AzurermAppConfigurationFeature(string name) : base("azurerm_app_configuration_feature", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformProperty<string> ConfigurationStoreId
    {
        get => GetProperty<TerraformProperty<string>>("configuration_store_id");
        set => this.WithProperty("configuration_store_id", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
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
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        get => GetProperty<TerraformProperty<string>>("label");
        set => this.WithProperty("label", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformProperty<bool>? Locked
    {
        get => GetProperty<TerraformProperty<bool>>("locked");
        set => this.WithProperty("locked", value);
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
    /// The percentage_filter_value attribute.
    /// </summary>
    public TerraformProperty<double>? PercentageFilterValue
    {
        get => GetProperty<TerraformProperty<double>>("percentage_filter_value");
        set => this.WithProperty("percentage_filter_value", value);
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
    /// Block for targeting_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAppConfigurationFeatureTargetingFilterBlock>? TargetingFilter
    {
        get => GetProperty<List<AzurermAppConfigurationFeatureTargetingFilterBlock>>("targeting_filter");
        set => this.WithProperty("targeting_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationFeatureTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppConfigurationFeatureTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for timewindow_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAppConfigurationFeatureTimewindowFilterBlock>? TimewindowFilter
    {
        get => GetProperty<List<AzurermAppConfigurationFeatureTimewindowFilterBlock>>("timewindow_filter");
        set => this.WithProperty("timewindow_filter", value);
    }

}
