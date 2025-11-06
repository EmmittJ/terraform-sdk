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
    public string? CapabilityName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capability_name")?.Value;
        set => this.WithProperty("capability_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Folder on which Capability needs to be updated in the format folders/folder_id.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Capability Value.
    /// </summary>
    public bool? Value
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
