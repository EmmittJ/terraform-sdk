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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance group manager this instance config is part of.
    /// </summary>
    public string? InstanceGroupManager
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_group_manager")?.Value;
        set => this.WithProperty("instance_group_manager", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimal action to perform on the instance during an update.
    /// Default is &#39;NONE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public string? MinimalAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimal_action")?.Value;
        set => this.WithProperty("minimal_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The most disruptive action to perform on the instance during an update.
    /// Default is &#39;REPLACE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public string? MostDisruptiveAllowedAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("most_disruptive_allowed_action")?.Value;
        set => this.WithProperty("most_disruptive_allowed_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name for this per-instance config and its corresponding instance.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// When true, deleting this config will immediately remove the underlying instance.
    /// When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.
    /// </summary>
    public bool? RemoveInstanceOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remove_instance_on_destroy")?.Value;
        set => this.WithProperty("remove_instance_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// When true, deleting this config will immediately remove any specified state from the underlying instance.
    /// When false, deleting this config will *not* immediately remove any state from the underlying instance.
    /// State will be removed on the next instance recreation or update.
    /// </summary>
    public bool? RemoveInstanceStateOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remove_instance_state_on_destroy")?.Value;
        set => this.WithProperty("remove_instance_state_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Zone where the containing instance group manager is located
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
