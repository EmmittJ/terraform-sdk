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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// Capability name that should be updated on the folder.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityName is required")]
    public required TerraformProperty<string> CapabilityName
    {
        get => GetProperty<TerraformProperty<string>>("capability_name");
        set => this.WithProperty("capability_name", value);
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
    /// Folder on which Capability needs to be updated in the format folders/folder_id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Capability Value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<bool> Value
    {
        get => GetProperty<TerraformProperty<bool>>("value");
        set => this.WithProperty("value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleResourceManagerCapabilityTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleResourceManagerCapabilityTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
