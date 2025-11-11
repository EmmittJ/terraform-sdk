using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for key_vault_password in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock : TerraformBlockBase
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretName { get; set; }

}

/// <summary>
/// Block type for key_vault_private_key_content_base64 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block : TerraformBlockBase
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretName { get; set; }

}

/// <summary>
/// Block type for key_vault_private_key_passphrase in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock : TerraformBlockBase
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryLinkedServiceSftpTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_linked_service_sftp resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryLinkedServiceSftp : TerraformResource
{
    public AzurermDataFactoryLinkedServiceSftp(string name) : base("azurerm_data_factory_linked_service_sftp", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformProperty("host")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Host { get; set; }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    [TerraformProperty("host_key_fingerprint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostKeyFingerprint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformProperty("integration_runtime_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IntegrationRuntimeName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The private_key_content_base64 attribute.
    /// </summary>
    [TerraformProperty("private_key_content_base64")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateKeyContentBase64 { get; set; }

    /// <summary>
    /// The private_key_passphrase attribute.
    /// </summary>
    [TerraformProperty("private_key_passphrase")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateKeyPassphrase { get; set; }

    /// <summary>
    /// The private_key_path attribute.
    /// </summary>
    [TerraformProperty("private_key_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateKeyPath { get; set; }

    /// <summary>
    /// The skip_host_key_validation attribute.
    /// </summary>
    [TerraformProperty("skip_host_key_validation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipHostKeyValidation { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("key_vault_password")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock>>? KeyVaultPassword { get; set; }

    /// <summary>
    /// Block for key_vault_private_key_content_base64.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyContentBase64 block(s) allowed")]
    [TerraformProperty("key_vault_private_key_content_base64")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block>>? KeyVaultPrivateKeyContentBase64 { get; set; }

    /// <summary>
    /// Block for key_vault_private_key_passphrase.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyPassphrase block(s) allowed")]
    [TerraformProperty("key_vault_private_key_passphrase")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock>>? KeyVaultPrivateKeyPassphrase { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataFactoryLinkedServiceSftpTimeoutsBlock>? Timeouts { get; set; }

}
