using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_storage_account_blob_container_sas.
/// </summary>
public class AzurermStorageAccountBlobContainerSasDataSource : TerraformDataSource
{
    public AzurermStorageAccountBlobContainerSasDataSource(string name) : base("azurerm_storage_account_blob_container_sas", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sas");
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public string? CacheControl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_control")?.Value;
        set => this.WithProperty("cache_control", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The container_name attribute.
    /// </summary>
    public string? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name")?.Value;
        set => this.WithProperty("container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public string? ContentDisposition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_disposition")?.Value;
        set => this.WithProperty("content_disposition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public string? ContentEncoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_encoding")?.Value;
        set => this.WithProperty("content_encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public string? ContentLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_language")?.Value;
        set => this.WithProperty("content_language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public string? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type")?.Value;
        set => this.WithProperty("content_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_address attribute.
    /// </summary>
    public string? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address")?.Value;
        set => this.WithProperty("ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
