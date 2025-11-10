using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessConditionBlock : ITerraformBlock
{
    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    [TerraformPropertyName("expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Expression { get; set; }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Title { get; set; }

}

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessDatasetBlock : ITerraformBlock
{
    /// <summary>
    /// Which resources in the dataset this entry applies to. Currently, only views are supported,
    /// but additional target types may be added in the future. Possible values: VIEWS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTypes is required")]
    [TerraformPropertyName("target_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? TargetTypes { get; set; }

}

/// <summary>
/// Block type for routine in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessRoutineBlock : ITerraformBlock
{
    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatasetId { get; set; }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformPropertyName("project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectId { get; set; }

    /// <summary>
    /// The ID of the routine. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    [TerraformPropertyName("routine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoutineId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatasetAccessTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Block type for view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessViewBlock : ITerraformBlock
{
    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatasetId { get; set; }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformPropertyName("project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectId { get; set; }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformPropertyName("table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableId { get; set; }

}

/// <summary>
/// Manages a google_bigquery_dataset_access resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDatasetAccess : TerraformResource
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
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatasetId { get; set; }

    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Domain { get; set; }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    [TerraformPropertyName("group_by_email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GroupByEmail { get; set; }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    [TerraformPropertyName("iam_member")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamMember { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles are
    /// supported. Predefined roles that have equivalent basic roles are
    /// swapped by the API to their basic counterparts, and will show a diff
    /// post-create. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    [TerraformPropertyName("role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Role { get; set; }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    [TerraformPropertyName("special_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpecialGroup { get; set; }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    [TerraformPropertyName("user_by_email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserByEmail { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformPropertyName("condition")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessConditionBlock>>? Condition { get; set; } = new();

    /// <summary>
    /// Block for dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    [TerraformPropertyName("dataset")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessDatasetBlock>>? Dataset { get; set; } = new();

    /// <summary>
    /// Block for routine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routine block(s) allowed")]
    [TerraformPropertyName("routine")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessRoutineBlock>>? Routine { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryDatasetAccessTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    [TerraformPropertyName("view")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatasetAccessViewBlock>>? View { get; set; } = new();

    /// <summary>
    /// If true, represents that that the iam_member in the config was translated to a different member type by the API, and is stored in state as a different member type
    /// </summary>
    [TerraformPropertyName("api_updated_member")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ApiUpdatedMember => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "api_updated_member");

}
