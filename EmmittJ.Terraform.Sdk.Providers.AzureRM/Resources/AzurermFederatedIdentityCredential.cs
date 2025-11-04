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
    public List<string>? Audience
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("audience")?.Value;
        set => this.WithProperty("audience", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The issuer attribute.
    /// </summary>
    public string? Issuer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("issuer")?.Value;
        set => this.WithProperty("issuer", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parent_id attribute.
    /// </summary>
    public string? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id")?.Value;
        set => this.WithProperty("parent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public string? Subject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subject")?.Value;
        set => this.WithProperty("subject", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
