using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_maintenance_configuration resource.
/// </summary>
public class AzurermMaintenanceConfiguration : TerraformResource
{
    public AzurermMaintenanceConfiguration(string name) : base("azurerm_maintenance_configuration", name)
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
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    public string? InGuestUserPatchMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("in_guest_user_patch_mode")?.Value;
        set => this.WithProperty("in_guest_user_patch_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, string>? Properties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("properties")?.Value;
        set => this.WithProperty("properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public string? Visibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("visibility")?.Value;
        set => this.WithProperty("visibility", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
