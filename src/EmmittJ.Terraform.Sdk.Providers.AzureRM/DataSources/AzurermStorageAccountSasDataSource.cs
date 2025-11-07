using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_storage_account_sas.
/// </summary>
public class AzurermStorageAccountSasDataSource : TerraformDataSource
{
    public AzurermStorageAccountSasDataSource(string name) : base("azurerm_storage_account_sas", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sas");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        get => GetProperty<TerraformProperty<string>>("expiry");
        set => this.WithProperty("expiry", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
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
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddresses
    {
        get => GetProperty<TerraformProperty<string>>("ip_addresses");
        set => this.WithProperty("ip_addresses", value);
    }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    public TerraformProperty<string>? SignedVersion
    {
        get => GetProperty<TerraformProperty<string>>("signed_version");
        set => this.WithProperty("signed_version", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformProperty<string>? Start
    {
        get => GetProperty<TerraformProperty<string>>("start");
        set => this.WithProperty("start", value);
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformExpression Sas => this["sas"];

}
