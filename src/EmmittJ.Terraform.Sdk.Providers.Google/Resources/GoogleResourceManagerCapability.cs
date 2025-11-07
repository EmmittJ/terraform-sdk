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
    public TerraformLiteralProperty<string>? CapabilityName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capability_name");
        set => this.WithProperty("capability_name", value);
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
    /// Folder on which Capability needs to be updated in the format folders/folder_id.
    /// </summary>
    public TerraformLiteralProperty<string>? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Capability Value.
    /// </summary>
    public TerraformLiteralProperty<bool>? Value
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("value");
        set => this.WithProperty("value", value);
    }

}
