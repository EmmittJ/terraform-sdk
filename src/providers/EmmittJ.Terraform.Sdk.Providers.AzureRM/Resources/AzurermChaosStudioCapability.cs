using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermChaosStudioCapabilityTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("urn");
        SetOutput("capability_type");
        SetOutput("chaos_studio_target_id");
        SetOutput("id");
    }

    /// <summary>
    /// The capability_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityType is required")]
    public required TerraformProperty<string> CapabilityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capability_type");
        set => SetProperty("capability_type", value);
    }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetId is required")]
    public required TerraformProperty<string> ChaosStudioTargetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("chaos_studio_target_id");
        set => SetProperty("chaos_studio_target_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermChaosStudioCapabilityTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The urn attribute.
    /// </summary>
    public TerraformExpression Urn => this["urn"];

}
