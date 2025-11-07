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
    public TerraformLiteralProperty<string>? CapabilityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capability_type");
        set => this.WithProperty("capability_type", value);
    }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ChaosStudioTargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("chaos_studio_target_id");
        set => this.WithProperty("chaos_studio_target_id", value);
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
    /// The urn attribute.
    /// </summary>
    public TerraformExpression Urn => this["urn"];

}
