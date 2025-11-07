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
    public TerraformProperty<string>? CognitiveAccountId
    {
        get => GetProperty<TerraformProperty<string>>("cognitive_account_id");
        set => this.WithProperty("cognitive_account_id", value);
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicThrottlingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_throttling_enabled");
        set => this.WithProperty("dynamic_throttling_enabled", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rai_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? RaiPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("rai_policy_name");
        set => this.WithProperty("rai_policy_name", value);
    }

    /// <summary>
    /// The version_upgrade_option attribute.
    /// </summary>
    public TerraformProperty<string>? VersionUpgradeOption
    {
        get => GetProperty<TerraformProperty<string>>("version_upgrade_option");
        set => this.WithProperty("version_upgrade_option", value);
    }

}
