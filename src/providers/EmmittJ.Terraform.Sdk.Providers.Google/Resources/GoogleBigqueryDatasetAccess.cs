using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in GoogleBigqueryDatasetAccess.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for dataset in GoogleBigqueryDatasetAccess.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// Which resources in the dataset this entry applies to. Currently, only views are supported,
    /// but additional target types may be added in the future. Possible values: VIEWS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTypes is required")]
    public TerraformList<string>? TargetTypes
    {
        get => GetArgument<TerraformList<string>>("target_types");
        set => SetArgument("target_types", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public required TerraformList<GoogleBigqueryDatasetAccessDatasetBlockDatasetBlock> Dataset
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryDatasetAccessDatasetBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

}

/// <summary>
/// Block type for dataset in GoogleBigqueryDatasetAccessDatasetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessDatasetBlockDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for routine in GoogleBigqueryDatasetAccess.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessRoutineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routine";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the routine. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    public required TerraformValue<string> RoutineId
    {
        get => GetArgument<TerraformValue<string>>("routine_id");
        set => SetArgument("routine_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryDatasetAccess.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatasetAccessTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Block type for view in GoogleBigqueryDatasetAccess.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessViewBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "view";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}


/// <summary>
/// Represents a google_bigquery_dataset_access Terraform resource.
/// Manages a google_bigquery_dataset_access resource.
/// </summary>
public partial class GoogleBigqueryDatasetAccess(string name) : TerraformResource("google_bigquery_dataset_access", name)
{
    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    public TerraformValue<string>? GroupByEmail
    {
        get => GetArgument<TerraformValue<string>>("group_by_email");
        set => SetArgument("group_by_email", value);
    }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    public TerraformValue<string>? IamMember
    {
        get => GetArgument<TerraformValue<string>>("iam_member");
        set => SetArgument("iam_member", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles are
    /// supported. Predefined roles that have equivalent basic roles are
    /// swapped by the API to their basic counterparts, and will show a diff
    /// post-create. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    public TerraformValue<string>? Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    public TerraformValue<string>? SpecialGroup
    {
        get => GetArgument<TerraformValue<string>>("special_group");
        set => SetArgument("special_group", value);
    }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    public TerraformValue<string>? UserByEmail
    {
        get => GetArgument<TerraformValue<string>>("user_by_email");
        set => SetArgument("user_by_email", value);
    }

    /// <summary>
    /// If true, represents that that the iam_member in the config was translated to a different member type by the API, and is stored in state as a different member type
    /// </summary>
    public TerraformValue<bool> ApiUpdatedMember
        => AsReference("api_updated_member");

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Routine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routine block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessRoutineBlock>? Routine
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessRoutineBlock>>("routine");
        set => SetArgument("routine", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryDatasetAccessTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryDatasetAccessTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// View block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessViewBlock>? View
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessViewBlock>>("view");
        set => SetArgument("view", value);
    }

}
