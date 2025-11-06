using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cognitive_deployment resource.
/// </summary>
public class AzurermCognitiveDeployment : TerraformResource
{
    public AzurermCognitiveDeployment(string name) : base("azurerm_cognitive_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    public string? CognitiveAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cognitive_account_id")?.Value;
        set => this.WithProperty("cognitive_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public bool? DynamicThrottlingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dynamic_throttling_enabled")?.Value;
        set => this.WithProperty("dynamic_throttling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rai_policy_name attribute.
    /// </summary>
    public string? RaiPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rai_policy_name")?.Value;
        set => this.WithProperty("rai_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_upgrade_option attribute.
    /// </summary>
    public string? VersionUpgradeOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_upgrade_option")?.Value;
        set => this.WithProperty("version_upgrade_option", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
