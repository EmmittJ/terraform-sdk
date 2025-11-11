using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetAccessConditionBlock : TerraformBlockBase
{
    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    [TerraformProperty("expression")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Expression { get; set; }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Title { get; set; }

}

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetAccessDatasetBlock : TerraformBlockBase
{
    /// <summary>
    /// Which resources in the dataset this entry applies to. Currently, only views are supported,
    /// but additional target types may be added in the future. Possible values: VIEWS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTypes is required")]
    [TerraformProperty("target_types")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? TargetTypes { get; set; }

}

/// <summary>
/// Block type for routine in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetAccessRoutineBlock : TerraformBlockBase
{
    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformProperty("project_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectId { get; set; }

    /// <summary>
    /// The ID of the routine. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    [TerraformProperty("routine_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoutineId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryDatasetAccessTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Block type for view in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetAccessViewBlock : TerraformBlockBase
{
    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformProperty("project_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformProperty("table_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableId { get; set; }

}

/// <summary>
/// Manages a google_bigquery_dataset_access resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryDatasetAccess : TerraformResource
{
    public GoogleBigqueryDatasetAccess(string name) : base("google_bigquery_dataset_access", name)
    {
    }

    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    [TerraformProperty("group_by_email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GroupByEmail { get; set; }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    [TerraformProperty("iam_member")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IamMember { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles are
    /// supported. Predefined roles that have equivalent basic roles are
    /// swapped by the API to their basic counterparts, and will show a diff
    /// post-create. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    [TerraformProperty("role")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Role { get; set; }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    [TerraformProperty("special_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SpecialGroup { get; set; }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    [TerraformProperty("user_by_email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserByEmail { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformProperty("condition")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessConditionBlock>>? Condition { get; set; }

    /// <summary>
    /// Block for dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    [TerraformProperty("dataset")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessDatasetBlock>>? Dataset { get; set; }

    /// <summary>
    /// Block for routine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routine block(s) allowed")]
    [TerraformProperty("routine")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessRoutineBlock>>? Routine { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBigqueryDatasetAccessTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    [TerraformProperty("view")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessViewBlock>>? View { get; set; }

    /// <summary>
    /// If true, represents that that the iam_member in the config was translated to a different member type by the API, and is stored in state as a different member type
    /// </summary>
    [TerraformProperty("api_updated_member")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ApiUpdatedMember { get; }

}
