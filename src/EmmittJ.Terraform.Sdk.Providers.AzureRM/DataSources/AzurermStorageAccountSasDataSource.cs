using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasDataSourcePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The add attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Add is required")]
    public required TerraformProperty<bool> Add
    {
        get => GetProperty<TerraformProperty<bool>>("add");
        set => WithProperty("add", value);
    }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    public required TerraformProperty<bool> Create
    {
        get => GetProperty<TerraformProperty<bool>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformProperty<bool> Delete
    {
        get => GetProperty<TerraformProperty<bool>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<bool> Filter
    {
        get => GetProperty<TerraformProperty<bool>>("filter");
        set => WithProperty("filter", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    public required TerraformProperty<bool> List
    {
        get => GetProperty<TerraformProperty<bool>>("list");
        set => WithProperty("list", value);
    }

    /// <summary>
    /// The process attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Process is required")]
    public required TerraformProperty<bool> Process
    {
        get => GetProperty<TerraformProperty<bool>>("process");
        set => WithProperty("process", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformProperty<bool> Read
    {
        get => GetProperty<TerraformProperty<bool>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformProperty<bool> Tag
    {
        get => GetProperty<TerraformProperty<bool>>("tag");
        set => WithProperty("tag", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Update is required")]
    public required TerraformProperty<bool> Update
    {
        get => GetProperty<TerraformProperty<bool>>("update");
        set => WithProperty("update", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformProperty<bool> Write
    {
        get => GetProperty<TerraformProperty<bool>>("write");
        set => WithProperty("write", value);
    }

}

/// <summary>
/// Block type for resource_types in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasDataSourceResourceTypesBlock : TerraformBlock
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformProperty<bool> Container
    {
        get => GetProperty<TerraformProperty<bool>>("container");
        set => WithProperty("container", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    public required TerraformProperty<bool> Object
    {
        get => GetProperty<TerraformProperty<bool>>("object");
        set => WithProperty("object", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<bool> Service
    {
        get => GetProperty<TerraformProperty<bool>>("service");
        set => WithProperty("service", value);
    }

}

/// <summary>
/// Block type for services in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasDataSourceServicesBlock : TerraformBlock
{
    /// <summary>
    /// The blob attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Blob is required")]
    public required TerraformProperty<bool> Blob
    {
        get => GetProperty<TerraformProperty<bool>>("blob");
        set => WithProperty("blob", value);
    }

    /// <summary>
    /// The file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    public required TerraformProperty<bool> File
    {
        get => GetProperty<TerraformProperty<bool>>("file");
        set => WithProperty("file", value);
    }

    /// <summary>
    /// The queue attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queue is required")]
    public required TerraformProperty<bool> Queue
    {
        get => GetProperty<TerraformProperty<bool>>("queue");
        set => WithProperty("queue", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<bool> Table
    {
        get => GetProperty<TerraformProperty<bool>>("table");
        set => WithProperty("table", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountSasDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account_sas.
/// </summary>
public class AzurermStorageAccountSasDataSource : TerraformDataSource
{
    public AzurermStorageAccountSasDataSource(string name) : base("azurerm_storage_account_sas", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sas");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformProperty<string> Expiry
    {
        get => GetProperty<TerraformProperty<string>>("expiry");
        set => this.WithProperty("expiry", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
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
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddresses
    {
        get => GetProperty<TerraformProperty<string>>("ip_addresses");
        set => this.WithProperty("ip_addresses", value);
    }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    public TerraformProperty<string>? SignedVersion
    {
        get => GetProperty<TerraformProperty<string>>("signed_version");
        set => this.WithProperty("signed_version", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformProperty<string> Start
    {
        get => GetProperty<TerraformProperty<string>>("start");
        set => this.WithProperty("start", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public List<AzurermStorageAccountSasDataSourcePermissionsBlock>? Permissions
    {
        get => GetProperty<List<AzurermStorageAccountSasDataSourcePermissionsBlock>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// Block for resource_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceTypes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceTypes block(s) allowed")]
    public List<AzurermStorageAccountSasDataSourceResourceTypesBlock>? ResourceTypes
    {
        get => GetProperty<List<AzurermStorageAccountSasDataSourceResourceTypesBlock>>("resource_types");
        set => this.WithProperty("resource_types", value);
    }

    /// <summary>
    /// Block for services.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Services block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Services block(s) allowed")]
    public List<AzurermStorageAccountSasDataSourceServicesBlock>? Services
    {
        get => GetProperty<List<AzurermStorageAccountSasDataSourceServicesBlock>>("services");
        set => this.WithProperty("services", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountSasDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageAccountSasDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformExpression Sas => this["sas"];

}
