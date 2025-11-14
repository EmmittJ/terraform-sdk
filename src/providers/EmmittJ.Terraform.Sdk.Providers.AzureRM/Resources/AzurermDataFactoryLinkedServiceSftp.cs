using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for key_vault_password in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_password";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformArgument("linked_service_name")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformArgument("secret_name")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for key_vault_private_key_content_base64 in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_private_key_content_base64";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformArgument("linked_service_name")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformArgument("secret_name")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for key_vault_private_key_passphrase in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_private_key_passphrase";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformArgument("linked_service_name")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformArgument("secret_name")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceSftpTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformArgument("additional_properties")]
    public TerraformMap<string>? AdditionalProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_properties").ResolveNodes(ctx));
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformArgument("annotations")]
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformArgument("authentication_type")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformArgument("data_factory_id")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformArgument("host")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    [TerraformArgument("host_key_fingerprint")]
    public TerraformValue<string>? HostKeyFingerprint
    {
        get => new TerraformReference<string>(this, "host_key_fingerprint");
        set => SetArgument("host_key_fingerprint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformArgument("integration_runtime_name")]
    public TerraformValue<string>? IntegrationRuntimeName
    {
        get => new TerraformReference<string>(this, "integration_runtime_name");
        set => SetArgument("integration_runtime_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformArgument("port")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The private_key_content_base64 attribute.
    /// </summary>
    [TerraformArgument("private_key_content_base64")]
    public TerraformValue<string>? PrivateKeyContentBase64
    {
        get => new TerraformReference<string>(this, "private_key_content_base64");
        set => SetArgument("private_key_content_base64", value);
    }

    /// <summary>
    /// The private_key_passphrase attribute.
    /// </summary>
    [TerraformArgument("private_key_passphrase")]
    public TerraformValue<string>? PrivateKeyPassphrase
    {
        get => new TerraformReference<string>(this, "private_key_passphrase");
        set => SetArgument("private_key_passphrase", value);
    }

    /// <summary>
    /// The private_key_path attribute.
    /// </summary>
    [TerraformArgument("private_key_path")]
    public TerraformValue<string>? PrivateKeyPath
    {
        get => new TerraformReference<string>(this, "private_key_path");
        set => SetArgument("private_key_path", value);
    }

    /// <summary>
    /// The skip_host_key_validation attribute.
    /// </summary>
    [TerraformArgument("skip_host_key_validation")]
    public TerraformValue<bool>? SkipHostKeyValidation
    {
        get => new TerraformReference<bool>(this, "skip_host_key_validation");
        set => SetArgument("skip_host_key_validation", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformArgument("username")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("key_vault_password")]
    public TerraformList<AzurermDataFactoryLinkedServiceSftpKeyVaultPasswordBlock> KeyVaultPassword { get; set; } = new();

    /// <summary>
    /// Block for key_vault_private_key_content_base64.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyContentBase64 block(s) allowed")]
    [TerraformArgument("key_vault_private_key_content_base64")]
    public TerraformList<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyContentBase64Block> KeyVaultPrivateKeyContentBase64 { get; set; } = new();

    /// <summary>
    /// Block for key_vault_private_key_passphrase.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPrivateKeyPassphrase block(s) allowed")]
    [TerraformArgument("key_vault_private_key_passphrase")]
    public TerraformList<AzurermDataFactoryLinkedServiceSftpKeyVaultPrivateKeyPassphraseBlock> KeyVaultPrivateKeyPassphrase { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryLinkedServiceSftpTimeoutsBlock Timeouts { get; set; } = new();

}
