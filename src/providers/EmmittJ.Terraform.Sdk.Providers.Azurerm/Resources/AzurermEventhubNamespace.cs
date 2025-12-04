using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermEventhubNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermEventhubNamespaceIdentityBlock : TerraformBlock
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
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermEventhubNamespace.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventhub_namespace Terraform resource.
/// Manages a azurerm_eventhub_namespace resource.
/// </summary>
public partial class AzurermEventhubNamespace(string name) : TerraformResource("azurerm_eventhub_namespace", name)
{
    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoInflateEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_inflate_enabled");
        set => SetArgument("auto_inflate_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? DedicatedClusterId
    {
        get => GetArgument<TerraformValue<string>>("dedicated_cluster_id");
        set => SetArgument("dedicated_cluster_id", value);
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    public TerraformValue<double>? MaximumThroughputUnits
    {
        get => GetArgument<TerraformValue<double>>("maximum_throughput_units");
        set => SetArgument("maximum_throughput_units", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_rulesets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? NetworkRulesets
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("network_rulesets");
        set => SetArgument("network_rulesets", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
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
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionString
        => AsReference("default_primary_connection_string");

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionStringAlias
        => AsReference("default_primary_connection_string_alias");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
        => AsReference("default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionString
        => AsReference("default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionStringAlias
        => AsReference("default_secondary_connection_string_alias");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
        => AsReference("default_secondary_key");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermEventhubNamespaceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermEventhubNamespaceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubNamespaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubNamespaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
