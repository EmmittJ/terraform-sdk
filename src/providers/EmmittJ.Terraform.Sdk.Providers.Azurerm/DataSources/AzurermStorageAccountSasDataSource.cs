using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for permissions in AzurermStorageAccountSasDataSource.
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
        get => GetRequiredArgument<TerraformValue<bool>>("add");
        set => SetArgument("add", value);
    }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    public required TerraformValue<bool> Create
    {
        get => GetRequiredArgument<TerraformValue<bool>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformValue<bool> Delete
    {
        get => GetRequiredArgument<TerraformValue<bool>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<bool> Filter
    {
        get => GetRequiredArgument<TerraformValue<bool>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    public required TerraformValue<bool> List
    {
        get => GetRequiredArgument<TerraformValue<bool>>("list");
        set => SetArgument("list", value);
    }

    /// <summary>
    /// The process attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Process is required")]
    public required TerraformValue<bool> Process
    {
        get => GetRequiredArgument<TerraformValue<bool>>("process");
        set => SetArgument("process", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformValue<bool> Read
    {
        get => GetRequiredArgument<TerraformValue<bool>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformValue<bool> Tag
    {
        get => GetRequiredArgument<TerraformValue<bool>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Update is required")]
    public required TerraformValue<bool> Update
    {
        get => GetRequiredArgument<TerraformValue<bool>>("update");
        set => SetArgument("update", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformValue<bool> Write
    {
        get => GetRequiredArgument<TerraformValue<bool>>("write");
        set => SetArgument("write", value);
    }

}


/// <summary>
/// Block type for resource_types in AzurermStorageAccountSasDataSource.
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
        get => GetRequiredArgument<TerraformValue<bool>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<bool> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<bool> Service
    {
        get => GetRequiredArgument<TerraformValue<bool>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for services in AzurermStorageAccountSasDataSource.
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
        get => GetRequiredArgument<TerraformValue<bool>>("blob");
        set => SetArgument("blob", value);
    }

    /// <summary>
    /// The file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    public required TerraformValue<bool> File
    {
        get => GetRequiredArgument<TerraformValue<bool>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// The queue attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queue is required")]
    public required TerraformValue<bool> Queue
    {
        get => GetRequiredArgument<TerraformValue<bool>>("queue");
        set => SetArgument("queue", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<bool> Table
    {
        get => GetRequiredArgument<TerraformValue<bool>>("table");
        set => SetArgument("table", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageAccountSasDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetRequiredArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformValue<string> Expiry
    {
        get => GetRequiredArgument<TerraformValue<string>>("expiry");
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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformValue<string>? IpAddresses
    {
        get => GetArgument<TerraformValue<string>>("ip_addresses");
        set => SetArgument("ip_addresses", value);
    }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    public TerraformValue<string>? SignedVersion
    {
        get => GetArgument<TerraformValue<string>>("signed_version");
        set => SetArgument("signed_version", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => GetRequiredArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformValue<string> Sas
        => CreateReference("sas");

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
