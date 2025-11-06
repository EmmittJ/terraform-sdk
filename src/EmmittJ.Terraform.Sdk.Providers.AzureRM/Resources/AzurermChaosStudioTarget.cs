using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_chaos_studio_target resource.
/// </summary>
public class AzurermChaosStudioTarget : TerraformResource
{
    public AzurermChaosStudioTarget(string name) : base("azurerm_chaos_studio_target", name)
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public string? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type")?.Value;
        set => this.WithProperty("target_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
