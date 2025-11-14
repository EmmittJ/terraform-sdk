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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSearchServiceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_search_service.
/// </summary>
public class AzurermSearchServiceDataSource : TerraformDataSource
{
    public AzurermSearchServiceDataSource(string name) : base("azurerm_search_service", name)
    {
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSearchServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_encryption_compliance_status")]
    public TerraformValue<string> CustomerManagedKeyEncryptionComplianceStatus
    {
        get => new TerraformReference<string>(this, "customer_managed_key_encryption_compliance_status");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [TerraformArgument("partition_count")]
    public TerraformValue<double> PartitionCount
    {
        get => new TerraformReference<double>(this, "partition_count");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformArgument("primary_key")]
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    [TerraformArgument("query_keys")]
    public TerraformList<object> QueryKeys
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "query_keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The replica_count attribute.
    /// </summary>
    [TerraformArgument("replica_count")]
    public TerraformValue<double> ReplicaCount
    {
        get => new TerraformReference<double>(this, "replica_count");
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformArgument("secondary_key")]
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
