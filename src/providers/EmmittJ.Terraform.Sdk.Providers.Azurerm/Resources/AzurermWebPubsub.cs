using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermWebPubsub.
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubIdentityBlock : TerraformBlock
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
/// Block type for live_trace in AzurermWebPubsub.
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubLiveTraceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "live_trace";

    /// <summary>
    /// The connectivity_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ConnectivityLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("connectivity_logs_enabled");
        set => SetArgument("connectivity_logs_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_request_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpRequestLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("http_request_logs_enabled");
        set => SetArgument("http_request_logs_enabled", value);
    }

    /// <summary>
    /// The messaging_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MessagingLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("messaging_logs_enabled");
        set => SetArgument("messaging_logs_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWebPubsub.
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_web_pubsub Terraform resource.
/// Manages a azurerm_web_pubsub resource.
/// </summary>
public partial class AzurermWebPubsub(string name) : TerraformResource("azurerm_web_pubsub", name)
{
    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AadAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("aad_auth_enabled");
        set => SetArgument("aad_auth_enabled", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsClientCertEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_client_cert_enabled");
        set => SetArgument("tls_client_cert_enabled", value);
    }

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    public TerraformValue<string> ExternalIp
        => AsReference("external_ip");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    public TerraformValue<double> PublicPort
        => AsReference("public_port");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformValue<double> ServerPort
        => AsReference("server_port");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWebPubsubIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWebPubsubIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// LiveTrace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LiveTrace block(s) allowed")]
    public TerraformList<AzurermWebPubsubLiveTraceBlock>? LiveTrace
    {
        get => GetArgument<TerraformList<AzurermWebPubsubLiveTraceBlock>>("live_trace");
        set => SetArgument("live_trace", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
