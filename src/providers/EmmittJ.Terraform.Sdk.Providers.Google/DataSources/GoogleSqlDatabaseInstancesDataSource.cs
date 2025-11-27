using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_database_instances Terraform data source.
/// Retrieves information about a google_sql_database_instances.
/// </summary>
public partial class GoogleSqlDatabaseInstancesDataSource(string name) : TerraformDataSource("google_sql_database_instances", name)
{
    /// <summary>
    /// To filter out the database instances which are of the specified database version.
    /// </summary>
    public TerraformValue<string>? DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
        set => SetArgument("database_version", value);
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
    /// Project ID of the project that contains the instances.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified region.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// To filter out the database instances based on the current state of the database instance, valid values include : &amp;quot;SQL_INSTANCE_STATE_UNSPECIFIED&amp;quot;, &amp;quot;RUNNABLE&amp;quot;, &amp;quot;SUSPENDED&amp;quot;, &amp;quot;PENDING_DELETE&amp;quot;, &amp;quot;PENDING_CREATE&amp;quot;, &amp;quot;MAINTENANCE&amp;quot; and &amp;quot;FAILED&amp;quot;.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// To filter out the database instances based on the machine type.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified zone.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Instances
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instances").ResolveNodes(ctx));
    }

}
