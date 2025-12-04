using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_secret_manager_regional_secrets Terraform data source.
/// Retrieves information about a google_secret_manager_regional_secrets.
/// </summary>
public partial class GoogleSecretManagerRegionalSecretsDataSource(string name) : TerraformDataSource("google_secret_manager_regional_secrets", name)
{
    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering (https://cloud.google.com/secret-manager/docs/filtering).
    /// List only secrets matching the filter. If filter is empty, all regional secrets are listed from the specified location.
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Secrets
        => AsReference("secrets");

}
