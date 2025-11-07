using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_credential_user_managed_identity resource.
/// </summary>
public class AzurermDataFactoryCredentialUserManagedIdentity : TerraformResource
{
    public AzurermDataFactoryCredentialUserManagedIdentity(string name) : base("azurerm_data_factory_credential_user_managed_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// (Optional) List of string annotations.
    /// </summary>
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The resource ID of the parent Data Factory
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// (Optional) Short text description
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The resource ID of the User Assigned Managed Identity
    /// </summary>
    public TerraformProperty<string>? IdentityId
    {
        get => GetProperty<TerraformProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The desired name of the credential resource
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
