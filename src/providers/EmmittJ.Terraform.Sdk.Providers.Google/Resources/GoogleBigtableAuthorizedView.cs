using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subset_view in GoogleBigtableAuthorizedView.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAuthorizedViewSubsetViewBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subset_view";

    /// <summary>
    /// Base64-encoded row prefixes to be included in the authorized view. To provide access to all rows, include the empty string as a prefix (&amp;quot;&amp;quot;).
    /// </summary>
    public TerraformSet<string>? RowPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "row_prefixes").ResolveNodes(ctx));
        set => SetArgument("row_prefixes", value);
    }

    /// <summary>
    /// FamilySubsets block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleBigtableAuthorizedViewSubsetViewBlockFamilySubsetsBlock>? FamilySubsets
    {
        get => GetArgument<TerraformSet<GoogleBigtableAuthorizedViewSubsetViewBlockFamilySubsetsBlock>>("family_subsets");
        set => SetArgument("family_subsets", value);
    }

}

/// <summary>
/// Block type for family_subsets in GoogleBigtableAuthorizedViewSubsetViewBlock.
/// Nesting mode: set
/// </summary>
public class GoogleBigtableAuthorizedViewSubsetViewBlockFamilySubsetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "family_subsets";

    /// <summary>
    /// Name of the column family to be included in the authorized view.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FamilyName is required")]
    public required TerraformValue<string> FamilyName
    {
        get => new TerraformReference<string>(this, "family_name");
        set => SetArgument("family_name", value);
    }

    /// <summary>
    /// Base64-encoded prefixes for qualifiers of the column family to be included in the authorized view. Every qualifier starting with one of these prefixes is included in the authorized view. To provide access to all qualifiers, include the empty string as a prefix (&amp;quot;&amp;quot;).
    /// </summary>
    public TerraformSet<string>? QualifierPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "qualifier_prefixes").ResolveNodes(ctx));
        set => SetArgument("qualifier_prefixes", value);
    }

    /// <summary>
    /// Base64-encoded individual exact column qualifiers of the column family to be included in the authorized view.
    /// </summary>
    public TerraformSet<string>? Qualifiers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "qualifiers").ResolveNodes(ctx));
        set => SetArgument("qualifiers", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigtableAuthorizedView.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableAuthorizedViewTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigtable_authorized_view Terraform resource.
/// Manages a google_bigtable_authorized_view resource.
/// </summary>
public partial class GoogleBigtableAuthorizedView(string name) : TerraformResource("google_bigtable_authorized_view", name)
{
    /// <summary>
    /// A field to make the authorized view protected against data loss i.e. when set to PROTECTED, deleting the authorized view, the table containing the authorized view, and the instance containing the authorized view would be prohibited.
    /// If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value. Note this field configs the deletion protection provided by the API in the backend, and should not be confused with Terraform-side deletion protection.
    /// </summary>
    public TerraformValue<string> DeletionProtection
    {
        get => new TerraformReference<string>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
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
    /// The name of the Bigtable instance in which the authorized view belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => new TerraformReference<string>(this, "instance_name");
        set => SetArgument("instance_name", value);
    }

    /// <summary>
    /// The name of the authorized view. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the Bigtable table in which the authorized view belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// SubsetView block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubsetView block(s) allowed")]
    public TerraformList<GoogleBigtableAuthorizedViewSubsetViewBlock>? SubsetView
    {
        get => GetArgument<TerraformList<GoogleBigtableAuthorizedViewSubsetViewBlock>>("subset_view");
        set => SetArgument("subset_view", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableAuthorizedViewTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableAuthorizedViewTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
