using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_share resource.
/// </summary>
public class AzurermStorageShare : TerraformResource
{
    public AzurermStorageShare(string name) : base("azurerm_storage_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_manager_id");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformProperty<string>? AccessTier
    {
        get => GetProperty<TerraformProperty<string>>("access_tier");
        set => this.WithProperty("access_tier", value);
    }

    /// <summary>
    /// The enabled_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? EnabledProtocol
    {
        get => GetProperty<TerraformProperty<string>>("enabled_protocol");
        set => this.WithProperty("enabled_protocol", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The quota attribute.
    /// </summary>
    public TerraformProperty<double>? Quota
    {
        get => GetProperty<TerraformProperty<double>>("quota");
        set => this.WithProperty("quota", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
