using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_ca_certs Terraform data source.
/// Retrieves information about a google_sql_ca_certs.
/// </summary>
public partial class GoogleSqlCaCertsDataSource(string name) : TerraformDataSource("google_sql_ca_certs", name)
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
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
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
    /// The active_version attribute.
    /// </summary>
    public TerraformValue<string> ActiveVersion
    {
        get => new TerraformReference<string>(this, "active_version");
    }

    /// <summary>
    /// The certs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certs").ResolveNodes(ctx));
    }

}
