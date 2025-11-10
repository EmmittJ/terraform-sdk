using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for targeting_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTargetingFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The default_rollout_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRolloutPercentage is required")]
    [TerraformPropertyName("default_rollout_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DefaultRolloutPercentage { get; set; }

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformPropertyName("users")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Users { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationFeatureTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for timewindow_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationFeatureTimewindowFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [TerraformPropertyName("end")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [TerraformPropertyName("start")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Start { get; set; }

}

/// <summary>
/// Manages a azurerm_app_configuration_feature resource.
/// </summary>
public class AzurermAppConfigurationFeature : TerraformResource
{
    public AzurermAppConfigurationFeature(string name) : base("azurerm_app_configuration_feature", name)
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    [TerraformPropertyName("configuration_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConfigurationStoreId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Etag { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Key { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key");

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Label { get; set; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformPropertyName("locked")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Locked { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The percentage_filter_value attribute.
    /// </summary>
    [TerraformPropertyName("percentage_filter_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PercentageFilterValue { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for targeting_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("targeting_filter")]
    public TerraformList<TerraformBlock<AzurermAppConfigurationFeatureTargetingFilterBlock>>? TargetingFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppConfigurationFeatureTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for timewindow_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("timewindow_filter")]
    public TerraformList<TerraformBlock<AzurermAppConfigurationFeatureTimewindowFilterBlock>>? TimewindowFilter { get; set; } = new();

}
