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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPurviewAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPurviewAccountTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_purview_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPurviewAccount : TerraformResource
{
    public AzurermPurviewAccount(string name) : base("azurerm_purview_account", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    [TerraformArgument("managed_event_hub_enabled")]
    public TerraformValue<bool>? ManagedEventHubEnabled
    {
        get => new TerraformReference<bool>(this, "managed_event_hub_enabled");
        set => SetArgument("managed_event_hub_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformArgument("managed_resource_group_name")]
    public TerraformValue<string> ManagedResourceGroupName
    {
        get => new TerraformReference<string>(this, "managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
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
    /// The public_network_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_enabled")]
    public TerraformValue<bool>? PublicNetworkEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_enabled");
        set => SetArgument("public_network_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public required TerraformList<AzurermPurviewAccountIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPurviewAccountTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The atlas_kafka_endpoint_primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("atlas_kafka_endpoint_primary_connection_string")]
    public TerraformValue<string> AtlasKafkaEndpointPrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "atlas_kafka_endpoint_primary_connection_string");
    }

    /// <summary>
    /// The atlas_kafka_endpoint_secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("atlas_kafka_endpoint_secondary_connection_string")]
    public TerraformValue<string> AtlasKafkaEndpointSecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "atlas_kafka_endpoint_secondary_connection_string");
    }

    /// <summary>
    /// The aws_external_id attribute.
    /// </summary>
    [TerraformArgument("aws_external_id")]
    public TerraformValue<string> AwsExternalId
    {
        get => new TerraformReference<string>(this, "aws_external_id");
    }

    /// <summary>
    /// The catalog_endpoint attribute.
    /// </summary>
    [TerraformArgument("catalog_endpoint")]
    public TerraformValue<string> CatalogEndpoint
    {
        get => new TerraformReference<string>(this, "catalog_endpoint");
    }

    /// <summary>
    /// The guardian_endpoint attribute.
    /// </summary>
    [TerraformArgument("guardian_endpoint")]
    public TerraformValue<string> GuardianEndpoint
    {
        get => new TerraformReference<string>(this, "guardian_endpoint");
    }

    /// <summary>
    /// The managed_resources attribute.
    /// </summary>
    [TerraformArgument("managed_resources")]
    public TerraformList<object> ManagedResources
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "managed_resources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scan_endpoint attribute.
    /// </summary>
    [TerraformArgument("scan_endpoint")]
    public TerraformValue<string> ScanEndpoint
    {
        get => new TerraformReference<string>(this, "scan_endpoint");
    }

}
