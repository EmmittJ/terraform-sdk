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
/// Block type for permissions in .
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Add is required")]
    [TerraformArgument("add")]
    public required new TerraformValue<bool> Add
    {
        get => new TerraformReference<bool>(this, "add");
        set => SetArgument("add", value);
    }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    [TerraformArgument("create")]
    public required TerraformValue<bool> Create
    {
        get => new TerraformReference<bool>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    [TerraformArgument("delete")]
    public required TerraformValue<bool> Delete
    {
        get => new TerraformReference<bool>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    [TerraformArgument("list")]
    public required TerraformValue<bool> List
    {
        get => new TerraformReference<bool>(this, "list");
        set => SetArgument("list", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    [TerraformArgument("read")]
    public required TerraformValue<bool> Read
    {
        get => new TerraformReference<bool>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    [TerraformArgument("write")]
    public required TerraformValue<bool> Write
    {
        get => new TerraformReference<bool>(this, "write");
        set => SetArgument("write", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account_blob_container_sas.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStorageAccountBlobContainerSasDataSource : TerraformDataSource
{
    public AzurermStorageAccountBlobContainerSasDataSource(string name) : base("azurerm_storage_account_blob_container_sas", name)
    {
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformArgument("cache_control")]
    public TerraformValue<string>? CacheControl
    {
        get => new TerraformReference<string>(this, "cache_control");
        set => SetArgument("cache_control", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformArgument("connection_string")]
    public required TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformArgument("container_name")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformArgument("content_disposition")]
    public TerraformValue<string>? ContentDisposition
    {
        get => new TerraformReference<string>(this, "content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformArgument("content_encoding")]
    public TerraformValue<string>? ContentEncoding
    {
        get => new TerraformReference<string>(this, "content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformArgument("content_language")]
    public TerraformValue<string>? ContentLanguage
    {
        get => new TerraformReference<string>(this, "content_language");
        set => SetArgument("content_language", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformArgument("content_type")]
    public TerraformValue<string>? ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    [TerraformArgument("expiry")]
    public required TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
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
    /// The ip_address attribute.
    /// </summary>
    [TerraformArgument("ip_address")]
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    [TerraformArgument("start")]
    public required TerraformValue<string> Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    [TerraformArgument("permissions")]
    public required TerraformList<AzurermStorageAccountBlobContainerSasDataSourcePermissionsBlock> Permissions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountBlobContainerSasDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sas attribute.
    /// </summary>
    [TerraformArgument("sas")]
    public TerraformValue<string> Sas
    {
        get => new TerraformReference<string>(this, "sas");
    }

}
