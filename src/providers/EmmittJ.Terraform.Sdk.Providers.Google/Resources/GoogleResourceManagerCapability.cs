using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleResourceManagerCapabilityTimeoutsBlock : TerraformBlock
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
/// Manages a google_resource_manager_capability resource.
/// </summary>
public class GoogleResourceManagerCapability : TerraformResource
{
    public GoogleResourceManagerCapability(string name) : base("google_resource_manager_capability", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("capability_name");
        SetOutput("id");
        SetOutput("parent");
        SetOutput("value");
    }

    /// <summary>
    /// Capability name that should be updated on the folder.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityName is required")]
    public required TerraformProperty<string> CapabilityName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capability_name");
        set => SetProperty("capability_name", value);
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
    /// Folder on which Capability needs to be updated in the format folders/folder_id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Capability Value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<bool> Value
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("value");
        set => SetProperty("value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleResourceManagerCapabilityTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
