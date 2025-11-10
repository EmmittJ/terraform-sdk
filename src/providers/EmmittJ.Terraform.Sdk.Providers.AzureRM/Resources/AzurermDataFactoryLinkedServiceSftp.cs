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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        set => SetProperty("secret_name", value);
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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        set => SetProperty("secret_name", value);
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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        set => SetProperty("secret_name", value);
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
/// Manages a azurerm_data_factory_linked_service_sftp resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryLinkedServiceSftp : TerraformResource
{
    public AzurermDataFactoryLinkedServiceSftp(string name) : base("azurerm_data_factory_linked_service_sftp", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("authentication_type");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("host");
        SetOutput("host_key_fingerprint");
        SetOutput("id");
        SetOutput("integration_runtime_name");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("password");
        SetOutput("port");
        SetOutput("private_key_content_base64");
        SetOutput("private_key_passphrase");
        SetOutput("private_key_path");
        SetOutput("skip_host_key_validation");
        SetOutput("username");
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host");
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformProperty<string> HostKeyFingerprint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_key_fingerprint");
        set => SetProperty("host_key_fingerprint", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationRuntimeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_runtime_name");
        set => SetProperty("integration_runtime_name", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The private_key_content_base64 attribute.
    /// </summary>
    public TerraformProperty<string> PrivateKeyContentBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_key_content_base64");
        set => SetProperty("private_key_content_base64", value);
    }

    /// <summary>
    /// The private_key_passphrase attribute.
    /// </summary>
    public TerraformProperty<string> PrivateKeyPassphrase
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_key_passphrase");
        set => SetProperty("private_key_passphrase", value);
    }

    /// <summary>
    /// The private_key_path attribute.
    /// </summary>
    public TerraformProperty<string> PrivateKeyPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_key_path");
        set => SetProperty("private_key_path", value);
    }

    /// <summary>
    /// The skip_host_key_validation attribute.
    /// </summary>
    public TerraformProperty<bool> SkipHostKeyValidation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_host_key_validation");
        set => SetProperty("skip_host_key_validation", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock>? KeyVaultPassword
    {
        set => SetProperty("key_vault_password", value);
    }

    /// <summary>
    /// Block for key_vault_private_key_content_base64.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyContentBase64 block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block>? KeyVaultPrivateKeyContentBase64
    {
        set => SetProperty("key_vault_private_key_content_base64", value);
    }

    /// <summary>
    /// Block for key_vault_private_key_passphrase.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyPassphrase block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock>? KeyVaultPrivateKeyPassphrase
    {
        set => SetProperty("key_vault_private_key_passphrase", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceSftpTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
