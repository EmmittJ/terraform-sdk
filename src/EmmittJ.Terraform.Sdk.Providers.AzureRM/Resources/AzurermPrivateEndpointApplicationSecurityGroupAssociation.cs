using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_endpoint_application_security_group_association resource.
/// </summary>
public class AzurermPrivateEndpointApplicationSecurityGroupAssociation : TerraformResource
{
    public AzurermPrivateEndpointApplicationSecurityGroupAssociation(string name) : base("azurerm_private_endpoint_application_security_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("application_security_group_id");
        set => this.WithProperty("application_security_group_id", value);
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
    /// The private_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint_id");
        set => this.WithProperty("private_endpoint_id", value);
    }

}
