using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryRowAccessPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_row_access_policy resource.
/// </summary>
public class GoogleBigqueryRowAccessPolicy : TerraformResource
{
    public GoogleBigqueryRowAccessPolicy(string name) : base("google_bigquery_row_access_policy", name)
    {
    }

    /// <summary>
    /// The ID of the dataset containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// A SQL boolean expression that represents the rows defined by this row
    /// access policy, similar to the boolean expression in a WHERE clause of a
    /// SELECT query on a table.
    /// References to other tables, routines, and temporary functions are not
    /// supported.
    /// 
    /// Examples: region=&amp;quot;EU&amp;quot;
    /// date_field = CAST(&#39;2019-9-27&#39; as DATE)
    /// nullable_field is not NULL
    /// numeric_field BETWEEN 1.0 AND 5.0
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterPredicate is required")]
    [TerraformPropertyName("filter_predicate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FilterPredicate { get; set; }

    /// <summary>
    /// Input only. The optional list of iam_member users or groups that specifies the initial
    /// members that the row-level access policy should be created with.
    /// 
    /// grantees types:
    /// - &amp;quot;user:alice@example.com&amp;quot;: An email address that represents a specific
    /// Google account.
    /// - &amp;quot;serviceAccount:my-other-app@appspot.gserviceaccount.com&amp;quot;: An email
    /// address that represents a service account.
    /// - &amp;quot;group:admins@example.com&amp;quot;: An email address that represents a Google
    /// group.
    /// - &amp;quot;domain:example.com&amp;quot;:The Google Workspace domain (primary) that
    /// represents all the users of that domain.
    /// - &amp;quot;allAuthenticatedUsers&amp;quot;: A special identifier that represents all service
    /// accounts and all users on the internet who have authenticated with a Google
    /// Account. This identifier includes accounts that aren&#39;t connected to a
    /// Google Workspace or Cloud Identity domain, such as personal Gmail accounts.
    /// Users who aren&#39;t authenticated, such as anonymous visitors, aren&#39;t
    /// included.
    /// - &amp;quot;allUsers&amp;quot;:A special identifier that represents anyone who is on
    /// the internet, including authenticated and unauthenticated users. Because
    /// BigQuery requires authentication before a user can access the service,
    /// allUsers includes only authenticated users.
    /// </summary>
    [TerraformPropertyName("grantees")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Grantees { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the row access policy. The ID must contain only
    /// letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum
    /// length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    [TerraformPropertyName("policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The ID of the table containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformPropertyName("table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryRowAccessPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when this row access policy was created, in milliseconds since
    /// the epoch.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The time when this row access policy was last modified, in milliseconds
    /// since the epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedTime => new TerraformReference(this, "last_modified_time");

}
