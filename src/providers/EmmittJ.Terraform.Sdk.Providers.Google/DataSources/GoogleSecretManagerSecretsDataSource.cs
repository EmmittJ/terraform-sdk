using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_secret_manager_secrets Terraform data source.
/// Retrieves information about a google_secret_manager_secrets.
/// </summary>
public partial class GoogleSecretManagerSecretsDataSource(string name) : TerraformDataSource("google_secret_manager_secrets", name)
{
    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering (https://cloud.google.com/secret-manager/docs/filtering).
    /// List only secrets matching the filter. If filter is empty, all secrets are listed.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Secrets
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secrets").ResolveNodes(ctx));
    }

}
