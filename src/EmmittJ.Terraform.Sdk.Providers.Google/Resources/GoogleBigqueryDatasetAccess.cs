using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_dataset_access resource.
/// </summary>
public class GoogleBigqueryDatasetAccess : TerraformResource
{
    public GoogleBigqueryDatasetAccess(string name) : base("google_bigquery_dataset_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_updated_member");
    }

    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    public string? DatasetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset_id")?.Value;
        set => this.WithProperty("dataset_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    public string? GroupByEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_by_email")?.Value;
        set => this.WithProperty("group_by_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    public string? IamMember
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_member")?.Value;
        set => this.WithProperty("iam_member", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles are
    /// supported. Predefined roles that have equivalent basic roles are
    /// swapped by the API to their basic counterparts, and will show a diff
    /// post-create. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    public string? SpecialGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("special_group")?.Value;
        set => this.WithProperty("special_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    public string? UserByEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_by_email")?.Value;
        set => this.WithProperty("user_by_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, represents that that the iam_member in the config was translated to a different member type by the API, and is stored in state as a different member type
    /// </summary>
    public TerraformExpression ApiUpdatedMember => this["api_updated_member"];

}
