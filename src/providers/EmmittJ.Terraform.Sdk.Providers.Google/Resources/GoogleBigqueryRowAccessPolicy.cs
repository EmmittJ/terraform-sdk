using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryRowAccessPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_row_access_policy resource.
/// </summary>
public class GoogleBigqueryRowAccessPolicy : TerraformResource
{
    public GoogleBigqueryRowAccessPolicy(string name) : base("google_bigquery_row_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_time");
        SetOutput("last_modified_time");
        SetOutput("dataset_id");
        SetOutput("filter_predicate");
        SetOutput("grantees");
        SetOutput("id");
        SetOutput("policy_id");
        SetOutput("project");
        SetOutput("table_id");
    }

    /// <summary>
    /// The ID of the dataset containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset_id");
        set => SetProperty("dataset_id", value);
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
    public required TerraformProperty<string> FilterPredicate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_predicate");
        set => SetProperty("filter_predicate", value);
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
    public List<TerraformProperty<string>> Grantees
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("grantees");
        set => SetProperty("grantees", value);
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
    /// The ID of the row access policy. The ID must contain only
    /// letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum
    /// length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformProperty<string> PolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_id");
        set => SetProperty("policy_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The ID of the table containing this row access policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformProperty<string> TableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_id");
        set => SetProperty("table_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryRowAccessPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time when this row access policy was created, in milliseconds since
    /// the epoch.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The time when this row access policy was last modified, in milliseconds
    /// since the epoch.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

}
