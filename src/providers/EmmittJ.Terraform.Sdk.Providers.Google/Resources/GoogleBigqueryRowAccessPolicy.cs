using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryRowAccessPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_row_access_policy resource.
/// </summary>
public partial class GoogleBigqueryRowAccessPolicy : TerraformResource
{
    public GoogleBigqueryRowAccessPolicy(string name) : base("google_bigquery_row_access_policy", name)
    {
    }

    /// <summary>
    /// The ID of the dataset containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatasetId { get; set; }

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
    [TerraformProperty("filter_predicate")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FilterPredicate { get; set; }

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
    [TerraformProperty("grantees")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Grantees { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the row access policy. The ID must contain only
    /// letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum
    /// length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    [TerraformProperty("policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The ID of the table containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformProperty("table_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBigqueryRowAccessPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when this row access policy was created, in milliseconds since
    /// the epoch.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The time when this row access policy was last modified, in milliseconds
    /// since the epoch.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTime { get; }

}
