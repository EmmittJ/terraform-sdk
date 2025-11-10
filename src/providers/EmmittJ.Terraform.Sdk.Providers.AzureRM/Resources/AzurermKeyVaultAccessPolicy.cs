using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_key_vault_access_policy resource.
/// </summary>
public class AzurermKeyVaultAccessPolicy : TerraformResource
{
    public AzurermKeyVaultAccessPolicy(string name) : base("azurerm_key_vault_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_id");
        SetOutput("certificate_permissions");
        SetOutput("id");
        SetOutput("key_permissions");
        SetOutput("key_vault_id");
        SetOutput("object_id");
        SetOutput("secret_permissions");
        SetOutput("storage_permissions");
        SetOutput("tenant_id");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    public List<TerraformProperty<string>> CertificatePermissions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("certificate_permissions");
        set => SetProperty("certificate_permissions", value);
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
    /// The key_permissions attribute.
    /// </summary>
    public List<TerraformProperty<string>> KeyPermissions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("key_permissions");
        set => SetProperty("key_permissions", value);
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
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformProperty<string> ObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_id");
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    public List<TerraformProperty<string>> SecretPermissions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("secret_permissions");
        set => SetProperty("secret_permissions", value);
    }

    /// <summary>
    /// The storage_permissions attribute.
    /// </summary>
    public List<TerraformProperty<string>> StoragePermissions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("storage_permissions");
        set => SetProperty("storage_permissions", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultAccessPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
