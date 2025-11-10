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
        set => SetProperty("default_rollout_percentage", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Users
    {
        set => SetProperty("users", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformProperty<string>? Start
    {
        set => SetProperty("start", value);
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
        SetOutput("configuration_store_id");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("etag");
        SetOutput("id");
        SetOutput("key");
        SetOutput("label");
        SetOutput("locked");
        SetOutput("name");
        SetOutput("percentage_filter_value");
        SetOutput("tags");
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformProperty<string> ConfigurationStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_store_id");
        set => SetProperty("configuration_store_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string> Etag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("etag");
        set => SetProperty("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string> Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key");
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string> Label
    {
        get => GetRequiredOutput<TerraformProperty<string>>("label");
        set => SetProperty("label", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformProperty<bool> Locked
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("locked");
        set => SetProperty("locked", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The percentage_filter_value attribute.
    /// </summary>
    public TerraformProperty<double> PercentageFilterValue
    {
        get => GetRequiredOutput<TerraformProperty<double>>("percentage_filter_value");
        set => SetProperty("percentage_filter_value", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for targeting_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAppConfigurationFeatureTargetingFilterBlock>? TargetingFilter
    {
        set => SetProperty("targeting_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationFeatureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for timewindow_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAppConfigurationFeatureTimewindowFilterBlock>? TimewindowFilter
    {
        set => SetProperty("timewindow_filter", value);
    }

}
