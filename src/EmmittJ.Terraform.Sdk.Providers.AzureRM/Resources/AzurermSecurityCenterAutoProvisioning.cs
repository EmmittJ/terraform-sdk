using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_security_center_auto_provisioning resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermSecurityCenterAutoProvisioning : TerraformResource
{
    public AzurermSecurityCenterAutoProvisioning(string name) : base("azurerm_security_center_auto_provisioning", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_provision attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutoProvision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_provision");
        set => this.WithProperty("auto_provision", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
