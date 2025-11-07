using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_per_instance_config resource.
/// </summary>
public class GoogleComputePerInstanceConfig : TerraformResource
{
    public GoogleComputePerInstanceConfig(string name) : base("google_compute_per_instance_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The instance group manager this instance config is part of.
    /// </summary>
    public TerraformProperty<string>? InstanceGroupManager
    {
        get => GetProperty<TerraformProperty<string>>("instance_group_manager");
        set => this.WithProperty("instance_group_manager", value);
    }

    /// <summary>
    /// The minimal action to perform on the instance during an update.
    /// Default is &#39;NONE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformProperty<string>? MinimalAction
    {
        get => GetProperty<TerraformProperty<string>>("minimal_action");
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
    public TerraformProperty<string>? MostDisruptiveAllowedAction
    {
        get => GetProperty<TerraformProperty<string>>("most_disruptive_allowed_action");
        set => this.WithProperty("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The name for this per-instance config and its corresponding instance.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove the underlying instance.
    /// When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.
    /// </summary>
    public TerraformProperty<bool>? RemoveInstanceOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("remove_instance_on_destroy");
        set => this.WithProperty("remove_instance_on_destroy", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove any specified state from the underlying instance.
    /// When false, deleting this config will *not* immediately remove any state from the underlying instance.
    /// State will be removed on the next instance recreation or update.
    /// </summary>
    public TerraformProperty<bool>? RemoveInstanceStateOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("remove_instance_state_on_destroy");
        set => this.WithProperty("remove_instance_state_on_destroy", value);
    }

    /// <summary>
    /// Zone where the containing instance group manager is located
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

}
