using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_batch_account resource.
/// </summary>
public class AzurermBatchAccount : TerraformResource
{
    public AzurermBatchAccount(string name) : base("azurerm_batch_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_endpoint");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
    }

    /// <summary>
    /// The allowed_authentication_modes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AllowedAuthenticationModes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("allowed_authentication_modes");
        set => this.WithProperty("allowed_authentication_modes", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformProperty<List<object>>? Encryption
    {
        get => GetProperty<TerraformProperty<List<object>>>("encryption");
        set => this.WithProperty("encryption", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The pool_allocation_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PoolAllocationMode
    {
        get => GetProperty<TerraformProperty<string>>("pool_allocation_mode");
        set => this.WithProperty("pool_allocation_mode", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_authentication_mode");
        set => this.WithProperty("storage_account_authentication_mode", value);
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
    /// The storage_account_node_identity attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountNodeIdentity
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_node_identity");
        set => this.WithProperty("storage_account_node_identity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    public TerraformExpression AccountEndpoint => this["account_endpoint"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}
