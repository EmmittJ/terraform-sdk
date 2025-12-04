using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for permissions in AzurermStorageAccountBlobContainerSasDataSource.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobContainerSasDataSourcePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// The add attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddAttribute is required")]
    public required TerraformValue<bool> AddAttribute
    {
        get => GetArgument<TerraformValue<bool>>("add");
        set => SetArgument("add", value);
    }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    public required TerraformValue<bool> Create
    {
        get => GetArgument<TerraformValue<bool>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformValue<bool> Delete
    {
        get => GetArgument<TerraformValue<bool>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    public required TerraformValue<bool> List
    {
        get => GetArgument<TerraformValue<bool>>("list");
        set => SetArgument("list", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformValue<bool> Read
    {
        get => GetArgument<TerraformValue<bool>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformValue<bool> Write
    {
        get => GetArgument<TerraformValue<bool>>("write");
        set => SetArgument("write", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageAccountBlobContainerSasDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountBlobContainerSasDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_storage_account_blob_container_sas Terraform data source.
/// Retrieves information about a azurerm_storage_account_blob_container_sas.
/// </summary>
public partial class AzurermStorageAccountBlobContainerSasDataSource(string name) : TerraformDataSource("azurerm_storage_account_blob_container_sas", name)
{
    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformValue<string>? CacheControl
    {
        get => GetArgument<TerraformValue<string>>("cache_control");
        set => SetArgument("cache_control", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformValue<string>? ContentDisposition
    {
        get => GetArgument<TerraformValue<string>>("content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformValue<string>? ContentEncoding
    {
        get => GetArgument<TerraformValue<string>>("content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformValue<string>? ContentLanguage
    {
        get => GetArgument<TerraformValue<string>>("content_language");
        set => SetArgument("content_language", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformValue<string> Expiry
    {
        get => GetArgument<TerraformValue<string>>("expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => GetArgument<TerraformValue<bool>>("https_only");
        set => SetArgument("https_only", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformValue<string> Sas
        => AsReference("sas");

    /// <summary>
    /// Permissions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public required TerraformList<AzurermStorageAccountBlobContainerSasDataSourcePermissionsBlock> Permissions
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageAccountBlobContainerSasDataSourcePermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountBlobContainerSasDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountBlobContainerSasDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
