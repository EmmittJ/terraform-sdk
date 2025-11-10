using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessConditionBlock : TerraformBlock
{
    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Which resources in the dataset this entry applies to. Currently, only views are supported,
    /// but additional target types may be added in the future. Possible values: VIEWS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTypes is required")]
    public List<TerraformProperty<string>>? TargetTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_types");
        set => WithProperty("target_types", value);
    }

}

/// <summary>
/// Block type for routine in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessRoutineBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_id");
        set => WithProperty("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformProperty<string> ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

    /// <summary>
    /// The ID of the routine. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    public required TerraformProperty<string> RoutineId
    {
        get => GetProperty<TerraformProperty<string>>("routine_id");
        set => WithProperty("routine_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatasetAccessTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Block type for view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessViewBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_id");
        set => WithProperty("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformProperty<string> ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformProperty<string> TableId
    {
        get => GetProperty<TerraformProperty<string>>("table_id");
        set => WithProperty("table_id", value);
    }

}

/// <summary>
/// Manages a google_bigquery_dataset_access resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_id");
        set => this.WithProperty("dataset_id", value);
    }

    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    public TerraformProperty<string>? GroupByEmail
    {
        get => GetProperty<TerraformProperty<string>>("group_by_email");
        set => this.WithProperty("group_by_email", value);
    }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    public TerraformProperty<string>? IamMember
    {
        get => GetProperty<TerraformProperty<string>>("iam_member");
        set => this.WithProperty("iam_member", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles are
    /// supported. Predefined roles that have equivalent basic roles are
    /// swapped by the API to their basic counterparts, and will show a diff
    /// post-create. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    public TerraformProperty<string>? SpecialGroup
    {
        get => GetProperty<TerraformProperty<string>>("special_group");
        set => this.WithProperty("special_group", value);
    }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    public TerraformProperty<string>? UserByEmail
    {
        get => GetProperty<TerraformProperty<string>>("user_by_email");
        set => this.WithProperty("user_by_email", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public List<GoogleBigqueryDatasetAccessConditionBlock>? Condition
    {
        get => GetProperty<List<GoogleBigqueryDatasetAccessConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public List<GoogleBigqueryDatasetAccessDatasetBlock>? Dataset
    {
        get => GetProperty<List<GoogleBigqueryDatasetAccessDatasetBlock>>("dataset");
        set => this.WithProperty("dataset", value);
    }

    /// <summary>
    /// Block for routine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routine block(s) allowed")]
    public List<GoogleBigqueryDatasetAccessRoutineBlock>? Routine
    {
        get => GetProperty<List<GoogleBigqueryDatasetAccessRoutineBlock>>("routine");
        set => this.WithProperty("routine", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryDatasetAccessTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryDatasetAccessTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    public List<GoogleBigqueryDatasetAccessViewBlock>? View
    {
        get => GetProperty<List<GoogleBigqueryDatasetAccessViewBlock>>("view");
        set => this.WithProperty("view", value);
    }

    /// <summary>
    /// If true, represents that that the iam_member in the config was translated to a different member type by the API, and is stored in state as a different member type
    /// </summary>
    public TerraformExpression ApiUpdatedMember => this["api_updated_member"];

}
