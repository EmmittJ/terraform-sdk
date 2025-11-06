using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_hyperv_replication_policy_association resource.
/// </summary>
public class AzurermSiteRecoveryHypervReplicationPolicyAssociation : TerraformResource
{
    public AzurermSiteRecoveryHypervReplicationPolicyAssociation(string name) : base("azurerm_site_recovery_hyperv_replication_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hyperv_site_id attribute.
    /// </summary>
    public string? HypervSiteId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyperv_site_id")?.Value;
        set => this.WithProperty("hyperv_site_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_id attribute.
    /// </summary>
    public string? PolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_id")?.Value;
        set => this.WithProperty("policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
