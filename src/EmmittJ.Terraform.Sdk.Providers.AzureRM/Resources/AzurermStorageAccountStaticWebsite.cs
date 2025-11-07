using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_account_static_website resource.
/// </summary>
public class AzurermStorageAccountStaticWebsite : TerraformResource
{
    public AzurermStorageAccountStaticWebsite(string name) : base("azurerm_storage_account_static_website", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Error404Document
    {
        get => GetProperty<TerraformLiteralProperty<string>>("error_404_document");
        set => this.WithProperty("error_404_document", value);
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
    /// The index_document attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IndexDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("index_document");
        set => this.WithProperty("index_document", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

}
