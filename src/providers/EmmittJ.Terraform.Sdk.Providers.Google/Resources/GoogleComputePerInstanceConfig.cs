using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preserved_state in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePerInstanceConfigPreservedStateBlock : ITerraformBlock
{
    /// <summary>
    /// Preserved metadata defined for this instance. This is a list of key-&amp;gt;value pairs.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputePerInstanceConfigTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_per_instance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputePerInstanceConfig : TerraformResource
{
    public GoogleComputePerInstanceConfig(string name) : base("google_compute_per_instance_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance group manager this instance config is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceGroupManager is required")]
    [TerraformPropertyName("instance_group_manager")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceGroupManager { get; set; }

    /// <summary>
    /// The minimal action to perform on the instance during an update.
    /// Default is &#39;NONE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    [TerraformPropertyName("minimal_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimalAction { get; set; }

    /// <summary>
    /// The most disruptive action to perform on the instance during an update.
    /// Default is &#39;REPLACE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    [TerraformPropertyName("most_disruptive_allowed_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MostDisruptiveAllowedAction { get; set; }

    /// <summary>
    /// The name for this per-instance config and its corresponding instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// When true, deleting this config will immediately remove the underlying instance.
    /// When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.
    /// </summary>
    [TerraformPropertyName("remove_instance_on_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoveInstanceOnDestroy { get; set; }

    /// <summary>
    /// When true, deleting this config will immediately remove any specified state from the underlying instance.
    /// When false, deleting this config will *not* immediately remove any state from the underlying instance.
    /// State will be removed on the next instance recreation or update.
    /// </summary>
    [TerraformPropertyName("remove_instance_state_on_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoveInstanceStateOnDestroy { get; set; }

    /// <summary>
    /// Zone where the containing instance group manager is located
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for preserved_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreservedState block(s) allowed")]
    [TerraformPropertyName("preserved_state")]
    public TerraformList<TerraformBlock<GoogleComputePerInstanceConfigPreservedStateBlock>>? PreservedState { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputePerInstanceConfigTimeoutsBlock>? Timeouts { get; set; } = new();

}
