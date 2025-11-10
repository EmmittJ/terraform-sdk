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
        set => SetProperty("add", value);
    }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    public required TerraformProperty<bool> Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformProperty<bool> Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<bool> Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    public required TerraformProperty<bool> List
    {
        set => SetProperty("list", value);
    }

    /// <summary>
    /// The process attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Process is required")]
    public required TerraformProperty<bool> Process
    {
        set => SetProperty("process", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformProperty<bool> Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformProperty<bool> Tag
    {
        set => SetProperty("tag", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Update is required")]
    public required TerraformProperty<bool> Update
    {
        set => SetProperty("update", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformProperty<bool> Write
    {
        set => SetProperty("write", value);
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
        set => SetProperty("container", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    public required TerraformProperty<bool> Object
    {
        set => SetProperty("object", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<bool> Service
    {
        set => SetProperty("service", value);
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
        set => SetProperty("blob", value);
    }

    /// <summary>
    /// The file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    public required TerraformProperty<bool> File
    {
        set => SetProperty("file", value);
    }

    /// <summary>
    /// The queue attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queue is required")]
    public required TerraformProperty<bool> Queue
    {
        set => SetProperty("queue", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<bool> Table
    {
        set => SetProperty("table", value);
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
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account_sas.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStorageAccountSasDataSource : TerraformDataSource
{
    public AzurermStorageAccountSasDataSource(string name) : base("azurerm_storage_account_sas", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("sas");
        SetOutput("connection_string");
        SetOutput("expiry");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("ip_addresses");
        SetOutput("signed_version");
        SetOutput("start");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformProperty<string> Expiry
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiry");
        set => SetProperty("expiry", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool> HttpsOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_only");
        set => SetProperty("https_only", value);
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
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformProperty<string> IpAddresses
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_addresses");
        set => SetProperty("ip_addresses", value);
    }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    public TerraformProperty<string> SignedVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signed_version");
        set => SetProperty("signed_version", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformProperty<string> Start
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start");
        set => SetProperty("start", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public List<AzurermStorageAccountSasDataSourcePermissionsBlock>? Permissions
    {
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// Block for resource_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceTypes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceTypes block(s) allowed")]
    public List<AzurermStorageAccountSasDataSourceResourceTypesBlock>? ResourceTypes
    {
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// Block for services.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Services block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Services block(s) allowed")]
    public List<AzurermStorageAccountSasDataSourceServicesBlock>? Services
    {
        set => SetProperty("services", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountSasDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    public TerraformExpression Sas => this["sas"];

}
