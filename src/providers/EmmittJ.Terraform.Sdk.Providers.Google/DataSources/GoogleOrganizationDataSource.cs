using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_organization Terraform data source.
/// Retrieves information about a google_organization.
/// </summary>
public partial class GoogleOrganizationDataSource(string name) : TerraformDataSource("google_organization", name)
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
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
    /// The organization attribute.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The directory_customer_id attribute.
    /// </summary>
    public TerraformValue<string> DirectoryCustomerId
        => AsReference("directory_customer_id");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => AsReference("lifecycle_state");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string> OrgId
        => AsReference("org_id");

}
