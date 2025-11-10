using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preserved_state in .
/// Nesting mode: list
/// </summary>
public class GoogleComputePerInstanceConfigPreservedStateBlock : TerraformBlock
{
    /// <summary>
    /// Preserved metadata defined for this instance. This is a list of key-&amp;gt;value pairs.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        set => SetProperty("metadata", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputePerInstanceConfigTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_per_instance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputePerInstanceConfig : TerraformResource
{
    public GoogleComputePerInstanceConfig(string name) : base("google_compute_per_instance_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("instance_group_manager");
        SetOutput("minimal_action");
        SetOutput("most_disruptive_allowed_action");
        SetOutput("name");
        SetOutput("project");
        SetOutput("remove_instance_on_destroy");
        SetOutput("remove_instance_state_on_destroy");
        SetOutput("zone");
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
    /// The instance group manager this instance config is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceGroupManager is required")]
    public required TerraformProperty<string> InstanceGroupManager
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_group_manager");
        set => SetProperty("instance_group_manager", value);
    }

    /// <summary>
    /// The minimal action to perform on the instance during an update.
    /// Default is &#39;NONE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformProperty<string> MinimalAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimal_action");
        set => SetProperty("minimal_action", value);
    }

    /// <summary>
    /// The most disruptive action to perform on the instance during an update.
    /// Default is &#39;REPLACE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformProperty<string> MostDisruptiveAllowedAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("most_disruptive_allowed_action");
        set => SetProperty("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The name for this per-instance config and its corresponding instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove the underlying instance.
    /// When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.
    /// </summary>
    public TerraformProperty<bool> RemoveInstanceOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("remove_instance_on_destroy");
        set => SetProperty("remove_instance_on_destroy", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove any specified state from the underlying instance.
    /// When false, deleting this config will *not* immediately remove any state from the underlying instance.
    /// State will be removed on the next instance recreation or update.
    /// </summary>
    public TerraformProperty<bool> RemoveInstanceStateOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("remove_instance_state_on_destroy");
        set => SetProperty("remove_instance_state_on_destroy", value);
    }

    /// <summary>
    /// Zone where the containing instance group manager is located
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for preserved_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreservedState block(s) allowed")]
    public List<GoogleComputePerInstanceConfigPreservedStateBlock>? PreservedState
    {
        set => SetProperty("preserved_state", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputePerInstanceConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
