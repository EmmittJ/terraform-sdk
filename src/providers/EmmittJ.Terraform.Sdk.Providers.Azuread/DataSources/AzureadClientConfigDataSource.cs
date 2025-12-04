using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadClientConfigDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadClientConfigDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_client_config Terraform data source.
/// Retrieves information about a azuread_client_config.
/// </summary>
public partial class AzureadClientConfigDataSource(string name) : TerraformDataSource("azuread_client_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The client ID (application ID) linked to the authenticated principal, or the application used for delegated authentication
    /// </summary>
    public TerraformValue<string> ClientId
        => AsReference("client_id");

    /// <summary>
    /// The object ID of the authenticated principal
    /// </summary>
    public TerraformValue<string> ObjectId
        => AsReference("object_id");

    /// <summary>
    /// The tenant ID of the authenticated principal
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadClientConfigDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadClientConfigDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
