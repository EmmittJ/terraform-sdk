using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for key_vault_password in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

}

/// <summary>
/// Block type for key_vault_private_key_content_base64 in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

}

/// <summary>
/// Block type for key_vault_private_key_passphrase in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_linked_service_sftp resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceSftp : TerraformResource
{
    public AzurermDataFactoryLinkedServiceSftp(string name) : base("azurerm_data_factory_linked_service_sftp", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => this.WithProperty("host", value);
    }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformProperty<string>? HostKeyFingerprint
    {
        get => GetProperty<TerraformProperty<string>>("host_key_fingerprint");
        set => this.WithProperty("host_key_fingerprint", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationRuntimeName
    {
        get => GetProperty<TerraformProperty<string>>("integration_runtime_name");
        set => this.WithProperty("integration_runtime_name", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The private_key_content_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKeyContentBase64
    {
        get => GetProperty<TerraformProperty<string>>("private_key_content_base64");
        set => this.WithProperty("private_key_content_base64", value);
    }

    /// <summary>
    /// The private_key_passphrase attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKeyPassphrase
    {
        get => GetProperty<TerraformProperty<string>>("private_key_passphrase");
        set => this.WithProperty("private_key_passphrase", value);
    }

    /// <summary>
    /// The private_key_path attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKeyPath
    {
        get => GetProperty<TerraformProperty<string>>("private_key_path");
        set => this.WithProperty("private_key_path", value);
    }

    /// <summary>
    /// The skip_host_key_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipHostKeyValidation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_host_key_validation");
        set => this.WithProperty("skip_host_key_validation", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock>? KeyVaultPassword
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock>>("key_vault_password");
        set => this.WithProperty("key_vault_password", value);
    }

    /// <summary>
    /// Block for key_vault_private_key_content_base64.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyContentBase64 block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block>? KeyVaultPrivateKeyContentBase64
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block>>("key_vault_private_key_content_base64");
        set => this.WithProperty("key_vault_private_key_content_base64", value);
    }

    /// <summary>
    /// Block for key_vault_private_key_passphrase.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyPassphrase block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock>? KeyVaultPrivateKeyPassphrase
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock>>("key_vault_private_key_passphrase");
        set => this.WithProperty("key_vault_private_key_passphrase", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceSftpTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryLinkedServiceSftpTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
