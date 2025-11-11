using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instances.
/// </summary>
public partial class GoogleSqlDatabaseInstancesDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstancesDataSource(string name) : base("google_sql_database_instances", name)
    {
    }

    /// <summary>
    /// To filter out the database instances which are of the specified database version.
    /// </summary>
    [TerraformProperty("database_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DatabaseVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Project ID of the project that contains the instances.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// To filter out the database instances which are located in this specified region.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// To filter out the database instances based on the current state of the database instance, valid values include : &amp;quot;SQL_INSTANCE_STATE_UNSPECIFIED&amp;quot;, &amp;quot;RUNNABLE&amp;quot;, &amp;quot;SUSPENDED&amp;quot;, &amp;quot;PENDING_DELETE&amp;quot;, &amp;quot;PENDING_CREATE&amp;quot;, &amp;quot;MAINTENANCE&amp;quot; and &amp;quot;FAILED&amp;quot;.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// To filter out the database instances based on the machine type.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// To filter out the database instances which are located in this specified zone.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Instances { get; }

}
