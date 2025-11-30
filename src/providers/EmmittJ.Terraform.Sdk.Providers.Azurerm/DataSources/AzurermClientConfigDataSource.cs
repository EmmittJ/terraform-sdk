using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermClientConfigDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermClientConfigDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_client_config Terraform data source.
/// Retrieves information about a azurerm_client_config.
/// </summary>
public partial class AzurermClientConfigDataSource(string name) : TerraformDataSource("azurerm_client_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermClientConfigDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermClientConfigDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
