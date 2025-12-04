using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_organizations Terraform data source.
/// Retrieves information about a google_organizations.
/// </summary>
public partial class GoogleOrganizationsDataSource(string name) : TerraformDataSource("google_organizations", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
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
    /// The organizations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Organizations
        => AsReference("organizations");

}
