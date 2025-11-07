using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<string>? CapabilityName
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
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Capability Value.
    /// </summary>
    public TerraformProperty<bool>? Value
    {
        get => GetProperty<TerraformProperty<bool>>("value");
        set => this.WithProperty("value", value);
    }

}
