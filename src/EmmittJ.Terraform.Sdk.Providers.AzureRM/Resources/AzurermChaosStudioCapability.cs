using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_chaos_studio_capability resource.
/// </summary>
public class AzurermChaosStudioCapability : TerraformResource
{
    public AzurermChaosStudioCapability(string name) : base("azurerm_chaos_studio_capability", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("urn");
    }

    /// <summary>
    /// The capability_type attribute.
    /// </summary>
    public string? CapabilityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capability_type")?.Value;
        set => this.WithProperty("capability_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    public string? ChaosStudioTargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("chaos_studio_target_id")?.Value;
        set => this.WithProperty("chaos_studio_target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The urn attribute.
    /// </summary>
    public TerraformExpression Urn => this["urn"];

}
