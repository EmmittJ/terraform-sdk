using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_federated_identity_credential resource.
/// </summary>
public class AzurermFederatedIdentityCredential : TerraformResource
{
    public AzurermFederatedIdentityCredential(string name) : base("azurerm_federated_identity_credential", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The audience attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Audience
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("audience");
        set => this.WithProperty("audience", value);
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
    /// The issuer attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Issuer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("issuer");
        set => this.WithProperty("issuer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Subject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subject");
        set => this.WithProperty("subject", value);
    }

}
