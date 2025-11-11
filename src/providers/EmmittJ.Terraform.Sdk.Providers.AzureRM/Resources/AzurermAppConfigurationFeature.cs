using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for targeting_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppConfigurationFeatureTargetingFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_rollout_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRolloutPercentage is required")]
    [TerraformProperty("default_rollout_percentage")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DefaultRolloutPercentage { get; set; }

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformProperty("users")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Users { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppConfigurationFeatureTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for timewindow_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppConfigurationFeatureTimewindowFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [TerraformProperty("end")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [TerraformProperty("start")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Start { get; set; }

}

/// <summary>
/// Manages a azurerm_app_configuration_feature resource.
/// </summary>
public partial class AzurermAppConfigurationFeature : TerraformResource
{
    public AzurermAppConfigurationFeature(string name) : base("azurerm_app_configuration_feature", name)
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    [TerraformProperty("configuration_store_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigurationStoreId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformProperty("locked")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Locked { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The percentage_filter_value attribute.
    /// </summary>
    [TerraformProperty("percentage_filter_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PercentageFilterValue { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for targeting_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("targeting_filter")]
    public partial TerraformList<TerraformBlock<AzurermAppConfigurationFeatureTargetingFilterBlock>>? TargetingFilter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermAppConfigurationFeatureTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for timewindow_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("timewindow_filter")]
    public partial TerraformList<TerraformBlock<AzurermAppConfigurationFeatureTimewindowFilterBlock>>? TimewindowFilter { get; set; }

}
