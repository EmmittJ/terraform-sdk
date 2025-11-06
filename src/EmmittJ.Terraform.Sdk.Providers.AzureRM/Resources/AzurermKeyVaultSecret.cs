using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_secret resource.
/// </summary>
public class AzurermKeyVaultSecret : TerraformResource
{
    public AzurermKeyVaultSecret(string name) : base("azurerm_key_vault_secret", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_id");
        this.DeclareOutput("resource_versionless_id");
        this.DeclareOutput("version");
        this.DeclareOutput("versionless_id");
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
    /// The expiration_date attribute.
    /// </summary>
    public string? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date")?.Value;
        set => this.WithProperty("expiration_date", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_vault_id attribute.
    /// </summary>
    public string? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id")?.Value;
        set => this.WithProperty("key_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The not_before_date attribute.
    /// </summary>
    public string? NotBeforeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("not_before_date")?.Value;
        set => this.WithProperty("not_before_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public string? ValueWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value_wo")?.Value;
        set => this.WithProperty("value_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public double? ValueWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("value_wo_version")?.Value;
        set => this.WithProperty("value_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformExpression ResourceVersionlessId => this["resource_versionless_id"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformExpression VersionlessId => this["versionless_id"];

}
