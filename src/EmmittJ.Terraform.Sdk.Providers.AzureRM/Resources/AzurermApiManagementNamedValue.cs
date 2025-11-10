using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementNamedValueTimeoutsBlock : TerraformBlock
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
/// Block type for value_from_key_vault in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementNamedValueValueFromKeyVaultBlock : TerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("identity_client_id");
        set => WithProperty("identity_client_id", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetProperty<TerraformProperty<string>>("secret_id");
        set => WithProperty("secret_id", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_named_value resource.
/// </summary>
public class AzurermApiManagementNamedValue : TerraformResource
{
    public AzurermApiManagementNamedValue(string name) : base("azurerm_api_management_named_value", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformProperty<bool>? Secret
    {
        get => GetProperty<TerraformProperty<bool>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        get => GetProperty<List<TerraformProperty<string>>>("tags");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementNamedValueTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementNamedValueTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for value_from_key_vault.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValueFromKeyVault block(s) allowed")]
    public List<AzurermApiManagementNamedValueValueFromKeyVaultBlock>? ValueFromKeyVault
    {
        get => GetProperty<List<AzurermApiManagementNamedValueValueFromKeyVaultBlock>>("value_from_key_vault");
        set => this.WithProperty("value_from_key_vault", value);
    }

}
