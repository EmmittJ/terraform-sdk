using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_per_instance_config resource.
/// </summary>
public class GoogleComputeRegionPerInstanceConfig : TerraformResource
{
    public GoogleComputeRegionPerInstanceConfig(string name) : base("google_compute_region_per_instance_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The minimal action to perform on the instance during an update.
    /// Default is &#39;NONE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformLiteralProperty<string>? MinimalAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimal_action");
        set => this.WithProperty("minimal_action", value);
    }

    /// <summary>
    /// The most disruptive action to perform on the instance during an update.
    /// Default is &#39;REPLACE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformLiteralProperty<string>? MostDisruptiveAllowedAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("most_disruptive_allowed_action");
        set => this.WithProperty("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The name for this per-instance config and its corresponding instance.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where the containing instance group manager is located
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The region instance group manager this instance config is part of.
    /// </summary>
    public TerraformLiteralProperty<string>? RegionInstanceGroupManager
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region_instance_group_manager");
        set => this.WithProperty("region_instance_group_manager", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove the underlying instance.
    /// When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.
    /// </summary>
    public TerraformLiteralProperty<bool>? RemoveInstanceOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remove_instance_on_destroy");
        set => this.WithProperty("remove_instance_on_destroy", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove any specified state from the underlying instance.
    /// When false, deleting this config will *not* immediately remove any state from the underlying instance.
    /// State will be removed on the next instance recreation or update.
    /// </summary>
    public TerraformLiteralProperty<bool>? RemoveInstanceStateOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remove_instance_state_on_destroy");
        set => this.WithProperty("remove_instance_state_on_destroy", value);
    }

}
