using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instances.
/// </summary>
public class GoogleSqlDatabaseInstancesDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstancesDataSource(string name) : base("google_sql_database_instances", name)
    {
    }

    /// <summary>
    /// To filter out the database instances which are of the specified database version.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Project ID of the project that contains the instances.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// To filter out the database instances which are located in this specified region.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// To filter out the database instances based on the current state of the database instance, valid values include : &amp;quot;SQL_INSTANCE_STATE_UNSPECIFIED&amp;quot;, &amp;quot;RUNNABLE&amp;quot;, &amp;quot;SUSPENDED&amp;quot;, &amp;quot;PENDING_DELETE&amp;quot;, &amp;quot;PENDING_CREATE&amp;quot;, &amp;quot;MAINTENANCE&amp;quot; and &amp;quot;FAILED&amp;quot;.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// To filter out the database instances based on the machine type.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// To filter out the database instances which are located in this specified zone.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Instances => new TerraformReference(this, "instances");

}
