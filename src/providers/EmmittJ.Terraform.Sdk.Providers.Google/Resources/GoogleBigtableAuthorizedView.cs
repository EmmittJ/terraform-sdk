using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subset_view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAuthorizedViewSubsetViewBlock : TerraformBlock
{
    /// <summary>
    /// Base64-encoded row prefixes to be included in the authorized view. To provide access to all rows, include the empty string as a prefix (&amp;quot;&amp;quot;).
    /// </summary>
    public HashSet<TerraformProperty<string>>? RowPrefixes
    {
        set => SetProperty("row_prefixes", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableAuthorizedViewTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
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
/// Manages a google_bigtable_authorized_view resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableAuthorizedView : TerraformResource
{
    public GoogleBigtableAuthorizedView(string name) : base("google_bigtable_authorized_view", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("deletion_protection");
        SetOutput("id");
        SetOutput("instance_name");
        SetOutput("name");
        SetOutput("project");
        SetOutput("table_name");
    }

    /// <summary>
    /// A field to make the authorized view protected against data loss i.e. when set to PROTECTED, deleting the authorized view, the table containing the authorized view, and the instance containing the authorized view would be prohibited.
    /// If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value. Note this field configs the deletion protection provided by the API in the backend, and should not be confused with Terraform-side deletion protection.
    /// </summary>
    public TerraformProperty<string> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
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
    /// The name of the Bigtable instance in which the authorized view belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_name");
        set => SetProperty("instance_name", value);
    }

    /// <summary>
    /// The name of the authorized view. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The name of the Bigtable table in which the authorized view belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// Block for subset_view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubsetView block(s) allowed")]
    public List<GoogleBigtableAuthorizedViewSubsetViewBlock>? SubsetView
    {
        set => SetProperty("subset_view", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableAuthorizedViewTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
