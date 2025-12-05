using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_default_service_account Terraform data source.
/// Retrieves information about a google_compute_default_service_account.
/// </summary>
public partial class GoogleComputeDefaultServiceAccountDataSource(string name) : TerraformDataSource("google_compute_default_service_account", name)
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformValue<string> Member
        => CreateReference("member");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
        => CreateReference("unique_id");

}
