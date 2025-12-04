using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWebPubsubDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_web_pubsub Terraform data source.
/// Retrieves information about a azurerm_web_pubsub.
/// </summary>
public partial class AzurermWebPubsubDataSource(string name) : TerraformDataSource("azurerm_web_pubsub", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AadAuthEnabled
        => AsReference("aad_auth_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => AsReference("capacity");

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
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAuthEnabled
        => AsReference("local_auth_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

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
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TlsClientCertEnabled
        => AsReference("tls_client_cert_enabled");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
