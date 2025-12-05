using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationPublishedAppIdsDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_application_published_app_ids Terraform data source.
/// Retrieves information about a azuread_application_published_app_ids.
/// </summary>
public partial class AzureadApplicationPublishedAppIdsDataSource(string name) : TerraformDataSource("azuread_application_published_app_ids", name)
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
    /// A mapping of application names and application IDs
    /// </summary>
    public TerraformMap<string> Result
        => CreateReference("result");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
