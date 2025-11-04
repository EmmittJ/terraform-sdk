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
    public string? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string")?.Value;
        set => this.WithProperty("connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public string? Expiry
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiry")?.Value;
        set => this.WithProperty("expiry", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The ip_addresses attribute.
    /// </summary>
    public string? IpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_addresses")?.Value;
        set => this.WithProperty("ip_addresses", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    public string? SignedVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signed_version")?.Value;
        set => this.WithProperty("signed_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public string? Start
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start")?.Value;
        set => this.WithProperty("start", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformExpression Sas => this["sas"];

}
