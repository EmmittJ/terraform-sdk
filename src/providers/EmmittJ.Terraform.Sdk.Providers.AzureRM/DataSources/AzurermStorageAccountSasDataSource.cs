using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasDataSourcePermissionsBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "add");
        set => SetArgument("add", value);
    }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    public required TerraformValue<bool> Create
    {
        get => new TerraformReference<bool>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformValue<bool> Delete
    {
        get => new TerraformReference<bool>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<bool> Filter
    {
        get => new TerraformReference<bool>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    public required TerraformValue<bool> List
    {
        get => new TerraformReference<bool>(this, "list");
        set => SetArgument("list", value);
    }

    /// <summary>
    /// The process attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Process is required")]
    public required TerraformValue<bool> Process
    {
        get => new TerraformReference<bool>(this, "process");
        set => SetArgument("process", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformValue<bool> Read
    {
        get => new TerraformReference<bool>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformValue<bool> Tag
    {
        get => new TerraformReference<bool>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Update is required")]
    public required TerraformValue<bool> Update
    {
        get => new TerraformReference<bool>(this, "update");
        set => SetArgument("update", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformValue<bool> Write
    {
        get => new TerraformReference<bool>(this, "write");
        set => SetArgument("write", value);
    }

}

/// <summary>
/// Block type for resource_types in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasDataSourceResourceTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_types";

    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformValue<bool> Container
    {
        get => new TerraformReference<bool>(this, "container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<bool> ObjectAttribute
    {
        get => new TerraformReference<bool>(this, "object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<bool> Service
    {
        get => new TerraformReference<bool>(this, "service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for services in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasDataSourceServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "services";

    /// <summary>
    /// The blob attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Blob is required")]
    public required TerraformValue<bool> Blob
    {
        get => new TerraformReference<bool>(this, "blob");
        set => SetArgument("blob", value);
    }

    /// <summary>
    /// The file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    public required TerraformValue<bool> File
    {
        get => new TerraformReference<bool>(this, "file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// The queue attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queue is required")]
    public required TerraformValue<bool> Queue
    {
        get => new TerraformReference<bool>(this, "queue");
        set => SetArgument("queue", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<bool> Table
    {
        get => new TerraformReference<bool>(this, "table");
        set => SetArgument("table", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountSasDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_storage_account_sas Terraform data source.
/// Retrieves information about a azurerm_storage_account_sas.
/// </summary>
public partial class AzurermStorageAccountSasDataSource(string name) : TerraformDataSource("azurerm_storage_account_sas", name)
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformValue<string> Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformValue<string>? IpAddresses
    {
        get => new TerraformReference<string>(this, "ip_addresses");
        set => SetArgument("ip_addresses", value);
    }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    public TerraformValue<string>? SignedVersion
    {
        get => new TerraformReference<string>(this, "signed_version");
        set => SetArgument("signed_version", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// Permissions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public required TerraformList<AzurermStorageAccountSasDataSourcePermissionsBlock> Permissions
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageAccountSasDataSourcePermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// ResourceTypes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceTypes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceTypes block(s) allowed")]
    public required TerraformList<AzurermStorageAccountSasDataSourceResourceTypesBlock> ResourceTypes
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageAccountSasDataSourceResourceTypesBlock>>("resource_types");
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// Services block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Services block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Services block(s) allowed")]
    public required TerraformList<AzurermStorageAccountSasDataSourceServicesBlock> Services
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageAccountSasDataSourceServicesBlock>>("services");
        set => SetArgument("services", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountSasDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountSasDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
