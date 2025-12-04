using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadServicePrincipalsDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_service_principals Terraform data source.
/// Retrieves information about a azuread_service_principals.
/// </summary>
public partial class AzureadServicePrincipalsDataSource(string name) : TerraformDataSource("azuread_service_principals", name)
{
    /// <summary>
    /// The client IDs of the applications associated with the service principals
    /// </summary>
    public TerraformList<string>? ClientIds
    {
        get => GetArgument<TerraformList<string>>("client_ids");
        set => SetArgument("client_ids", value);
    }

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    public TerraformList<string>? DisplayNames
    {
        get => GetArgument<TerraformList<string>>("display_names");
        set => SetArgument("display_names", value);
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
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    public TerraformValue<bool>? IgnoreMissing
    {
        get => GetArgument<TerraformValue<bool>>("ignore_missing");
        set => SetArgument("ignore_missing", value);
    }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    public TerraformList<string>? ObjectIds
    {
        get => GetArgument<TerraformList<string>>("object_ids");
        set => SetArgument("object_ids", value);
    }

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    public TerraformValue<bool>? ReturnAll
    {
        get => GetArgument<TerraformValue<bool>>("return_all");
        set => SetArgument("return_all", value);
    }

    /// <summary>
    /// A list of service_principals
    /// </summary>
    public TerraformList<TerraformMap<object>> ServicePrincipals
        => AsReference("service_principals");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadServicePrincipalsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadServicePrincipalsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
