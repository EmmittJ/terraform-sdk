using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBigqueryRowAccessPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryRowAccessPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_row_access_policy Terraform resource.
/// Manages a google_bigquery_row_access_policy resource.
/// </summary>
public partial class GoogleBigqueryRowAccessPolicy(string name) : TerraformResource("google_bigquery_row_access_policy", name)
{
    /// <summary>
    /// The ID of the dataset containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
    }

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
    public required TerraformValue<string> FilterPredicate
    {
        get => new TerraformReference<string>(this, "filter_predicate");
        set => SetArgument("filter_predicate", value);
    }

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
    public TerraformList<string>? Grantees
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "grantees").ResolveNodes(ctx));
        set => SetArgument("grantees", value);
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
    /// The ID of the row access policy. The ID must contain only
    /// letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum
    /// length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformValue<string> PolicyId
    {
        get => new TerraformReference<string>(this, "policy_id");
        set => SetArgument("policy_id", value);
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
    /// The ID of the table containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => new TerraformReference<string>(this, "table_id");
        set => SetArgument("table_id", value);
    }

    /// <summary>
    /// The time when this row access policy was created, in milliseconds since
    /// the epoch.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The time when this row access policy was last modified, in milliseconds
    /// since the epoch.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryRowAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryRowAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
