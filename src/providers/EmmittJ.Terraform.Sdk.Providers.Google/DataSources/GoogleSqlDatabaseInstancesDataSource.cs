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
        SetOutput("instances");
        SetOutput("database_version");
        SetOutput("id");
        SetOutput("project");
        SetOutput("region");
        SetOutput("state");
        SetOutput("tier");
        SetOutput("zone");
    }

    /// <summary>
    /// To filter out the database instances which are of the specified database version.
    /// </summary>
    public TerraformProperty<string> DatabaseVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_version");
        set => SetProperty("database_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Project ID of the project that contains the instances.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified region.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// To filter out the database instances based on the current state of the database instance, valid values include : &amp;quot;SQL_INSTANCE_STATE_UNSPECIFIED&amp;quot;, &amp;quot;RUNNABLE&amp;quot;, &amp;quot;SUSPENDED&amp;quot;, &amp;quot;PENDING_DELETE&amp;quot;, &amp;quot;PENDING_CREATE&amp;quot;, &amp;quot;MAINTENANCE&amp;quot; and &amp;quot;FAILED&amp;quot;.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// To filter out the database instances based on the machine type.
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// To filter out the database instances which are located in this specified zone.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

}
