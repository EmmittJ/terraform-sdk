using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountSasDataSourcePermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The add attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Add is required")]
    [TerraformProperty("add")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Add { get; set; }

    /// <summary>
    /// The create attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Create is required")]
    [TerraformProperty("create")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    [TerraformProperty("delete")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Delete { get; set; }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Filter { get; set; }

    /// <summary>
    /// The list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "List is required")]
    [TerraformProperty("list")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> List { get; set; }

    /// <summary>
    /// The process attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Process is required")]
    [TerraformProperty("process")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Process { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    [TerraformProperty("read")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Read { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    [TerraformProperty("tag")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Tag { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Update is required")]
    [TerraformProperty("update")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Update { get; set; }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    [TerraformProperty("write")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Write { get; set; }

}

/// <summary>
/// Block type for resource_types in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountSasDataSourceResourceTypesBlock : TerraformBlockBase
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformProperty("container")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Container { get; set; }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    [TerraformProperty("object")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Object { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Service { get; set; }

}

/// <summary>
/// Block type for services in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountSasDataSourceServicesBlock : TerraformBlockBase
{
    /// <summary>
    /// The blob attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Blob is required")]
    [TerraformProperty("blob")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Blob { get; set; }

    /// <summary>
    /// The file attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    [TerraformProperty("file")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> File { get; set; }

    /// <summary>
    /// The queue attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queue is required")]
    [TerraformProperty("queue")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Queue { get; set; }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformProperty("table")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Table { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountSasDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account_sas.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStorageAccountSasDataSource : TerraformDataSource
{
    public AzurermStorageAccountSasDataSource(string name) : base("azurerm_storage_account_sas", name)
    {
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformProperty("connection_string")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionString { get; set; }

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    [TerraformProperty("expiry")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Expiry { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformProperty("ip_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddresses { get; set; }

    /// <summary>
    /// The signed_version attribute.
    /// </summary>
    [TerraformProperty("signed_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SignedVersion { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    [TerraformProperty("start")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Start { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    [TerraformProperty("permissions")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSasDataSourcePermissionsBlock>>? Permissions { get; set; }

    /// <summary>
    /// Block for resource_types.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceTypes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceTypes block(s) allowed")]
    [TerraformProperty("resource_types")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSasDataSourceResourceTypesBlock>>? ResourceTypes { get; set; }

    /// <summary>
    /// Block for services.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Services block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Services block(s) allowed")]
    [TerraformProperty("services")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSasDataSourceServicesBlock>>? Services { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageAccountSasDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The sas attribute.
    /// </summary>
    [TerraformProperty("sas")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sas { get; }

}
