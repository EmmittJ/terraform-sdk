using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultSecretTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    public TerraformProperty<string>? NotBeforeDate
    {
        get => GetProperty<TerraformProperty<string>>("not_before_date");
        set => this.WithProperty("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformProperty<string>? ValueWo
    {
        get => GetProperty<TerraformProperty<string>>("value_wo");
        set => this.WithProperty("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? ValueWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("value_wo_version");
        set => this.WithProperty("value_wo_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultSecretTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultSecretTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
