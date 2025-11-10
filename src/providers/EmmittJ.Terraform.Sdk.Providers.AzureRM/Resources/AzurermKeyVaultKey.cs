using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rotation_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultKeyRotationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    public TerraformProperty<string>? ExpireAfter
    {
        set => SetProperty("expire_after", value);
    }

    /// <summary>
    /// The notify_before_expiry attribute.
    /// </summary>
    public TerraformProperty<string>? NotifyBeforeExpiry
    {
        set => SetProperty("notify_before_expiry", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_key_vault_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKeyVaultKey : TerraformResource
{
    public AzurermKeyVaultKey(string name) : base("azurerm_key_vault_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("e");
        SetOutput("n");
        SetOutput("public_key_openssh");
        SetOutput("public_key_pem");
        SetOutput("resource_id");
        SetOutput("resource_versionless_id");
        SetOutput("version");
        SetOutput("versionless_id");
        SetOutput("x");
        SetOutput("y");
        SetOutput("curve");
        SetOutput("expiration_date");
        SetOutput("id");
        SetOutput("key_opts");
        SetOutput("key_size");
        SetOutput("key_type");
        SetOutput("key_vault_id");
        SetOutput("name");
        SetOutput("not_before_date");
        SetOutput("tags");
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformProperty<string> Curve
    {
        get => GetRequiredOutput<TerraformProperty<string>>("curve");
        set => SetProperty("curve", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string> ExpirationDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_date");
        set => SetProperty("expiration_date", value);
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
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    public List<TerraformProperty<string>> KeyOpts
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("key_opts");
        set => SetProperty("key_opts", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformProperty<double> KeySize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("key_size");
        set => SetProperty("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformProperty<string> KeyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_type");
        set => SetProperty("key_type", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformProperty<string> NotBeforeDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("not_before_date");
        set => SetProperty("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for rotation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationPolicy block(s) allowed")]
    public List<AzurermKeyVaultKeyRotationPolicyBlock>? RotationPolicy
    {
        set => SetProperty("rotation_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The e attribute.
    /// </summary>
    public TerraformExpression E => this["e"];

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
