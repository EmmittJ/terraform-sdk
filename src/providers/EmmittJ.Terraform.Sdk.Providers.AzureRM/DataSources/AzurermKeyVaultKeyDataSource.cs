using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_key.
/// </summary>
public class AzurermKeyVaultKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultKeyDataSource(string name) : base("azurerm_key_vault_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("curve");
        SetOutput("e");
        SetOutput("key_opts");
        SetOutput("key_size");
        SetOutput("key_type");
        SetOutput("n");
        SetOutput("public_key_openssh");
        SetOutput("public_key_pem");
        SetOutput("resource_id");
        SetOutput("resource_versionless_id");
        SetOutput("tags");
        SetOutput("version");
        SetOutput("versionless_id");
        SetOutput("x");
        SetOutput("y");
        SetOutput("id");
        SetOutput("key_vault_id");
        SetOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultKeyDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformExpression Curve => this["curve"];

    /// <summary>
    /// The e attribute.
    /// </summary>
    public TerraformExpression E => this["e"];

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    public TerraformExpression KeyOpts => this["key_opts"];

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformExpression KeySize => this["key_size"];

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformExpression KeyType => this["key_type"];

    /// <summary>
    /// The n attribute.
    /// </summary>
    public TerraformExpression N => this["n"];

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    public TerraformExpression PublicKeyOpenssh => this["public_key_openssh"];

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformExpression PublicKeyPem => this["public_key_pem"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformExpression ResourceVersionlessId => this["resource_versionless_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformExpression VersionlessId => this["versionless_id"];

    /// <summary>
    /// The x attribute.
    /// </summary>
    public TerraformExpression X => this["x"];

    /// <summary>
    /// The y attribute.
    /// </summary>
    public TerraformExpression Y => this["y"];

}
