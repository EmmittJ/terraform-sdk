using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermPurviewAccount.
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
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => CreateReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPurviewAccount.
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
/// Represents a azurerm_purview_account Terraform resource.
/// Manages a azurerm_purview_account resource.
/// </summary>
public partial class AzurermPurviewAccount(string name) : TerraformResource("azurerm_purview_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ManagedEventHubEnabled
    {
        get => GetArgument<TerraformValue<bool>>("managed_event_hub_enabled");
        set => SetArgument("managed_event_hub_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("managed_resource_group_name") ?? CreateReference("managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_enabled");
        set => SetArgument("public_network_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The atlas_kafka_endpoint_primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> AtlasKafkaEndpointPrimaryConnectionString
        => CreateReference("atlas_kafka_endpoint_primary_connection_string");

    /// <summary>
    /// The atlas_kafka_endpoint_secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> AtlasKafkaEndpointSecondaryConnectionString
        => CreateReference("atlas_kafka_endpoint_secondary_connection_string");

    /// <summary>
    /// The aws_external_id attribute.
    /// </summary>
    public TerraformValue<string> AwsExternalId
        => CreateReference("aws_external_id");

    /// <summary>
    /// The catalog_endpoint attribute.
    /// </summary>
    public TerraformValue<string> CatalogEndpoint
        => CreateReference("catalog_endpoint");

    /// <summary>
    /// The guardian_endpoint attribute.
    /// </summary>
    public TerraformValue<string> GuardianEndpoint
        => CreateReference("guardian_endpoint");

    /// <summary>
    /// The managed_resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedResources
        => CreateReference("managed_resources");

    /// <summary>
    /// The scan_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ScanEndpoint
        => CreateReference("scan_endpoint");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermPurviewAccountIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermPurviewAccountIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPurviewAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPurviewAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
