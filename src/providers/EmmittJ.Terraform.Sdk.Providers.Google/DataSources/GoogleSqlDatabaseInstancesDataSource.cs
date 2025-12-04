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
        get => GetArgument<TerraformValue<string>>("database_version");
        set => SetArgument("database_version", value);
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
    /// Project ID of the project that contains the instances.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified region.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// To filter out the database instances based on the current state of the database instance, valid values include : &amp;quot;SQL_INSTANCE_STATE_UNSPECIFIED&amp;quot;, &amp;quot;RUNNABLE&amp;quot;, &amp;quot;SUSPENDED&amp;quot;, &amp;quot;PENDING_DELETE&amp;quot;, &amp;quot;PENDING_CREATE&amp;quot;, &amp;quot;MAINTENANCE&amp;quot; and &amp;quot;FAILED&amp;quot;.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// To filter out the database instances based on the machine type.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified zone.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Instances
        => AsReference("instances");

}
