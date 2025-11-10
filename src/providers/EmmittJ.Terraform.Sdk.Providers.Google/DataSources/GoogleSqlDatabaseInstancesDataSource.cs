using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instances.
/// </summary>
public class GoogleSqlDatabaseInstancesDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstancesDataSource(string name) : base("google_sql_database_instances", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("instances");
    }

    /// <summary>
    /// To filter out the database instances which are of the specified database version.
    /// </summary>
    public TerraformProperty<string>? DatabaseVersion
    {
        get => GetProperty<TerraformProperty<string>>("database_version");
        set => this.WithProperty("database_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Project ID of the project that contains the instances.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified region.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// To filter out the database instances based on the current state of the database instance, valid values include : &amp;quot;SQL_INSTANCE_STATE_UNSPECIFIED&amp;quot;, &amp;quot;RUNNABLE&amp;quot;, &amp;quot;SUSPENDED&amp;quot;, &amp;quot;PENDING_DELETE&amp;quot;, &amp;quot;PENDING_CREATE&amp;quot;, &amp;quot;MAINTENANCE&amp;quot; and &amp;quot;FAILED&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// To filter out the database instances based on the machine type.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified zone.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

}
