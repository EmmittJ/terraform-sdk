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
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => new TerraformReference<string>(this, "organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The directory_customer_id attribute.
    /// </summary>
    public TerraformValue<string> DirectoryCustomerId
    {
        get => new TerraformReference<string>(this, "directory_customer_id");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
    }

}
