using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for key_vault_connection_string in AzurermDataFactoryLinkedServiceSqlServer.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSqlServerKeyVaultConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_connection_string";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => GetArgument<TerraformValue<string>>("linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}


/// <summary>
/// Block type for key_vault_password in AzurermDataFactoryLinkedServiceSqlServer.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceSqlServerKeyVaultPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_password";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => GetArgument<TerraformValue<string>>("linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryLinkedServiceSqlServer.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceSqlServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_linked_service_sql_server Terraform resource.
/// Manages a azurerm_data_factory_linked_service_sql_server resource.
/// </summary>
public partial class AzurermDataFactoryLinkedServiceSqlServer(string name) : TerraformResource("azurerm_data_factory_linked_service_sql_server", name)
{
    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => GetArgument<TerraformMap<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionString
    {
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationRuntimeName
    {
        get => GetArgument<TerraformValue<string>>("integration_runtime_name");
        set => SetArgument("integration_runtime_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string>? UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// KeyVaultConnectionString block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultConnectionString block(s) allowed")]
    public TerraformList<AzurermDataFactoryLinkedServiceSqlServerKeyVaultConnectionStringBlock>? KeyVaultConnectionString
    {
        get => GetArgument<TerraformList<AzurermDataFactoryLinkedServiceSqlServerKeyVaultConnectionStringBlock>>("key_vault_connection_string");
        set => SetArgument("key_vault_connection_string", value);
    }

    /// <summary>
    /// KeyVaultPassword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    public TerraformList<AzurermDataFactoryLinkedServiceSqlServerKeyVaultPasswordBlock>? KeyVaultPassword
    {
        get => GetArgument<TerraformList<AzurermDataFactoryLinkedServiceSqlServerKeyVaultPasswordBlock>>("key_vault_password");
        set => SetArgument("key_vault_password", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryLinkedServiceSqlServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryLinkedServiceSqlServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
